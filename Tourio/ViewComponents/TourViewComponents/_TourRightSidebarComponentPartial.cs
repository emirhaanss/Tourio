using Microsoft.AspNetCore.Mvc;
using Tourio.Services.TourServices;

namespace Tourio.ViewComponents.TourViewComponents
{
    public class _TourRightSidebarComponentPartial : ViewComponent
    {
        private readonly ITourService _tourService;

        public _TourRightSidebarComponentPartial(ITourService tourService)
        {
            _tourService = tourService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var tours = await _tourService.GetAllToursAsync();
            var lastTwoTours = tours.TakeLast(2).ToList();

            return View(lastTwoTours);
        }
    }
}