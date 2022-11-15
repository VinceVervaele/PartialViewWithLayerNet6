using Microsoft.AspNetCore.Mvc;
using PartialView.Models;
using PartialView.Services;
using PartialViewWithLayerNet6.ViewModels;

namespace PartialViewWithLayerNet6.Controllers
{
    public class PersonController : Controller
    {
        public AdultService AdultService { get; }
        public PersonController()
        {
            AdultService = new AdultService();
        }

        public IActionResult Index(JobType type)
        {
            var lstAdults = AdultService.GetAll(type);
            List<AdultVM> adultVMs = new List<AdultVM>();

            foreach (var adult in lstAdults)
            {
                var adultVM = new AdultVM();
                //later we use an automapper
                adultVM.Naam = adult.Naam;
                adultVM.Voornaam = adult.Voornaam;
                adultVM.EnrollDate = adult.EnrollDate;
                adultVM.ImagePath = adult.ImagePath;
                adultVMs.Add(adultVM);
            }

            ViewBag.Type = type == JobType.Docent ? "Docent" : "Student";

            return View(adultVMs);
        }

        
    }
}
