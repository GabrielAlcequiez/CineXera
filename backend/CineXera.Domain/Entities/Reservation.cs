using CineXera.Domain.Common;

namespace CineXera.Domain.Entities;

public class Reservation : BaseEntity<Guid>
{
    public ReservationStatus Status { get; set; }
    
    // Foreing Keys
    
    public Guid ClientId { get; set; }
    public Guid ScreeningId { get; set; }
    
    // Properties Navigation 

    public Client Client { get; set; } = null!;
    public Screening Screening { get; set; } = null!;
    
    public ICollection<ReservationDetail> ReservationDetails  { get; set; } =  new List<ReservationDetail>();
    
}