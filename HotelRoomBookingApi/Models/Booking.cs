using System;
using System.ComponentModel.DataAnnotations;

namespace HotelRoomBookingApi.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int RoomId { get; set; }
        [Required]
        public int HotelId { get; set; }
        [Required]
        public DateTime CheckInDate { get; set; }
        [Required]
        public DateTime CheckOutDate { get; set; }
        [Required]
        public int NoOfPeople { get; set; }

        public Room Room { get; set; }
        public User User { get; set; }
    }
}
