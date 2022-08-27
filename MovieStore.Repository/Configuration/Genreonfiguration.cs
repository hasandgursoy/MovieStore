using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Repository.Seeds
{
    public class Genreonfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(50);



            builder.HasData(
            new Genre()
            {
                Id = 1,
                Name = "Epic & Fantastik"
            },
            new Genre()
            {
                Id = 2,
                Name = "Vampires"
            }


            );
          

            

        }

    }
}
