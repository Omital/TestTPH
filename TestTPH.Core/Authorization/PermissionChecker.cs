using Abp.Authorization;
using TestTPH.Authorization.Roles;
using TestTPH.Authorization.Users;

namespace TestTPH.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
