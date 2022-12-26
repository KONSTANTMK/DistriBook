using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DistriBook.Models
{
    public class CategoryModel
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Name")]
        [Required]
        public string Name { get; set; }

        [DisplayName("Dsiplay order")]
        [Range(1, 100, ErrorMessage = "Enter a number from 1 to 100")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
