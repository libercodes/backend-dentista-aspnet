using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public abstract class BaseEntity
    {
        [Key]
        public long Id { get; set; }
    }
}