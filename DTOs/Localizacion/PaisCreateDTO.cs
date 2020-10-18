using System.ComponentModel.DataAnnotations;

namespace backend.DTOs.Localizacion
{
    public class PaisCreateDTO
    {
        [Required]
        [StringLength(30)]
        public string Nombre { get; set; }
    }
}