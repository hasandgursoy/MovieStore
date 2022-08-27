using MovieStore.Core.DTOs;
using MovieStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Core.Services
{
    public interface IDirectorService : IService<Director>
    {
        public Task<DirectorWithFilmsDto> GetSingleDirectorWithFilms(int directorId);

    }
}
