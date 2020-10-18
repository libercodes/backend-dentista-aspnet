using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Direccion : BaseEntity
    {
        [Required]
        [StringLength(30)]
        public string Calle { get; set; }
        [Required]
        public int Numero { get; set; }
        public int Piso { get; set; }
        public string Division { get; set; }
        public string Adicional { get; set; }
        [Required]
        public Localidad Localidad { get; set; }
    }
}