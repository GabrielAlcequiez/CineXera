namespace CineXera.Domain.Entities;

public class Screening : BaseEntity<Guid>
{
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    
    // Foreign Keys
    public Guid MovieId { get; set; }
    public Guid AuditoriumId { get; set; }
    
    // Properties Navigation
    public Movie Movie { get; set; } = null!;
    public Auditorium Auditorium { get; set; } = null!;
}