using System.Threading.Tasks;
using HS.Farm.Configuration.Dto;

namespace HS.Farm.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
