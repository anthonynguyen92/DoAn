using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DA.ProjectManagement.Authorization;

namespace DA.ProjectManagement
{
    [DependsOn(
        typeof(ProjectManagementCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ProjectManagementApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ProjectManagementAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ProjectManagementApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
