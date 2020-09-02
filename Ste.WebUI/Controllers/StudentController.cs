using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ste.Data.Context;
using Ste.Data.Entities;
using Ste.Service.Abstract;
using Ste.WebUI.Models;


namespace Ste.WebUI.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        private readonly IAdvertisimentService _advertisimentService;
        private readonly UserManager<CompanyUser> _userManager;
        private readonly ApplicationDbContext _db;



        public StudentController(IStudentService studentService, IAdvertisimentService advertisimentService, UserManager<CompanyUser> userManager, ApplicationDbContext db)
        {
            _studentService = studentService;
            _advertisimentService = advertisimentService;
            _userManager = userManager;
            _db = db;
        }


        public async Task<IActionResult> Index(string key)
        {
            List<AdvertisimentListViewModel> models = new List<AdvertisimentListViewModel>();


            var ads = await _advertisimentService.GetAdvertisimentsBySearch(key);
            foreach (var item in ads)
            {
                models.Add(new AdvertisimentListViewModel
                {
                    CompanyId = item.CompanyId,
                    AdvertisimentId = item.AdvertisimentId,
                    City = item.City,
                    JobTitle = item.JobTitle,
                    CompanyName = item.CompanyUser.CompanyName
                    
                });
            }

            return View(models);
        }


        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Apply(int id, StudentViewModel model)
        {
            var ads = await _advertisimentService.GetById(id);

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            Student student = new Student
            {

                AdvertisimentId = ads.AdvertisimentId,
                StudentId = model.StudentId,
                Name = model.Name,
                Email = model.Email,
                DateOfGraduation = model.DateOfGraduation,
                University = model.University,
                Section = model.Section,
                Bio = model.Bio,
                DayOfIntern = model.DayOfIntern,
                City = model.City,
                Telephone = model.Telephone,
            };

            var affectedRow = await _studentService.CreateStudent(student);
            ViewBag.AffectedRowCount = affectedRow;
            return View();
        }

        public async Task<IActionResult> GetStudents(int id)
        {
            List<StudentViewModel> models = new List<StudentViewModel>();

            var ads = await _advertisimentService.GetById(id);
            var students = await _studentService.GetStudentByAdvertisiment(ads);

            foreach (var item in students)
            {
                models.Add(new StudentViewModel
                { 
                    AdvertisimentId = ads.AdvertisimentId,
                    StudentId = item.StudentId,
                    Name = item.Name,
                    Email = item.Email,
                    DateOfGraduation = item.DateOfGraduation,
                    University = item.University,
                    Section = item.Section,
                    Bio = item.Bio,
                    City = item.City,
                    Telephone = item.Telephone,
                    DayOfIntern = item.DayOfIntern
                });
            }

            return View(models);
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _studentService.DeleteStudent(id);
            return RedirectToAction("GetStudents" ,"Student");
        }
    }
}
