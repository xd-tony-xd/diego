using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRUD_MVC.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        [DisplayName("Nombre de categoria")]
        public string Name { get; set; }

        [DisplayName("Nombre de precio")]
        // rango de 1 a 100 sino error
        [Range(1,100,ErrorMessage ="Precio fuera del rango")]
        public int Price { get; set; }
    }
}
