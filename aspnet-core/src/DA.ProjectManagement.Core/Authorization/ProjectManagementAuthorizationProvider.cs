using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace DA.ProjectManagement.Authorization
{
    public class ProjectManagementAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);

            var management = context.CreatePermission("Administration");

            var student = management.CreateChildPermission(StudentPermission.Student, L("StudentManagement"));
            student.CreateChildPermission(StudentPermission.Default, L("Default"));
            student.CreateChildPermission(StudentPermission.Create, L("Create"));
            student.CreateChildPermission(StudentPermission.Update, L("Update"));
            student.CreateChildPermission(StudentPermission.Delete, L("Delete"));

        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, ProjectManagementConsts.LocalizationSourceName);
        }
    }
}
