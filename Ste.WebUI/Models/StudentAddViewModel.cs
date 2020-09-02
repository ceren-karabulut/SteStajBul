using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ste.WebUI.Models
{
    public class StudentAddViewModel
    {
        public int AdvertisimentId { get; set; }

        public int StudentId { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage ="Lütfen geçerli bir email adresi giriniz.")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        
        public DateTime DateOfGraduation { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Section { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Bio { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public int DayOfIntern { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string City { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Telephone { get; set; }
    }
}
