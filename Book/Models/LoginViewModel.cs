using System;
using System.ComponentModel.DataAnnotations;

namespace Book.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Username is required")]
        public required string Username { get; set; }

       
        [Required(ErrorMessage = "Password is required")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters")]
        public required string Password { get; set; }
    }
}

