using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DA.ProjectManagement.Roles.Dto;
using DA.ProjectManagement.Users.Dto;

namespace DA.ProjectManagement.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}
