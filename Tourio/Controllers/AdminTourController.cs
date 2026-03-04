using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Tourio.Dtos.TourDtos;
using Tourio.Services.TourServices;

namespace Tourio.Controllers
{
    public class AdminTourController : Controller
    {
        private readonly ITourService _tourService;

        public AdminTourController(ITourService tourService)
        {
            _tourService = tourService;
        }

        public async Task<IActionResult> TourList()
        {
            var tours = await _tourService.GetAllToursAsync();
            return View(tours);
        }
        [HttpGet]
        public IActionResult CreateTour()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateTour(CreateTourDto createTour)
        {

            await _tourService.CreateTourAsync(createTour);
            return RedirectToAction("TourList");

        }
        public async Task<IActionResult> DeleteTour(string id)
        {
            await _tourService.DeleteTourAsync(id);
            return RedirectToAction("TourList");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateTour(string id)
        {
            var values = await _tourService.GetTourByIdAsync(id);
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateTour(UpdateTourDto updateTour)
        {
            await _tourService.UpdateTourAsync(updateTour);
            return RedirectToAction("TourList");
        }
    }
}