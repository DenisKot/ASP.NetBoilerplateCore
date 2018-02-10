using Abp.Authorization;
using Denys.Boilerplate.Authorization.Roles;
using Denys.Boilerplate.Authorization.Users;

namespace Denys.Boilerplate.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
