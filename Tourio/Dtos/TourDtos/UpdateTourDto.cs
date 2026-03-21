namespace Tourio.Dtos.TourDtos
{
    public class UpdateTourDto
    {
        public string TourID { get; set; }
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
        public List<UpdateTourDayPlanDto> Days { get; set; } = new List<UpdateTourDayPlanDto>();
        public List<UpdateTourFeatureDto> TourFeatures { get; set; } = new List<UpdateTourFeatureDto>();
    }

    public class UpdateTourDayPlanDto
    {
        public int DayNumber { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
    public class UpdateTourFeatureDto
    {
        public string FeatureName { get; set; }
    }
}