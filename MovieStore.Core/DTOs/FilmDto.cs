using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Core.DTOs
{
    public class FilmDto : BaseDto
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime Year { get; set; }

    }
}
