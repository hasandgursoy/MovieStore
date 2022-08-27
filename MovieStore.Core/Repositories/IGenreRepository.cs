using MovieStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Core.Repositories
{
    public interface IGenreRepository : IRepository<Genre>
    {
        Task<Genre> GetSingleGenreByIdWithFilmsCustomers(int id);

    }
}
