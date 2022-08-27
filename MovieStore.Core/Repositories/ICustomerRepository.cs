using MovieStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Core.Repositories
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Task<Customer> GetSingleCustomerByIdWithFilmsAndGenres(int id);
    }
}
