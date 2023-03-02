using HotelRoomBookingApi.Models;
using System.Collections.Generic;

namespace HotelRoomBookingApi.Repositories
{
    public interface IHotelRepo
    {
        List<Hotel> GetAllHotels();
       string  AddNewHotel(Hotel hotel);
        string  UpdateHotel(Hotel hotel);

       string  DeleteHotel(int id);
        Hotel GetHotelById(int id);
    }
}
