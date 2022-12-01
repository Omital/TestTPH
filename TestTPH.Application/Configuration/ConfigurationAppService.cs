using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TestTPH.Configuration.Dto;

namespace TestTPH.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TestTPHAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
