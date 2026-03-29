using AutoMapper;
using MongoDB.Driver;
using Tourio.Dtos.TourBookingInformation;
using Tourio.Dtos.TourReservationInformationDtos;
using Tourio.Entities;
using Tourio.Settings;

namespace Tourio.Services.TourBookingServices
{
    public class TourBookingService : ITourBookingService
    {
        private readonly IMapper _mapper;
        private readonly IMongoCollection<TourBookingInformation> _tourBookingCollection;
        public TourBookingService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            _mapper = mapper;
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _tourBookingCollection = database.GetCollection<TourBookingInformation>(_databaseSettings.TourBookingInformationCollectionName);

        }

        public async Task CreateTourBookingAsync(CreateTourBookingInformationDto createTourBookingInformationDto)
        {
            var value = _mapper.Map<TourBookingInformation>(createTourBookingInformationDto);
            await _tourBookingCollection.InsertOneAsync(value);
        }

        public async Task DeleteTourBookingAsync(string id)
        {
            await _tourBookingCollection.DeleteOneAsync(x => x.ReservationID == id);
        }

        public async Task<List<ResultTourBookingInformationDto>> GetAllTourBookingsAsync()
        {
            var values = await _tourBookingCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultTourBookingInformationDto>>(values);

        }

        public async Task<GetTourBookingInformationByIdDto> GetTourBookingByIdAsync(string id)
        {
            var value = _tourBookingCollection.Find(x => x.ReservationID == id).FirstOrDefaultAsync();
            return _mapper.Map<GetTourBookingInformationByIdDto>(value);
        }

       
    }
}
