using System.ComponentModel.DataAnnotations;

namespace identityWebApiCore.DTOs {
    public class RegisterDto {
        [Required]
        [StringLength (100, ErrorMessage = "PASSWORD_MIN_LENGTH", MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }
    }
}