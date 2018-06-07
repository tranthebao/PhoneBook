using System.Threading.Tasks;
using Abp.Application.Services;
using HS.Farm.Sessions.Dto;

namespace HS.Farm.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
