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
    public class CustomerGenreConfiguration : IEntityTypeConfiguration<CustomerGenre>
    {
        public void Configure(EntityTypeBuilder<CustomerGenre> builder)
        {
            builder.HasKey(cg => new { cg.GenreId,cg.CustomerId });
        }
    }
}
