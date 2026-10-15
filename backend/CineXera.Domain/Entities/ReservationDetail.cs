using CineXera.Domain.Common;

namespace CineXera.Domain.Entities;

public class ReservationDetail
{
    public Guid Id { get; set; }
    public SeatStatus Status { get; set; }
    public DateTimeOffset? BlockedUntil { get; set; }
    
    // Foreign Keys
    public Guid ReservationId { get; set; }
    public Guid SeatId { get; set; }
    
    // Navigation Properties
    public Reservation Reservation { get; set; } = null!;
    public Seat? Seat { get; set; } = null!;
}