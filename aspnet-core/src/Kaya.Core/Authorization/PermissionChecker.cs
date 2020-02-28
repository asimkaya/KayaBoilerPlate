using Abp.Authorization;
using Kaya.Authorization.Roles;
using Kaya.Authorization.Users;

namespace Kaya.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
