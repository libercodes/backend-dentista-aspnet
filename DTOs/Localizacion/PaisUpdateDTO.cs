using System.ComponentModel.DataAnnotations;

namespace backend.DTOs.Localizacion
{
    public class PaisUpdateDTO
    {
        [Required]
        public long Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Nombre { get; set; }
    }
}