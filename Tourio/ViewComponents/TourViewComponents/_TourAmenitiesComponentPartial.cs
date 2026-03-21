using Microsoft.AspNetCore.Mvc;
using Tourio.Dtos.TourDtos;
using Tourio.Services.TourServices;

namespace Tourio.ViewComponents.TourViewComponents
{
    public class _TourAmenitiesComponentPartial : ViewComponent
    {

        public IViewComponentResult Invoke(List<GetTourFeatureDto> tourFeatures)
        {
            return View(tourFeatures);

        }
    }
}
