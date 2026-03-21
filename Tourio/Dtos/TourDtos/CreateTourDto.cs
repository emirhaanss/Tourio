using Tourio.Entities;

namespace Tourio.Dtos.TourDtos
{
    public class CreateTourDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string CoverImageUrl { get; set; }
        public string Badge { get; set; }
        public int DayCount { get; set; }
        public int Capacity { get; set; }
        public decimal Price { get; set; }
        public bool IsStatus { get; set; }
        public string Location { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ReturnTime { get; set; }
        public List<CreateTourFeatureDto> TourFeatures { get; set; } = new List<CreateTourFeatureDto>();

        public List<CreateTourDayPlanDto> Days { get; set; } = new List<CreateTourDayPlanDto>();
    }


    public class CreateTourDayPlanDto
    {
        public int DayNumber { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
    public class CreateTourFeatureDto
    {
        public string FeatureName { get; set; }
    }
}