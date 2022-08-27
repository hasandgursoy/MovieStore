using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Repository.Seeds
{
    public class Customeronfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer
                {
                    Id = 1,
                    Name="Marcus",
                    Surname="Corvinus",
                    Films= { new FilmCustomer { FilmId = 1 } },
                    FavoriteGenres = { new CustomerGenre { GenreId = 1 } },                   
                },
                new Customer
                {
                    Id = 2,
                    Name = "William",
                    Surname = "Corvinus",
                    Films = { new FilmCustomer { FilmId = 2} },
                    FavoriteGenres = { new CustomerGenre { GenreId = 2 } },
                }
                );;


        }

    }
}
