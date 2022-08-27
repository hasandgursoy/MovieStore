using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Core.Entities
{
    public class CustomerGenre
    {
        public int CustomerId { get; set; }
        public int GenreId { get; set; }
        public Customer Customer { get; set; }
        public Genre Genre { get; set; }
    }
}
