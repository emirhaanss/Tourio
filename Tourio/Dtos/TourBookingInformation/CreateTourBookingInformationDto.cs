namespace Tourio.Dtos.TourReservationInformationDtos
{
    public class CreateTourBookingInformationDto
    {
        public string TourId { get; set; }
        public string NameSurname { get; set; }
        public DateTime ReservationDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int PersonCount { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Status { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
