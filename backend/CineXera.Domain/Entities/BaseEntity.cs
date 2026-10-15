namespace CineXera.Domain.Entities
{
    public class BaseEntity<TId>
    {
        public required TId Id { get; set; } 
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}