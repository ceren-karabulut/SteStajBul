using Ste.Data.Entities;
using Ste.Service.Abstract;
using Ste.Service.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ste.Service.Concrete
{
   public class StudentService : IStudentService
    {
        private IUnit _unit;
        public StudentService(IUnit unit)
        {
            _unit = unit;
        }


        public async Task<int> CreateStudent(Student student)
        {
            return await _unit.Students.InsertAsync(student);
        }

        public async Task DeleteStudent(int id)
        {
            await _unit.Students.DeleteAsync(id);
        }

        public async Task<Student> GetById(int id)
        {
            return await _unit.Students.GetById(id);
        }


        public async Task<IEnumerable<Student>> GetStudentByAdvertisiment(Advertisiment advertisiment)
        {
            return await _unit.Students.GetStudentsByAdvertisiment(advertisiment);
        }
    }
}
