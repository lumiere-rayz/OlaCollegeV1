using Abp.Authorization;
using OlaCollegeV1.Authorization.Roles;
using OlaCollegeV1.Authorization.Users;

namespace OlaCollegeV1.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
