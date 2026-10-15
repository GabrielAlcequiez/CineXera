using CineXera.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CineXera.Persistence.Configurations
{
    public class MovieCategoryConfiguration : IEntityTypeConfiguration<MovieCategory>
    {
        public void Configure(EntityTypeBuilder<MovieCategory> builder)
        {
            builder.ToTable("Movie_Categories");

            builder.HasKey(x => new
            {
                x.MovieId,
                x.CategoryId
            });

            builder.HasOne(x => x.Movie)
                .WithMany(x => x.MovieCategories)
                .HasForeignKey(x => x.MovieId)
                .OnDelete(DeleteBehavior.NoAction);


            builder.HasOne(x => x.Category)
                .WithMany(x => x.MovieCategories)
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}