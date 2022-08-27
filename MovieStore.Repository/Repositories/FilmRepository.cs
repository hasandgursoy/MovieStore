using MovieStore.Core.Entities;
using MovieStore.Core.Repositories;
using MovieStore.Repository.MovieStoreDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Repository.Repositories
{
    public class FilmRepository : Repository<Film>, IFilmRepository
    {
        public FilmRepository(MovieAppDbContext context) : base(context)
        {
        }

        public Task<Film> GetSingleFilmByIdWithActressCustomersDirectorAndGenre(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
