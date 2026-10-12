namespace CineXera.Domain.Entities;

public class MovieCategory
{
    public Guid CategoryId { get; set; }
    public Guid MovieId { get; set; }
    
    // Navigation Properties
    public Movie Movie { get; set; } = null!;
    public Category Category { get; set; } = null!;
}