using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Tourio.Dtos.ReviewDtos;
using Tourio.Services.ReviewServices;

namespace Tourio.ViewComponents.TourViewComponents
{
    public class _TourReviewsComponentPartial : ViewComponent
    {
        private readonly IReviewService _reviewService;

        public _TourReviewsComponentPartial(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            List<ResultReviewByTourIdDto> reviews = await _reviewService.GetReviewsByTourId(id);
            return View(reviews);
        }
    }
}
