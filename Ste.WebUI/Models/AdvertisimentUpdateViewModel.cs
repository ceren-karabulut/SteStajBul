using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ste.WebUI.Models
{
    public class AdvertisimentUpdateViewModel
    {
        public int AdvertisimentId { get; set; }

        public string CompanyId { get; set; }

        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string JobTitle { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string JobDesc { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public int NumberOfStudents { get; set; }

        
        public string Adress { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
