using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Mms.Components.Api.FakeServices;
using Mms.Components.Api.Endpoints;
using Mms.Components.Shared;
using System.Net;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Shouldly;
using System.Text.Json;

namespace Mms.Components.Api.Tests;

public class CompanyEndpointTests
{
    [Fact]
    public async Task CompanyRequest_WhenValid_ReturnsOk()
    {
        using var host = await new HostBuilder()
            .ConfigureWebHost(webBuilder =>
            {
                webBuilder
                    .UseTestServer()
                    .ConfigureServices(services =>
                    {
                        services.AddRouting();
                        services.AddSingleton<IFakeCompanyService, FakeCompanyService>();
                    })
                    .Configure(app =>
                    {
                        app.UseRouting();
                        app.UseEndpoints(e =>
                        {
                            e.RegisterCompanyEndpoints();
                        });
                    });
            })
            .StartAsync();

        var client = host.GetTestClient();
        var response = await client.GetAsync("/api/company/");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
    }

    [Fact]
    public async Task CompanyRequest_WhenValid_ReturnsListOfCompanies()
    {
        using var host = await new HostBuilder()
            .ConfigureWebHost(webBuilder =>
            {
                webBuilder
                    .UseTestServer()
                    .ConfigureServices(services =>
                    {
                        services.AddRouting();
                        services.AddSingleton<IFakeCompanyService, FakeCompanyService>();
                    })
                    .Configure(app =>
                    {
                        app.UseRouting();
                        app.UseEndpoints(e =>
                        {
                            e.RegisterCompanyEndpoints();
                        });
                    });
            })
            .StartAsync();

        var client = host.GetTestClient();

        var response = await client.GetAsync("/api/company/");
        var content = await response.Content.ReadAsStringAsync();
        var companies = JsonSerializer.Deserialize<List<Company>>(content);

        companies.ShouldNotBeNull();
        companies.Count.ShouldBeGreaterThan(1);
    }
}