using System.Threading.Tasks;
using Abp.Application.Services;
using TestTPH.Configuration.Dto;

namespace TestTPH.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}