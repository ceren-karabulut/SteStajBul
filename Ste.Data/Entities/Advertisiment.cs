using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ste.Data.Entities
{
  public class Advertisiment
    {   
        
        public int AdvertisimentId { get; set; }

        public CompanyUser CompanyUser{ get; set; }
        public string CompanyId { get; set; }

        public string JobTitle { get; set; }

        public string City { get; set; }

        public string JobDesc { get; set; }

        public int NumberOfStudents { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
