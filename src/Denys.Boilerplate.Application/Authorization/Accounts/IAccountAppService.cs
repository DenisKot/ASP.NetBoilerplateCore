using System.Threading.Tasks;
using Abp.Application.Services;
using Denys.Boilerplate.Authorization.Accounts.Dto;

namespace Denys.Boilerplate.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
