using System.ComponentModel.DataAnnotations;

namespace Project.Domain.Models
{
    public class CustomerModel : BaseModel
    {
        [Required]
        [Display(Name = "Nome")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "E-mail")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
