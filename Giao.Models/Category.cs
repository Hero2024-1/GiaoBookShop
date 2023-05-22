using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GiaoBook.Models
{
    public class Category
    {

        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter the {0}")]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display Order must be between 1-100")]
        public int DisplayOrder { get; set; }
    }
}
