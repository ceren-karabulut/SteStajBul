using Ste.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Ste.WebUI.Models
{
    
    public class AdvertisimentListViewModel
    {

        public int AdvertisimentId { get; set; }

        public string CompanyId { get; set; }

        public string CompanyName { get; set; }

        public string Email { get; set; }

        public string JobTitle { get; set; }

        
        public string City { get; set; }

        
        public string JobDesc { get; set; }

        public int NumberOfStudents { get; set; }

        public string Adress { get; set; }

        public DateTime CreateDate { get; set; }

        public CompanyUser CompanyUser { get; set; }

      

       

    }
}
