
using Ste.Data.Entities;
using Ste.Repository.AdvertisimentRepository;
using Ste.Repository.StudentRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ste.Service.UnitOfWork
{
   public interface IUnit
    {
        IAdvertisimentRepository Advertisiments { get; set; }
        IStudentRepository Students { get; set; }
        
       

    }
}
