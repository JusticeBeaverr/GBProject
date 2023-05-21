using System.ComponentModel.DataAnnotations;

namespace GadgetBlitzPZ.Models.User
{
    public class UserModel
    {
        public string UserName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid email.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Confirm Password is required")]
        [StringLength(8, ErrorMessage = "Must be between 5 and 8 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [StringLength(8, ErrorMessage = "Must be between 5 and 8 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

    }
}