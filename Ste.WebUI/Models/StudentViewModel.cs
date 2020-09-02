using Ste.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ste.WebUI.Models
{
    public class StudentViewModel
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
