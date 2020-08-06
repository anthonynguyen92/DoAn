using Abp.Application.Services;
using DA.ProjectManagement.MultiTenancy.Dto;

namespace DA.ProjectManagement.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

