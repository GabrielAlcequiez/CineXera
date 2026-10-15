namespace CineXera.Domain.Entities;

public class Category : BaseEntity<Guid>
{
    public string Name { get; set; } = string.Empty;
    
    // Navigation Properties
    public ICollection<MovieCategory> MovieCategories  { get; set; } = new List<MovieCategory>();
}