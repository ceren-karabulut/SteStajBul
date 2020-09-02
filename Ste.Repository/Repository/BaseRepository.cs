using Microsoft.EntityFrameworkCore;
using Ste.Data.Context;
using Ste.Data.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ste.Repository.Repository
{
  public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class 
    {
        private readonly ApplicationDbContext _context;
        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            var entities = _context.Set<TEntity>()
                
                .ToListAsync();
            return await entities;
        }


        public async Task<TEntity> GetById(int id)
        {   

            return await _context.FindAsync<TEntity>(id);
        }

        public  async Task<int>  InsertAsync(TEntity entity)
        {
          await  _context.Set<TEntity>().AddAsync(entity);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateAsync(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            //_context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
           

            var entity = _context.Find<TEntity>(id);
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

       
    }
}
