using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Denys.Boilerplate.Roles.Dto;

namespace Denys.Boilerplate.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
