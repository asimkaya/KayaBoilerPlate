using Abp.Application.Services;
using Kaya.MultiTenancy.Dto;

namespace Kaya.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

