using CineXera.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CineXera.Persistence.Configurations
{
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.ToTable("Reservations");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.Property(x => x.Status)
                .IsRequired()
                .HasMaxLength(20);
            
            builder.Property(x=>x.ScreeningId)
                .IsRequired();

            builder.Property(x=>x.ClientId)
                .IsRequired();

            builder.HasOne(x => x.Client)
                .WithMany()
                .HasForeignKey(x => x.ClientId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Screening)
                .WithMany()
                .HasForeignKey(x=> x.ScreeningId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}