using MovieStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Core.DTOs
{
    public class CustomerWithFilmsAndGenresDto : CustomerDto
    {
        public List<FilmDto> Films { get; set; }
        public List<GenreDto> Genres { get; set; }
    }
}
