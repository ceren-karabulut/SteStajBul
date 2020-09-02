using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ste.Data.Entities
{
   public class CompanyUser : IdentityUser
    {
        public string CompanyName { get; set; }
        public string  AdressDetail { get; set; }

        public ICollection<Advertisiment> Advertisiments { get; set; }


    }
}
