using System.Threading.Tasks;
using Abp.Application.Services;
using TestTPH.Sessions.Dto;

namespace TestTPH.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
