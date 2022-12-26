using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DistriBook.Models
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
        [Display(Name = "List price")]
        public int ListPrice { get; set; }
        [Required]
        [Range(1, 10000)]
        [Display(Name = "Price 1-50")]
        public int Price { get; set; }
        [Required]
        [Range(1, 10000)]
        [Display(Name = "Price for 51-100")]
        public int Price50 { get; set; }
        [Required]
        [Display(Name ="Price for 100+")]
        [Range(1, 10000)]
        public int Price100 { get; set; }
        [ValidateNever]
        public string ImageUrl { get; set; }
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public CategoryModel? Category { get; set; }
        [Display(Name ="Cover type")]
        public int CoverTypeId { get; set; }
        [ValidateNever]
        public CoverTypeModel? CoverType { get; set; }
    }
}
