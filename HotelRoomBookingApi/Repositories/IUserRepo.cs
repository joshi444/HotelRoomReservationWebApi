using HotelRoomBookingApi.Models;
using System.Collections.Generic;

namespace HotelRoomBookingApi.Repositories
{
    public interface IUserRepo
    {
        List<User> GetAllUsers();
        string AddNewUser(User user);
        string  UpdateUser(User user);

        string  DeleteUser(int id);
        User GetUserById(int id);
    }

}
