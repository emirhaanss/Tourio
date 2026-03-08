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
        public async Task<IViewComponentResult> InvokeAsync(int page = 1)
        {
            // Sayfa numarası 1'den küçükse 1'e sabitle 
            if (page < 1) page = 1;

            int pageSize = 6;
            var allTours = await _tourService.GetAllToursAsync() ?? new List<Tourio.Dtos.TourDtos.ResultTourDto>();

            var totalCount = allTours.Count();

            // LINQ ile sayfalama
            var pagedTours = allTours
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            // View tarafına gönderilecek veriler
            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            ViewBag.TotalCount = totalCount; // Toplam tur sayısı

            return View(pagedTours);
        }
    }
}
