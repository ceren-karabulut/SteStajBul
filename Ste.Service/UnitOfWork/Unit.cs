using Ste.Data.Context;
using Ste.Data.Entities;
using Ste.Repository.AdvertisimentRepository;
using Ste.Repository.StudentRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ste.Service.UnitOfWork
{
  public  class Unit : IUnit
    {
        public ApplicationDbContext _context;
        public Unit(ApplicationDbContext context)
        {
            _context = context;
            Advertisiments = new AdvertisimentRepository(_context);
            Students = new StudentRepository(_context);
        }

        public IAdvertisimentRepository Advertisiments { get; set; }

        public IStudentRepository Students { get ; set ; }

       
    }
}
