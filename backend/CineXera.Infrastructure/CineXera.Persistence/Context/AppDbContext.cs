using CineXera.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace CineXera.Persistence.Context;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    #region DbSets
    
    public DbSet<Client> Client {get; set;}
    public DbSet<Auditorium> Auditorium {get; set;}
    public DbSet<Category> Category {get; set;}
    public DbSet<Movie> Movie {get; set;}
    public DbSet<MovieCategory> MovieCategory {get; set;}
    public DbSet<Reservation> Reservation {get; set;}
    public DbSet<ReservationDetail> ReservationDetail {get; set;}
    public DbSet<Screening> Screening {get; set;}
    public DbSet<Seat> Seat {get; set;}
    
    #endregion 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}