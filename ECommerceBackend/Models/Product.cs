using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http; 
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
namespace ECommerceBackend.Models{
public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public int StockQuantity { get; set; }
    [NotMapped]
    public IFormFile Image { get; set; } 
    [ValidateNever]
    public string ImagePath { get; set; }
}

}
