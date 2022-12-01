using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TestTPH.MultiTenancy.Dto;

namespace TestTPH.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
