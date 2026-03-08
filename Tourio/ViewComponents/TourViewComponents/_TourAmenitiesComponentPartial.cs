using Microsoft.AspNetCore.Mvc;

namespace Tourio.ViewComponents.TourViewComponents
{
    public class _TourAmenitiesComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
