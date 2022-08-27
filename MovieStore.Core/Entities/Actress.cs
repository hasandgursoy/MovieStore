using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Core.Entities
{
    public class Actress : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public ICollection<FilmActress> Films { get; set; }
    }
}
