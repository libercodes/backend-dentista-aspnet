using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Localidad : BaseEntity
    {
        [Required]
        [StringLength(30)]
        public string Nombre { get; set; }
        [Required]
        public Provincia Provincia { get; set; }
    }
}