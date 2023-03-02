using HotelRoomBookingApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace HotelRoomBookingApi.Repositories
{
    public class BookingRepo : IBookingRepo
    {
        MyDbContext context;
        public BookingRepo(MyDbContext bookingContext)
        {
            context = bookingContext;
        }
        public string AddNewBooking(Booking booking)
        {
            int count = context.Bookings.Count();

            context.Bookings.Add(booking);
            context.SaveChanges();
            int newCount=context.Bookings.Count();
            if(newCount > count)
            {

                return "record inserted successfully";
            }
            else
            {
                return "oops something went wrong";
            }
        }

        public string DeletBooking(int id)
        {
            Booking booking = context.Bookings.Find(id);
            if (booking != null)
            {
                context.Bookings.Remove(booking);
                context.SaveChanges();
                return "Booking is deleted";
            }
            else
            {
                return "booking is not available";
            }
        }
        public List<Booking> GetAllBookings()
        {
            return context.Bookings.ToList();
        }
        public string UpdateBooking(Booking newbooking)
        {
            Booking booking = context.Bookings.FirstOrDefault(d =>
            d.BookingId == newbooking.BookingId);
            if (booking != null)
            {
                booking.BookingId = newbooking.BookingId;
                booking.HotelId = newbooking.HotelId;
                booking.RoomId = newbooking.RoomId;
                booking.UserId = newbooking.UserId;
                booking.CheckInDate = newbooking.CheckInDate;
                booking.CheckOutDate = newbooking.CheckOutDate;
                booking.NoOfPeople = newbooking.NoOfPeople;
                context.SaveChanges();
                return "booking details are updated";

            }
            else
            {
                return "Booking details are not avaialable";
            }
        }
        public Booking GetBookingById(int id)
        {
            Booking booking = context.Bookings.Find(id);
            return booking;

        }

    }
}
