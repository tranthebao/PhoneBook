using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HS.Farm.Roles.Dto;
using HS.Farm.Users.Dto;

namespace HS.Farm.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
