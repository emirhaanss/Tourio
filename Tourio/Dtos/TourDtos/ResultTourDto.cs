namespace Tourio.Dtos.TourDtos
{
    public class ResultTourDto
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
        public List<ResultTourDayPlanDto> Days { get; set; }
        public List<ResultTourFeatureDto> TourFeatures { get; set; }
    }

    public class ResultTourDayPlanDto
    {
        public int DayNumber { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
    public class ResultTourFeatureDto
    {
        public string FeatureName { get; set; }

    }
}
