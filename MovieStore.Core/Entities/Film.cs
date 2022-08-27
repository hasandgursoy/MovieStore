using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Core.Entities
{
    public class Film : BaseEntity
    {
        public string Name { get; set; }
        public DateTime Year { get; set; }
        public Genre Genre { get; set; }
        public Director Director { get; set; }
        public ICollection<FilmActress> Actresses { get; set; }
        public double Price { get; set; }
        public ICollection<FilmCustomer> Customers { get; set; }

    }
}
