using Microsoft.AspNetCore.Mvc;
using Tourio.Dtos.TourDtos;

namespace Tourio.ViewComponents.TourViewComponents
{
    public class _TourPlanComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke(List<GetTourDayPlanDto> days)
        {
            
            return View(days);
        }
    }
}