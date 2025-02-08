using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookStore_Razor.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }  // if name is Id or <name>Id then it will be considered as primary key automatically
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100)]
        public int DisplayOrder { get; set; }
    }
}
