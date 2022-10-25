using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BulkyBook.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [Range(1, 10000)]
        public int ListPrice { get; set; }
        [Required]
        [Range(1, 10000)]
        public int Price { get; set; }
        [Required]
        [Range(1, 10000)]
        public int Price50 { get; set; }
        [Required]
        [Range(1, 10000)]
        public int Price100 { get; set; }
        [ValidateNever]
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public CategoryModel? Category { get; set; }
        public int CoverTypeId { get; set; }
        [ValidateNever]
        public CoverTypeModel? CoverType { get; set; }
    }
}
