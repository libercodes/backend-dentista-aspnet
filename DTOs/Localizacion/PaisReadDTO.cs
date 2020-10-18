using System.ComponentModel.DataAnnotations;

namespace backend.DTOs.Localizacion
{
    public class PaisReadDTO
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
    }
}