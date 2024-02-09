using System.Threading.Tasks;
using OlaCollegeV1.Configuration.Dto;

namespace OlaCollegeV1.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
