using Tourio.Dtos.TourBookingInformation;
using Tourio.Dtos.TourReservationInformationDtos;

namespace Tourio.Services.TourBookingServices
{
    public interface ITourBookingService
    {
        Task<List<ResultTourBookingInformationDto>> GetAllTourBookingsAsync();
        Task<GetTourBookingInformationByIdDto> GetTourBookingByIdAsync(string id);
        Task CreateTourBookingAsync(CreateTourBookingInformationDto createTourBookingInformationDto);
        Task DeleteTourBookingAsync(string id);
   
    }
}
