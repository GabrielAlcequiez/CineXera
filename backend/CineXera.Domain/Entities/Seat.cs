namespace CineXera.Domain.Entities;

public class Seat : BaseEntity<Guid>
{
    public string Row { get; set; } = string.Empty;
    public string Number { get; set; } = string.Empty;
    
    // Foreign Keys
    public Guid AuditoriumId { get; set; }
    
    // Navigation Properties
    public Auditorium Auditorium { get; set; } = null!;
}