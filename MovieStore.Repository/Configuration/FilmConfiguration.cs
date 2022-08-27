using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Repository.Seeds
{
    public class FilmConfiguration : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            


            builder.HasData(
                new Film()
                {
                    Id = 1,
                    Name = "Lord Of The Rings",
                    Year = new DateTime(2008, 5, 15),
                    Actresses = {new FilmActress { ActressId = 1} ,new FilmActress { ActressId=2} },
                    Customers = {new FilmCustomer { CustomerId = 1} },
                    Price = 45,
                    Genre = new Genre() { Id = 1 },
                    Director = new Director() { Id = 1 },

                },
                new Film()
                {
                    Id = 2,
                    Name = "Under World",
                    Year = new DateTime(2008, 5, 15),
                    Actresses = { new FilmActress { ActressId = 3}, new FilmActress { ActressId = 4 } },
                    Customers = {new FilmCustomer { CustomerId = 2} },
                    Price = 60,
                    Director = new Director() { Id = 2 },
                    Genre = new Genre() { Id = 2 },


                }


                );


        }


    }
}
