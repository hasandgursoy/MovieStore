using MovieStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Core.Repositories
{
    public interface IDirectorRepository: IRepository<Director>
    {
        Task<Director> GetSingleDirectorByIdWithFilms(int id);

    }
}
