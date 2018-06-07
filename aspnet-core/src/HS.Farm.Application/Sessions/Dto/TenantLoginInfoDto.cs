using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HS.Farm.MultiTenancy;

namespace HS.Farm.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
