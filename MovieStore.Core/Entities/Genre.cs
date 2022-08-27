using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Core.Entities
{
    public class Genre: BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Film> Films { get; set; }
        public ICollection<CustomerGenre> Customers { get; set; }
    }
}
