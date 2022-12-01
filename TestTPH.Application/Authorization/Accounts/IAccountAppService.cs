using System.Threading.Tasks;
using Abp.Application.Services;
using TestTPH.Authorization.Accounts.Dto;

namespace TestTPH.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
