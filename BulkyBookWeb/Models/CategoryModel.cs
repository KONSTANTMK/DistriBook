using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class CategoryModel
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Имя")]
        [Required]
        public string Name { get; set; }

        [DisplayName("Порядковый номер")]
        [Range(1,100,ErrorMessage="Введите число от 1 до 100")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
