using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Denys.Boilerplate.Roles.Dto;
using Denys.Boilerplate.Users.Dto;

namespace Denys.Boilerplate.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
