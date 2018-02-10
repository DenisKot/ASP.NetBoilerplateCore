using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using Denys.Boilerplate.Authorization.Users;
using Denys.Boilerplate.Editions;

namespace Denys.Boilerplate.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
