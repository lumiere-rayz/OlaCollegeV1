using Abp.Application.Services;
using OlaCollegeV1.Colleges.Dto;

namespace OlaCollegeV1.Colleges
{
    public interface ICollegeAppService : IAsyncCrudAppService<CollegeDto, int, PagedCollegeResultRequestDto, CreateCollegeDto, UpdateCollegeDto>
    {
      
    }
}

