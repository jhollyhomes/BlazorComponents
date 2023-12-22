using Mms.Components.Api.FakeServices;
using Mms.Components.Api.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IFakeCompanyService, FakeCompanyService>();

var app = builder.Build();

var mapGroup = app.MapGroup("api/company");
mapGroup.MapGet("/", GetCompanys);

app.Run();

static List<Company> GetCompanys(IFakeCompanyService companyService)
{
    return companyService.Companies;
}
