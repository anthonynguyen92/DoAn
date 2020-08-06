using Abp.Authorization;
using DA.ProjectManagement.Authorization.Roles;
using DA.ProjectManagement.Authorization.Users;

namespace DA.ProjectManagement.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
