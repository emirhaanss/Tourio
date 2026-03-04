using Tourio.Dtos.ReviewDtos;

namespace Tourio.Services.ReviewServices
{
    public interface IReviewService
    {
        Task<List<ResultReviewDto>> GetAllReviewsAsync();
        Task CreateReviewAsync(CreateReviewDto createReviewDto);
        Task UpdateReviewAsync(UpdateReviewDto updateReviewDto);
        Task DeleteReviewAsync(string id);
        Task<GetReviewByIdDto> GetReviewByIdAsync(string id);
    }
}
