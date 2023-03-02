using HotelRoomBookingApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace HotelRoomBookingApi.Repositories
{
    public class UserRepo : IUserRepo
    {
        MyDbContext context;
        public UserRepo(MyDbContext userContext)
        {
            context = userContext;
        }
        public string  AddNewUser(User user)
        {
            int count = context.Users.Count();

            context.Users.Add(user);
            context.SaveChanges();
            int newcount = context.Users.Count();
            if(newcount> count)
            {
                return "record inserted successfully";
            }
            else
            {
                return "oops something went wrong";
            }


        }

        public string  DeleteUser(int id)
        {
            User user = context.Users.Find(id);
            if (user != null)
            {
                context.Users.Remove(user);
                context.SaveChanges();
                return " user removed deleted successful";
            }
            else
            {
                return "user not avilable";
            }
        }
        public List<User> GetAllUsers()
        {
            return context.Users.ToList();
        }
        public string  UpdateUser(User newuser)
        {
            User user = context.Users.FirstOrDefault(d =>
            d.UserId == newuser.UserId);
            if (user != null)
            {
                user.UserId = newuser.UserId;
                user.UserName = newuser.UserName;
                user.Email = newuser.Email;
                user.Password = newuser.Password;
                user.ContactNo = newuser.ContactNo;

                context.SaveChanges();
                return "user details updated successfully";
            }
            else
            {
                return "not updated";
            }
        }
        public User GetUserById(int id)
        {
            User user = context.Users.Find(id);
            return user;
        }

    }
}
