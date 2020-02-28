using System.ComponentModel.DataAnnotations;

namespace Kaya.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}