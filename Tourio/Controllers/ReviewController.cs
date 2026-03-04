using Microsoft.AspNetCore.Mvc;
using Tourio.Dtos.ReviewDtos;
using Tourio.Services.ReviewServices;

namespace Tourio.Controllers
{
    public class ReviewController : Controller
    {
        private readonly IReviewService _reviewService;

        public ReviewController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }
        [HttpGet]
        public IActionResult CreateReview()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateReview(CreateReviewDto createReview)
        {
            createReview.Status = false;
            await _reviewService.CreateReviewAsync(createReview);
            return RedirectToAction("ReviewList");
        }
    }
}
