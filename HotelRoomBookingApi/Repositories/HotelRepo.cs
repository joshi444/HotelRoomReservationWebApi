using HotelRoomBookingApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace HotelRoomBookingApi.Repositories
{
    public class HotelRepo : IHotelRepo
    {
        MyDbContext context;
        public HotelRepo(MyDbContext hotelContext)
        {
            context = hotelContext;
        }
        public string  AddNewHotel(Hotel hotel)
        {
            int count = context.Hotels.Count();
            context.Hotels.Add(hotel);
            context.SaveChanges();
            int newcount = context.Hotels.Count();
            if(newcount>count)
            {
                return "record inserted successfully";
            }
            else
            {
                return "oops something went wrong while inserting";
            }
        }

        public string  DeleteHotel(int id)
        {
            Hotel hotel = context.Hotels.Find(id);
            if (hotel != null)
            {
                context.Hotels.Remove(hotel);
                context.SaveChanges();
                return "hotel removed from database";
            }
            else
            {
                return "hotel is not available";
            }
        
        }
        public List<Hotel> GetAllHotels()
        {
            return context.Hotels.ToList();
        }
        public string  UpdateHotel(Hotel newhotel)
        {
            Hotel hotel = context.Hotels.FirstOrDefault(d =>
            d.HotelId == newhotel.HotelId);
            if (hotel != null)
            {
                hotel.HotelId = newhotel.HotelId;
                hotel.HotelName = newhotel.HotelName;
                hotel.Location = newhotel.Location;
                hotel.AvailableRooms = newhotel.AvailableRooms;
                context.SaveChanges();
                return "hotel details updated successful";

            }
            else
            {
                return "hotel details not updated";
            }
        
        }
        public Hotel GetHotelById(int id)
        {
            Hotel hotel = context.Hotels.Find(id);
            return hotel;
        }
    }
}
