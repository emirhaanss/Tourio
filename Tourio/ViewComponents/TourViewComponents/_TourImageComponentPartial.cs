using Microsoft.AspNetCore.Mvc;

namespace Tourio.ViewComponents.TourViewComponents
{
    public class _TourImageComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
