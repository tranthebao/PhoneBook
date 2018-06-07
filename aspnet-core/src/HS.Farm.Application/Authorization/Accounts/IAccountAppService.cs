using System.Threading.Tasks;
using Abp.Application.Services;
using HS.Farm.Authorization.Accounts.Dto;

namespace HS.Farm.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
