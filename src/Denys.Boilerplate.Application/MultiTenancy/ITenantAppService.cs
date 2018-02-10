using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Denys.Boilerplate.MultiTenancy.Dto;

namespace Denys.Boilerplate.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
