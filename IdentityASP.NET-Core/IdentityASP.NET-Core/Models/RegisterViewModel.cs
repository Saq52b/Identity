using System.ComponentModel.DataAnnotations;

namespace IdentityASP.NET_Core.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name ="Email")]
        public string Email { get; set; }
        [Required]
        [StringLength(100,ErrorMessage ="The 0 must be at last 2 cractor long",MinimumLength =6)]
        [DataType(DataType.Password)]
        [Display(Name ="Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name ="ComfurmPassword")]
        [Compare("Password",ErrorMessage ="The Password and confurm password do not match")]
        public string ConfurmPassword { get; set; }

        public string Name { get; set; }

    }
}
