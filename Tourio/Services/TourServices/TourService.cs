using AutoMapper;
using MongoDB.Driver;
using Tourio.Dtos.TourDtos;
using Tourio.Entities;
using Tourio.Settings;

namespace Tourio.Services.TourServices
{
    public class TourService : ITourService
    {
        private readonly IMapper _mapper;
        private readonly IMongoCollection<Tour> _toursCollection;

        public TourService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _toursCollection = database.GetCollection<Tour>(_databaseSettings.TourCollectionName);
            _mapper = mapper;
        }

        async Task ITourService.CreateTourAsync(CreateTourDto createTourDto)
        {
            var value = _mapper.Map<Tour>(createTourDto);
            await _toursCollection.InsertOneAsync(value);
        }

        async Task ITourService.DeleteTourAsync(string id)
        {
            await _toursCollection.DeleteOneAsync(x => x.TourId == id);
        }

        async Task<List<ResultTourDto>> ITourService.GetAllToursAsync()
        {
            var values = await _toursCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultTourDto>>(values);
        }

        async Task<GetTourByIdDto> ITourService.GetTourByIdAsync(string id)
        {
            var value= await _toursCollection.Find(x=>x.TourId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetTourByIdDto>(value);
        }

        async Task ITourService.UpdateTourAsync(UpdateTourDto updateTourDto)
        {
           var value=_mapper.Map<Tour>(updateTourDto);
            await _toursCollection.ReplaceOneAsync(x=> x.TourId == updateTourDto.TourID, value);
        }
    }
}
