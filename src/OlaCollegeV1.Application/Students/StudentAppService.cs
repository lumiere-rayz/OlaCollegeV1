using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using OlaCollegeV1.Authorization;
using OlaCollegeV1.Students.Dto;
using OlaCollegeV1.Models;
using Abp.ObjectMapping;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace OlaCollegeV1.Students
{

    [AbpAuthorize(PermissionNames.Pages_Students)]
    public class StudentAppService :
        AsyncCrudAppService<Student, StudentDto, int, PagedStudentResultRequestDto, CreateStudentDto, UpdateStudentDto>,
        IStudentAppService
    {

        private readonly IRepository<Student, int> _studentRepository;
        private readonly Abp.ObjectMapping.IObjectMapper _objectMapper;

        public StudentAppService
        (
            IRepository<Student, int> studentRepository,
            IObjectMapper objectMapper
        )
            : base(studentRepository)
        {
            _studentRepository = studentRepository;
            _objectMapper = objectMapper;
        }

        public async Task<List<StudentDto>> GetMyCustomListAsync()
        {
            var students = await Repository.GetAllListAsync();
            students = students.Where(p => p.Id > 1).ToList();
            return _objectMapper.Map<List<StudentDto>>(students);
        }

        public void CreateMyCustomStudentV1(CreateStudentDto input)
        {
            var student = _objectMapper.Map<Student>(input);
            _studentRepository.Insert(student);
        }

        public void CreateMyCustomStudentV2(CreateStudentDto input)
        {
            // >>>>>.....
            // Your custom logic code goes HERE .....
            // >>>>>.....
            var student = new Student() { FirstName = input.FirstName + "-test", LastName = input.LastName + "-test" };
            student.Address = input.Address;
            student.ProgramName = input.ProgramName;
            student.DoB = input.DoB;
            student.IsActive = input.IsActive;
            Repository.Insert(student);
        }
    }
}
