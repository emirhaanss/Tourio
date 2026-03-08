using Microsoft.AspNetCore.Mvc;

namespace Tourio.ViewComponents.TourViewComponents
{
    public class _TourDetailComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
