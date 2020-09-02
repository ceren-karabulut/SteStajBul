using Ste.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ste.Repository.Repository
{
   public interface IBaseRepository <TEntity> where TEntity : class 
    {
        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<TEntity> GetById(int id);

        Task <int> InsertAsync(TEntity entity);

        Task <int> UpdateAsync(TEntity entity);

        Task DeleteAsync(int id);

       
      
    }
}
