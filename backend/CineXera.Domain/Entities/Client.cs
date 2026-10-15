namespace CineXera.Domain.Entities;

public class Client : BaseEntity<Guid>
{
    public string Name { get;  set; } = string.Empty;
    public string Email { get;  set; } =  string.Empty;
    public string PasswordHash { get;  set; } = string.Empty;
    public string Username { get;  set; } = string.Empty;
}