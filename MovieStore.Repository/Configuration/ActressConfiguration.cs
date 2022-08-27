using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Repository.Seeds
{
    public class ActressConfiguration : IEntityTypeConfiguration<Actress>
    {
        public void Configure(EntityTypeBuilder<Actress> builder)
        {


            builder.HasData(
                new Actress
                {
                    Id = 1,
                    Name = "Orlando",
                    Surname = "Bloom",
                    Films = { new FilmActress { FilmId = 1 } },


                },
                new Actress
                {
                    Id = 2,
                    Name = "Elijah",
                    Surname = "Wood",
                    Films = { new FilmActress { FilmId = 1 } },


                },
                new Actress
                {
                    Id = 3,
                    Name = "Kate",
                    Surname = "Beckinsale",
                    Films = { new FilmActress { FilmId = 2 } },

                },
                new Actress
                {
                    Id = 4,
                    Name = "Tony",
                    Surname = "Curran",
                    Films = { new FilmActress { FilmId = 2 } },


                }




                );
        }

    }
}
