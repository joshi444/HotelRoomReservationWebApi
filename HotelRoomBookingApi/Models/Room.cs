using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelRoomBookingApi.Models
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        [Required]
        public int HotelId { get; set; }
        [Required]
        public int RoomNumber { get; set; }
        [Required]
        public string RoomType { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Availability { get; set; }

        public Hotel Hotel { get; set; }
        public List<Booking> Bookings { get; set; }

    }
}
