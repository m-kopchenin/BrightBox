using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BrightBox.Api.Infrastructure
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength]
        public string FirstName { get; set; }

        [Required]
        [MaxLength]
        public string LastName { get; set; }
    }
}