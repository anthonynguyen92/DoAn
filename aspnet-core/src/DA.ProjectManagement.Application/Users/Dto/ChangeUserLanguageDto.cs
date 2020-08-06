using System.ComponentModel.DataAnnotations;

namespace DA.ProjectManagement.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}