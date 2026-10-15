using CineXera.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CineXera.Persistence.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Clients");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.Property(x=>x.Name)
                .HasMaxLength(100)
                .IsRequired();
            
            builder.Property(x=> x.Email)
                .IsRequired()
                .HasMaxLength(100);
            builder.HasIndex(x=>x.Email).IsUnique();

            builder.Property(x=> x.Username)
                .IsRequired()
                .HasMaxLength(50);
            builder.HasIndex(x=>x.Username).IsUnique();

            builder.Property(x=>x.PasswordHash)
                .IsRequired()
                .HasMaxLength(255);
            
            

        }
    }
}