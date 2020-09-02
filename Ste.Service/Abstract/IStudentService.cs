using Ste.Data.Entities;
using Ste.Service.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ste.Service.Abstract
{
   public interface IStudentService
    {
        Task<Student> GetById(int id);

        Task<IEnumerable<Student>> GetStudentByAdvertisiment(Advertisiment advertisiment);

        Task<int>  CreateStudent(Student student);

        Task DeleteStudent(int id);
       
    }
}
