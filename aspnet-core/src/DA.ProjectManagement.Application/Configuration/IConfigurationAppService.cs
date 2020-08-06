using System.Threading.Tasks;
using DA.ProjectManagement.Configuration.Dto;

namespace DA.ProjectManagement.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
