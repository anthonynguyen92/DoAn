using System.Threading.Tasks;
using Abp.Application.Services;
using DA.ProjectManagement.Sessions.Dto;

namespace DA.ProjectManagement.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
