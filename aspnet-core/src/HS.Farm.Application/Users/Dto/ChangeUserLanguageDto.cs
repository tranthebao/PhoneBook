using System.ComponentModel.DataAnnotations;

namespace HS.Farm.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}