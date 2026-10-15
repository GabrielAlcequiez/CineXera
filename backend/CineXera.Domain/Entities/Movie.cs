namespace CineXera.Domain.Entities;

public class Movie : BaseEntity<Guid>
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public short Duration { get; set; }
    public bool IsDeleted {get; set;} = false;
    
    // Navigation Properties
    public ICollection<Screening> Screenings { get; set; } = new List<Screening>();
    public ICollection<MovieCategory> MovieCategories = new List<MovieCategory>();
}