using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Videotheque.Mvc.Models
{
    public class RegisterForm
    {
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(320)]
        public string Email { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 8)]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Passwd { get; set; }
        [Compare(nameof(Passwd))]
        [Display(Name = "Confirm password")]
        [DataType(DataType.Password)]
        public string Confirm { get; set; }
    }
}
