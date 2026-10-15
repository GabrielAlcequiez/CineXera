using CineXera.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CineXera.Persistence.Configurations
{
    public class SeatConfiguration : IEntityTypeConfiguration<Seat>
    {
        public void Configure(EntityTypeBuilder<Seat> builder)
        {
            builder.ToTable("Seats");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedNever();
            builder.HasIndex(x => new
            {
                x.AuditoriumId,
                x.Row,
                x.Number
            }).IsUnique();

            builder.Property(x => x.Id)
                .ValueGeneratedNever();

            builder.Property(x => x.Row)
                .IsRequired()
                .HasMaxLength(2);

            builder.Property(x => x.Number)
                .IsRequired();

            builder.HasOne(x => x.Auditorium)
                .WithMany(x => x.Seats)
                .HasForeignKey(x => x.AuditoriumId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}