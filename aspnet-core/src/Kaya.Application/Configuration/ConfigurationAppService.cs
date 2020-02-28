using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Kaya.Configuration.Dto;

namespace Kaya.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : KayaAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
