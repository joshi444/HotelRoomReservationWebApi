using HotelRoomBookingApi.Models;
using System.Collections.Generic;

namespace HotelRoomBookingApi.Repositories
{
    public interface IBookingRepo
    {
        List<Booking> GetAllBookings();
       string AddNewBooking(Booking booking);
        string UpdateBooking(Booking booking);
        string DeletBooking(int id);
        Booking GetBookingById(int id);
    }
}
