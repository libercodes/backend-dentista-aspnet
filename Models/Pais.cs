using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Pais : BaseEntity
    {
        [Required]
        [StringLength(30)]
        public string Nombre { get; set; }
    }
}