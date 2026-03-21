namespace Tourio.Dtos.TourDtos
{
    public class GetTourByIdDto
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
        public List<GetTourFeatureDto> TourFeatures{ get; set; }
        public List<GetTourDayPlanDto> Days { get; set; }
        
    }

    public class GetTourDayPlanDto
    {
        public int DayNumber { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
    public class GetTourFeatureDto
    {
        public string FeatureName { get; set; }
    }
}