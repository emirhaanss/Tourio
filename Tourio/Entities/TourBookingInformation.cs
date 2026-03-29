using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Tourio.Entities
{
    public class TourBookingInformation
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ReservationID { get; set; }
        public string TourId { get; set; }
        public string NameSurname { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int PersonCount { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }


    }
}
