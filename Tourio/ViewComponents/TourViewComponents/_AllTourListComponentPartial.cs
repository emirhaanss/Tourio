using Microsoft.AspNetCore.Mvc;
using Tourio.Services.TourServices;

namespace Tourio.ViewComponents.TourViewComponents
{
    public class _AllTourListComponentPartial:ViewComponent
    {
        private readonly ITourService _tourService;

        public _AllTourListComponentPartial(ITourService tourService)
        {
            _tourService = tourService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var tours = await _tourService.GetAllToursAsync();
            return View(tours);
        }
    }
}
