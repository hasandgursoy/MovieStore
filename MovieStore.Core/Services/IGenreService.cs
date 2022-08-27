using MovieStore.Core.DTOs;
using MovieStore.Core.Entities;
using MovieStore.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Core.Services
{
    public interface IGenreService : IRepository<Genre>
    {
        public Task<GenreWithFilmsAndCustomersDto> GetSingleGenreByIdWithFilmsAndCustomers(int genreId);

    }
}
