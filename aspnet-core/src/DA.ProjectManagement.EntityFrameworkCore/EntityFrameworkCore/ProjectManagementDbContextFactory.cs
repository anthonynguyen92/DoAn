using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using DA.ProjectManagement.Configuration;
using DA.ProjectManagement.Web;

namespace DA.ProjectManagement.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ProjectManagementDbContextFactory : IDesignTimeDbContextFactory<ProjectManagementDbContext>
    {
        public ProjectManagementDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ProjectManagementDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ProjectManagementDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ProjectManagementConsts.ConnectionStringName));

            return new ProjectManagementDbContext(builder.Options);
        }
    }
}
