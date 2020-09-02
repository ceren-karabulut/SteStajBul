using Ste.Data.Entities;
using Ste.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ste.Repository.StudentRepository
{
   public interface IStudentRepository : IBaseRepository<Student>
    {
        Task<IEnumerable<Student>> GetStudentsByAdvertisiment(Advertisiment advertisiment);

      
        
    }
}
