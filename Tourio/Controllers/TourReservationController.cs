using Microsoft.AspNetCore.Mvc;
using Tourio.Dtos.TourDtos;
using Tourio.Dtos.TourReservationInformationDtos;
using Tourio.Services.TourBookingServices;
using Tourio.Services.TourServices;

namespace Tourio.Controllers
{
    public class TourReservationController : Controller
    {
        private readonly ITourBookingService _tourBookingService;
        private readonly ITourService _tourService;

        public TourReservationController(ITourBookingService tourBookingService, ITourService tourService)
        {
            _tourBookingService = tourBookingService;
            _tourService = tourService;
        }

        [HttpGet]
        public async Task<IActionResult> CreateTourReservationAsync()
        {
            var Tours = await _tourService.GetAllToursAsync();
            ViewBag.Tours = Tours;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateTourReservationAsync(CreateTourBookingInformationDto createTourBookingDto)
        {

            createTourBookingDto.CreatedDate = DateTime.Now.Date;
            createTourBookingDto.Status = "Beklemede";
            var tour = await _tourService.GetTourByIdAsync(createTourBookingDto.TourId);
            createTourBookingDto.TotalPrice = tour.Price * createTourBookingDto.PersonCount;
            await _tourBookingService.CreateTourBookingAsync(createTourBookingDto);
            return RedirectToAction("BookingConfirmation");
        }
    }
}
