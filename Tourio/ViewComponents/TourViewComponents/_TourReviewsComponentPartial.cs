using Microsoft.AspNetCore.Mvc;

namespace Tourio.ViewComponents.TourViewComponents
{
    public class _TourReviewsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
