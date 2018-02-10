using System.Threading.Tasks;
using Abp.Application.Services;
using Denys.Boilerplate.Sessions.Dto;

namespace Denys.Boilerplate.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
