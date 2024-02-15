using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace GiftStoreApplication.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string UserName { get; set; }
        public string Address { get; set; }
        public int PostalCode {  get; set; }
    }
}
