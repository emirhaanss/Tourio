using Microsoft.AspNetCore.Mvc;
using Tourio.Dtos.TourDtos;
using Tourio.Services.TourServices;

namespace Tourio.Controllers
{
    public class TourController : Controller
    {
        public readonly ITourService _tourService;

        public TourController(ITourService tourService)
        {
            _tourService = tourService;
        }
        [HttpGet]
        public IActionResult CreateTour()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateTour(CreateTourDto createTourDto)
        {
            await _tourService.CreateTourAsync(createTourDto);
            return RedirectToAction("TourList");
        }
        public IActionResult TourList()
        {
            return View();
        }
    }
}
