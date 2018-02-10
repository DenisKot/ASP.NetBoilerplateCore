using System.Threading.Tasks;
using Denys.Boilerplate.Configuration.Dto;

namespace Denys.Boilerplate.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
