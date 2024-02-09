using System.ComponentModel.DataAnnotations;

namespace OlaCollegeV1.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}