using Bogus;
using Mms.Components.Shared;

namespace Mms.Components.Api.FakeServices;

public class FakeCompanyService : IFakeCompanyService
{
    private List<Company>? _companies;

    public List<Company> Companies
    {
        get
        {
            if (_companies == null)
            {
                var generator = GetCompanyGenerator();
                _companies = generator.Generate(1342);
            }

            return _companies;
        }
    }

    private Faker<Company> GetCompanyGenerator()
    {
        return new Faker<Company>()
            .StrictMode(true)
            .RuleFor(c => c.Id, f => f.IndexFaker)
            .RuleFor(c => c.Suffix, f => f.Company.CompanySuffix())
            .RuleFor(c => c.Name, f => f.Company.CompanyName())
            .RuleFor(c => c.Reference, f => f.Company.Random.String2(10).ToUpper());
    }
}
