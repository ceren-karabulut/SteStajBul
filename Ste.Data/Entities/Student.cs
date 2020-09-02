using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ste.Data.Entities
{
  public  class Student
    {   
        
        public int StudentId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime DateOfGraduation { get; set; }

        public string University { get; set; }

        public string Section { get; set; }

        public string Bio { get; set; }

        public int DayOfIntern { get; set; }

        public string City { get; set; }

        public string Telephone { get; set; }

        public Advertisiment Advertisiment { get; set; }
        public int AdvertisimentId { get; set; }
    }
}
