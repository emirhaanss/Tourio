using Tourio.Dtos.TourDtos;

namespace Tourio.Services.TourServices
{
    public interface ITourService
    {
        Task<List<ResultTourDto>> GetAllToursAsync();
        Task<GetTourByIdDto> GetTourByIdAsync(string id);
        Task CreateTourAsync(CreateTourDto createTourDto);
        Task UpdateTourAsync(UpdateTourDto updateTourDto);
        Task DeleteTourAsync(string id);
    }
}
