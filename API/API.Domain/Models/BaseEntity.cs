using System.ComponentModel.DataAnnotations.Schema;

namespace API.Domain.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        [Column(TypeName = "created_at")]
        public DateTime CreatedAt { get; set; }
        [Column(TypeName = "deleted_at")]
        public DateTime? DeletedAt { get; set; }
    }
}
