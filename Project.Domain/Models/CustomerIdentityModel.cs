using Microsoft.AspNet.Identity.EntityFramework;

namespace Project.Domain.Models
{
    public class CustomerIdentityModel : IdentityUser
    {
        public string FullName { get; set; }
    }
}
