using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Ste.Data.Entities;
using Ste.Service.Abstract;
using Ste.WebUI.Models;

namespace Ste.WebUI.Controllers
{
    public class AdvertisimentController : Controller
    {
        private readonly IAdvertisimentService _advertisimentService;

        private readonly UserManager<CompanyUser> _userManager;

        private readonly SignInManager<CompanyUser> _signInManager;

        public AdvertisimentController(IAdvertisimentService advertisimentService, UserManager<CompanyUser> userManager, SignInManager<CompanyUser> signInManager)
        {
            _advertisimentService = advertisimentService;

            _userManager = userManager;

            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();

        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(AdvertisimentAddViewModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var userId = _userManager.GetUserId(User);
            Advertisiment advertisiment = new Advertisiment()
            {
                CompanyId = userId,
                AdvertisimentId = model.AdvertisimentId,
                JobTitle = model.JobTitle,
                City = model.City,
                JobDesc = model.JobDesc,
                NumberOfStudents = model.NumberOfStudents,
                CreateDate = DateTime.Now
            };
            var affedtedRowCount = await _advertisimentService.CreateAdvertisiment(advertisiment);
            ViewBag.AffectedRowCount = affedtedRowCount;
            return View(model);
        }

        public async Task<IActionResult> Edit(int id)
        {

            var entity = await _advertisimentService.GetById(id);
            var model = new AdvertisimentUpdateViewModel()
            {
                CompanyId = _userManager.GetUserId(User),
                AdvertisimentId = entity.AdvertisimentId,
                JobTitle = entity.JobTitle,
                City = entity.City,
                JobDesc = entity.JobDesc,
                NumberOfStudents = entity.NumberOfStudents,

            };

            return View(model);
        }

        //will refactor
        [HttpPost]
        public async Task<IActionResult> Edit( AdvertisimentUpdateViewModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            Advertisiment advertisiment = new Advertisiment()
            {
               CompanyId = _userManager.GetUserId(User),
               //AdvertisimentId = model.AdvertisimentId,
                JobTitle = model.JobTitle,
                City = model.City,
                JobDesc = model.JobDesc,
                NumberOfStudents = model.NumberOfStudents,
                CreateDate = DateTime.Now
            };

                //await _advertisimentService.DeleteAdvertisiment(model.AdvertisimentId);
   
                //await _advertisimentService.UpdateAdvertisiment(advertisiment);

                var affedtedRowCount = await _advertisimentService.UpdateAdvertisiment(advertisiment);
                ViewBag.AffectedRowCount = affedtedRowCount;
            
            return View(model);


        }


        public async Task<IActionResult> MyAdvertisiments()
        {
            if (!_signInManager.IsSignedIn(User))
            {
                return RedirectToAction("Create", "Advertisiment");
            }

            List<AdvertisimentUpdateViewModel> models = new List<AdvertisimentUpdateViewModel>();
            var user = await _userManager.GetUserAsync(User);
            var advertisiments = await _advertisimentService.GetAdvertisimentsOffUser(user);
            foreach (var a in advertisiments)
            {
                models.Add(new AdvertisimentUpdateViewModel
                {
                    CompanyId = _userManager.GetUserId(User),
                    AdvertisimentId = a.AdvertisimentId,
                    JobTitle = a.JobTitle,
                    City = a.City,
                    JobDesc = a.JobDesc,
                    NumberOfStudents = a.NumberOfStudents,

                });
            }

            return View(models);

        }

        public async Task<IActionResult> Delete(int id)
        {
            await _advertisimentService.DeleteAdvertisiment(id);
            return RedirectToAction("MyAdvertisiments", "Advertisiment");
        }

        //for detail
        public async Task<IActionResult> Get(int id)
        {
            var entity = await _advertisimentService.GetById(id);

            var model = new AdvertisimentListViewModel()
            {
                CompanyId = entity.CompanyId,
                AdvertisimentId = entity.AdvertisimentId,
                CompanyName = entity.CompanyUser.CompanyName,
                JobTitle = entity.JobTitle,
                City = entity.City,
                JobDesc = entity.JobDesc,
                NumberOfStudents = entity.NumberOfStudents,
                Adress = entity.CompanyUser.AdressDetail,
                Email = entity.CompanyUser.Email
            };

            return View(model);
        }

    }
}
