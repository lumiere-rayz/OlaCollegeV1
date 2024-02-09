using Abp.Application.Services;
using OlaCollegeV1.MultiTenancy.Dto;

namespace OlaCollegeV1.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

