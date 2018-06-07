using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HS.Farm.Authorization;

namespace HS.Farm
{
    [DependsOn(
        typeof(FarmCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class FarmApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<FarmAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(FarmApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
