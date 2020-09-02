using Microsoft.EntityFrameworkCore;
using Ste.Data.Context;
using Ste.Data.Entities;
using Ste.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ste.Repository.StudentRepository
{
   public class StudentRepository : BaseRepository<Student> , IStudentRepository
    {
        private readonly ApplicationDbContext _context;
        public StudentRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

      

        public async Task<IEnumerable<Student>> GetStudentsByAdvertisiment(Advertisiment advertisiment)
        {
            var students = await _context.Students
                .Include(a => a.Advertisiment)
                .Where(s => s.AdvertisimentId == advertisiment.AdvertisimentId)
                .ToListAsync();

            return students;
        }
    }
}
