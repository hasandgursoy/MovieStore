using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Repository.Configuration
{
    public class FilmCustomerConfiguration : IEntityTypeConfiguration<FilmCustomer>
    {
        public void Configure(EntityTypeBuilder<FilmCustomer> builder)
        {
            builder.HasKey(ky => new { ky.FilmId, ky.CustomerId });

            builder.HasOne(fc => fc.Film)
                .WithMany(f => f.Customers)
                .HasForeignKey(fc => fc.FilmId);

            builder.HasOne(fc => fc.Customer)
                .WithMany(f => f.Films)
                .HasForeignKey(fc => fc.CustomerId);
        }
    }
}
