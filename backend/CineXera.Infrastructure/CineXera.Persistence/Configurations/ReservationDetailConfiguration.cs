using CineXera.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CineXera.Persistence.Configurations
{
    public class ReservationDetailConfiguration : IEntityTypeConfiguration<ReservationDetail>
    {
        public void Configure(EntityTypeBuilder<ReservationDetail> builder)
        {
            builder.ToTable("ReservationDetails");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedNever();
            
            builder.Property(x=> x.Status)
                .IsRequired();

            builder.Property(x=> x.BlockedUntil)
                .IsRequired(false);
            
            builder.HasOne(x => x.Reservation)
                .WithMany(x => x.ReservationDetails)
                .HasForeignKey(x => x.ReservationId)
                .OnDelete(DeleteBehavior.NoAction);
            
            builder.HasOne(x => x.Seat)
                .WithMany()
                .HasForeignKey(x => x.SeatId)
                .OnDelete(DeleteBehavior.NoAction);
            
        }
    }
}