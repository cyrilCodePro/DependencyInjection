using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Repository

    {
        private readonly DbContext _context;
      public async Task AddAsync<TEntity>(TEntity entity) where TEntity : class
        {
            await _context.Set<TEntity>().AddAsync(entity);
        }
        public async Task<IEnumerable<TEntity>> ToListAsync<TEntity>() where TEntity : class
        {
            return await _context.Set<TEntity>().ToListAsync();
        }
        public async Task<int> SaveChangesAsync()
        {
           return await _context.SaveChangesAsync();
        }
        public Repository(DbContext context)
        {
            _context = context;
        }
    }

}
