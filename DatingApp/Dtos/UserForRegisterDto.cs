using System.ComponentModel.DataAnnotations;

namespace DatingApp.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        
        [Required]
        [StringLength(8, MinimumLength =4,
        ErrorMessage ="you must specify password between length of 4 to 8")]
        public string Password { get; set; }
    }
}
