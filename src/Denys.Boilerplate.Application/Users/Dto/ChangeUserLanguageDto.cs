using System.ComponentModel.DataAnnotations;

namespace Denys.Boilerplate.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}