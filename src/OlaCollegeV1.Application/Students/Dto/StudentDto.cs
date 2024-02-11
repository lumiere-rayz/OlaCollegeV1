using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using OlaCollegeV1.Models;

namespace OlaCollegeV1.Students.Dto
{
    [AutoMapFrom(typeof(Student))]
    public class StudentDto : EntityDto<int>
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string ProgramName { get; set; }
        public string DoB { get; set; }
<<<<<<< HEAD
        public int CollegeId { get; set; }

=======
        public string CollegeID { get; set; }
>>>>>>> 16f89fb30e31934df6bb3fdba9e5f76a14ef8fb2
        public bool IsActive { get; set; }
///Dto.cs.fields1///

        public DateTime CreationTime { get; set; }

        public long? CreatorUserId { get; set; }

    }
}

