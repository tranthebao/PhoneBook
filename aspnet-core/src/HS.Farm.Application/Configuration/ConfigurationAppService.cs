using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using HS.Farm.Configuration.Dto;

namespace HS.Farm.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : FarmAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
