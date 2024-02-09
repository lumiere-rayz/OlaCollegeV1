using Abp.Application.Services.Dto;

namespace OlaCollegeV1.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

