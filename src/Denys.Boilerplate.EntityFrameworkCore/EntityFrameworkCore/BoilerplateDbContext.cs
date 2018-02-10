using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Denys.Boilerplate.Authorization.Roles;
using Denys.Boilerplate.Authorization.Users;
using Denys.Boilerplate.MultiTenancy;

namespace Denys.Boilerplate.EntityFrameworkCore
{
    public class BoilerplateDbContext : AbpZeroDbContext<Tenant, Role, User, BoilerplateDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public BoilerplateDbContext(DbContextOptions<BoilerplateDbContext> options)
            : base(options)
        {
        }
    }
}
