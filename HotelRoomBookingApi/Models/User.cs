using System.Collections.Generic;
using  System.ComponentModel.DataAnnotations;
namespace HotelRoomBookingApi.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required(ErrorMessage = "enter email id")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public long ContactNo { get; set; }

        public List<Booking> Bookings { get; set; }


    }
}
