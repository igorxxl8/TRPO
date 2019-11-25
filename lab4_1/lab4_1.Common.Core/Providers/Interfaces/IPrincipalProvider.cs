using System.Security.Principal;

namespace lab4_1.Common.Core.Providers.Interfaces
{
    public interface IPrincipalProvider
    {
        IPrincipal Principal { get; set; }
    }
}
