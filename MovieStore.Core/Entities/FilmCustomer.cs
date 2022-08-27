using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Core.Entities
{
    public class FilmCustomer
    {
        public int FilmId { get; set; }
        public int CustomerId { get; set; }
        public Film Film { get; set; }
        public Customer Customer { get; set; }
    }
}
