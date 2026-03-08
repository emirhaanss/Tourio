using Microsoft.AspNetCore.Mvc;

namespace Tourio.ViewComponents.TourViewComponents
{
    public class _TourLocationComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
