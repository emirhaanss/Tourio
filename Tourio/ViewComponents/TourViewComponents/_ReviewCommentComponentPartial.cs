using Microsoft.AspNetCore.Mvc;
using Tourio.Dtos.ReviewDtos;

namespace Tourio.ViewComponents.TourViewComponents
{
    public class _ReviewCommentComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke(string tourId)
        {
            // Model oluştur ve TourId’yi ata
            var model = new CreateReviewDto
            {
                TourId = tourId
            };

            return View(model); // View’e doğru tip gönderiliyor
        }
    }
}