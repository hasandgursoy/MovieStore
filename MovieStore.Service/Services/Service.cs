using Microsoft.EntityFrameworkCore;
using MovieStore.Core.Entities;
using MovieStore.Core.Repositories;
using MovieStore.Core.Services;
using MovieStore.Repository.MovieStoreDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Service.Services
{
    public class Service<T> : IService<T> where T : BaseEntity
    {
        private readonly IRepository<T> _repository;

        public Service(IRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _repository.AddAsync(entity);
            await _repository.SaveAsync();
            return entity;
            
        }

        public async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entites)
        {
            await _repository.AddRangeAsync(entites);
            await _repository.SaveAsync();
            return entites;
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            return await _repository.AnyAsync(expression);
        }
        public async Task<T> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAll().ToListAsync();
            
        }
        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _repository.Where(expression);
        }
      
        public async Task RemoveAsync(T entity)
        {
            _repository.Remove(entity);
            await _repository.SaveAsync();
        }

        public async Task RemoveRangeAsync(IEnumerable<T> entities)
        {
            _repository.RemoveRange(entities);
            await _repository.SaveAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _repository.Update(entity);
            await _repository.SaveAsync();
        }

        
    }

  
}

