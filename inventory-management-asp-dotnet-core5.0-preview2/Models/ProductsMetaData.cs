using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models
{
    [ModelMetadataType(typeof(ProductsMetaData))]
    public partial class Products
    {
    }

    public class ProductsMetaData
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Unit price")]
        public decimal UnitPrice { get; set; }

        [Required]
        [Display(Name = "Available quantity")]
        public int AvailableQuantity { get; set; }
    }
}
