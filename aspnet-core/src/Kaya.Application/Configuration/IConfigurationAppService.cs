using System.Threading.Tasks;
using Kaya.Configuration.Dto;

namespace Kaya.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
