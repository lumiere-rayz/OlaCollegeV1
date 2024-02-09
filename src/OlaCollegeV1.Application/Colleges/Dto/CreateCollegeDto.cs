using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using OlaCollegeV1.Models;

namespace OlaCollegeV1.Colleges.Dto
{
    [AutoMapTo(typeof(College))]
    public class CreateCollegeDto
    {
        public string CollegeID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public double GPSLatitude { get; set; }
        public double GPSLongitude { get; set; }
        public string ContactEmail { get; set; }
        public bool IsActive { get; set; }
        ///CreateDto.cs.fields1///

    }
}
