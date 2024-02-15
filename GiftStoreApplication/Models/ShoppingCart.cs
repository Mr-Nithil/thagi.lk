using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GiftStoreApplication.Models
{
    public class ShoppingCart
    {
        [Key]
        public int Id { get; set; }


        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        [ValidateNever]

        public Product Product { get; set; }

        public int Count { get; set; }

        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        [ValidateNever]

        public ApplicationUser ApplicationUser { get; set; }

    }
}
