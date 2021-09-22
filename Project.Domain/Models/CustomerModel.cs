using System.ComponentModel.DataAnnotations;

namespace Project.Domain.Models
{
    public class CustomerModel : BaseModel
    {
        [Required]
        [Display(Name = "Nome")]
        public string Name { get; set; }
    }
}
