using Mms.Components.Api.FakeServices;
using Mms.Components.Shared;

namespace Mms.Components.Api.Endpoints;

public static class CompanyEndpoints
{
    public static void RegisterCompanyEndpoints(this IEndpointRouteBuilder builder)
    {
        var mapGroup = builder.MapGroup("/api/company");
        mapGroup.MapGet("/", GetCompanys);
    }

    static List<Company> GetCompanys(IFakeCompanyService companyService)
    {
        return companyService.Companies;
    }
}