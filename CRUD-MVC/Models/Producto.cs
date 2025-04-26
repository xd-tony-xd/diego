using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CRUD_MVC.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        [DisplayName("Nombre de producto")]
        public string Nombre { get; set; }
        [DisplayName("Nombre de precio")]
        // rango de 1 a 100 sino error
        [Range(1,100,ErrorMessage ="Precio fuera del rango")]
        public decimal Precio { get; set; }
        public int CategoriaId { get; set; }
    }
}
