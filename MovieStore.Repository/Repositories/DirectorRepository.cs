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
    public class DirectorRepository : Repository<Director>, IDirectorRepository
    {
        public DirectorRepository(MovieAppDbContext context) : base(context)
        {
        }

        public Task<Director> GetSingleDirectorByIdWithFilms(int id)
        {
            throw new NotImplementedException();
        }
    }
}
