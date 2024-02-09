using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using OlaCollegeV1.Authorization;
using OlaCollegeV1.Students.Dto;
using OlaCollegeV1.Models;

namespace OlaCollegeV1.Students
{

    [AbpAuthorize(PermissionNames.Pages_Students)]
    public class StudentAppService : AsyncCrudAppService<Student, StudentDto, int, PagedStudentResultRequestDto, CreateStudentDto, UpdateStudentDto>, IStudentAppService
    {
        public StudentAppService
        (
            IRepository<Student, int> repository
        )
        : base(repository)
        {

        }

    }
}
