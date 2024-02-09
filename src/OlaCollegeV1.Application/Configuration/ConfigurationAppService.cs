using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using OlaCollegeV1.Configuration.Dto;

namespace OlaCollegeV1.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : OlaCollegeV1AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
