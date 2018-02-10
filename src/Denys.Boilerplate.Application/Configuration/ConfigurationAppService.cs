using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Denys.Boilerplate.Configuration.Dto;

namespace Denys.Boilerplate.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : BoilerplateAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
