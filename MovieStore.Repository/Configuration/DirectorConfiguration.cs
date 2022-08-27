using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Repository.Seeds
{
    public class DirectorConfiguration : IEntityTypeConfiguration<Director>
    {

        public void Configure(EntityTypeBuilder<Director> builder)
        {
            builder.HasKey(x => x.Id);


            builder.HasData(
                new Director()
                {
                    Id = 1,
                    Name = "Peter",
                    Surname= "Jackson",
                    Films = {new Film { Id = 1} }
                    
                },
                new Director()
                {
                    Id = 2,
                    Name = "Len",
                    Surname = "Wiseman",
                    Films = { new Film { Id = 2 } }

                }
                );
        }


    }
}
