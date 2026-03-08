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
        
        public IActionResult TourList()
        {
            return View();
        }
        public async Task<IActionResult> TourDetail(string id)
        {
            var tour = await _tourService.GetTourByIdAsync(id);
            return View(tour);
        }
    }
}
