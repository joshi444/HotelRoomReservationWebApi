using HotelRoomBookingApi.Models;
using HotelRoomBookingApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HotelRoomBookingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo Repositories = null;
        public UserController(IUserRepo repo)
        {
            Repositories = repo;
        }
        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            List<User> users = Repositories.GetAllUsers();
            if (users.Count > 0)
            {
                return users;
            }
            else
            {
                return NotFound();
            }
        }
        [Route("{id:int}")]
        [HttpGet]
        public ActionResult<User> Get(int id)
        {
            User user = Repositories.GetUserById(id);
            if (user != null)
            {
                return user;
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public string Post(User user)
        {
            string Response = Repositories.AddNewUser(user);
            return Response;
        }
        [HttpPut]
        public string Put(User user)
        {
            string Response = Repositories.UpdateUser(user);
            return Response;
        }

        [Route("{id:int}")]
        [HttpDelete]
        public string Delete(int id)
        {
            string Response = Repositories.DeleteUser(id);
            return Response;
        }
    }
}
