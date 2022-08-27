using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Core.Entities
{
    public class FilmActress
    {
        public int FilmId { get; set; }
        public int ActressId { get; set; }
        public Film Film { get; set; }
        public Actress Actress { get; set; }

    }
}
