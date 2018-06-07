using Abp.Authorization;
using HS.Farm.Authorization.Roles;
using HS.Farm.Authorization.Users;

namespace HS.Farm.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
