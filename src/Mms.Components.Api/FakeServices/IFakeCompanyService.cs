using Mms.Components.Api.Models;

namespace Mms.Components.Api.FakeServices;
public interface IFakeCompanyService
{
    List<Company> Companies { get; }
}