using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelRoomBookingApi.Models
{
    public class Hotel
    {
        [Key]
        public int HotelId { get; set; }
        [Required]
        public string HotelName { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public int AvailableRooms { get; set; }

        public List<Room> Rooms { get; set; }
    }
}
