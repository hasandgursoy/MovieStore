
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
    public class ActressRepository : Repository<Actress>, IActressRepository
    {
        public ActressRepository(MovieAppDbContext context) : base(context)
        {
        }

        public Task<Actress> GetSingleActressByIdWithFilms(int id)
        {
            throw new NotImplementedException();
        }
    }
}
