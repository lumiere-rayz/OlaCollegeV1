using Abp.Application.Services;
using OlaCollegeV1.Students.Dto;

namespace OlaCollegeV1.Students
{
    public interface IStudentAppService : IAsyncCrudAppService<StudentDto, int, PagedStudentResultRequestDto, CreateStudentDto, UpdateStudentDto>
    {
      
    }
}

