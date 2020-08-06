using Abp.Zero.EntityFrameworkCore;
using DA.ProjectManagement.Authorization.Roles;
using DA.ProjectManagement.Authorization.Users;
using DA.ProjectManagement.MultiTenancy;
using DA.ProjectManagement.Students;
using DA.ProjectManagement.Teachers;
using Microsoft.EntityFrameworkCore;

namespace DA.ProjectManagement.EntityFrameworkCore
{
    public class ProjectManagementDbContext : AbpZeroDbContext<Tenant, Role, User, ProjectManagementDbContext>
    {

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        /* Define a DbSet for each entity of the application */
        public ProjectManagementDbContext(DbContextOptions<ProjectManagementDbContext> options)
            : base(options)
        {
        }
    }
}
