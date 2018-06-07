using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HS.Farm.MultiTenancy.Dto;

namespace HS.Farm.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
