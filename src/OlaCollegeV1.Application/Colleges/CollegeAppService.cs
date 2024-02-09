using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using OlaCollegeV1.Authorization;
using OlaCollegeV1.Colleges.Dto;
using OlaCollegeV1.Models;
using Abp.ObjectMapping;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace OlaCollegeV1.Colleges
{

    [AbpAuthorize(PermissionNames.Pages_Colleges)]
    public class CollegeAppService : AsyncCrudAppService<College, CollegeDto, int, PagedCollegeResultRequestDto, CreateCollegeDto, UpdateCollegeDto>, ICollegeAppService
    {
        public CollegeAppService
        (
            IRepository<College, int> repository
        )
        : base(repository)
        {

        }

    }
}
