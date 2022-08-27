using MovieStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Core.DTOs
{
    public class FilmWithActressesCustomersGenreAndDirectorDto : FilmDto
    {
        public List<CustomerDto> Customers { get; set; }
        public List<ActressDto> Actresses { get; set; }
        public Genre Genre { get; set; }
        public Director Director { get; set; }


    }
}
