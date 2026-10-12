namespace CineXera.Domain.Entities;

public class Category
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    
    // Navigation Properties
    public ICollection<MovieCategory> MovieCategories  { get; set; } = new List<MovieCategory>();
}