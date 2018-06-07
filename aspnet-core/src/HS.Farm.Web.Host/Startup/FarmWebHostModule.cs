using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HS.Farm.Configuration;

namespace HS.Farm.Web.Host.Startup
{
    [DependsOn(
       typeof(FarmWebCoreModule))]
    public class FarmWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public FarmWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FarmWebHostModule).GetAssembly());
        }
    }
}
