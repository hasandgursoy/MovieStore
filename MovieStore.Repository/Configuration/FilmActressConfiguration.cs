using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Repository.Configuration
{
    public class FilmActressConfiguration : IEntityTypeConfiguration<FilmActress>
    {
        public void Configure(EntityTypeBuilder<FilmActress> builder)
        {
            builder.HasKey(ky => new { ky.FilmId, ky.ActressId });

            builder.HasOne(fa => fa.Film)
                .WithMany(f => f.Actresses)
                .HasForeignKey(fa => fa.FilmId);

            builder.HasOne(fa => fa.Actress)
                .WithMany(a => a.Films)
                .HasForeignKey(fa => fa.ActressId);
        }
    }
}
