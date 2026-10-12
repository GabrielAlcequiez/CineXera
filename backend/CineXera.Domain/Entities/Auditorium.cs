namespace CineXera.Domain.Entities;

public class Auditorium
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    
    // Navigation Properties
    public ICollection<Seat> Seats { get; set; } = new List<Seat>();
    public ICollection<Screening> Screenings { get; set; } =  new List<Screening>();
}