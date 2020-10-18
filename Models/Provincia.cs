using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Provincia : BaseEntity
    {
        [Required]
        [StringLength(30)]
        public string Nombre { get; set; }
        public Pais Pais { get; set; }
    }
}