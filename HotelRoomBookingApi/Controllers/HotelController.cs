using HotelRoomBookingApi.Models;
using HotelRoomBookingApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HotelRoomBookingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelRepo Repositories = null;
        public HotelController(IHotelRepo repo)
        {
            Repositories = repo;
        }
        [HttpGet]
        public ActionResult<List<Hotel>> Get()
        {
            List<Hotel> hotels = Repositories.GetAllHotels();
            if (hotels.Count > 0)
            {
                return hotels;
            }
            else
            {
                return NotFound();
            }
        }
        [Route("{id:int}")]
        [HttpGet]
        public ActionResult<Hotel> Get(int id)
        {
            Hotel hotel = Repositories.GetHotelById(id);
            if (hotel != null)
            {
                return hotel;
            }
            else
            {
                return NotFound();
            }
        }
       
        [HttpPost]
        public string Post(Hotel hotel)
        {
            string Response = Repositories.AddNewHotel(hotel);
            return Response;
        }
        [HttpPut]
        public string Put(Hotel hotel)
        {
            string Response = Repositories.UpdateHotel(hotel);
            return Response;
        }

        [Route("{id:int}")]
        [HttpDelete]
        public string Delete(int id)
        {
            string Response = Repositories.DeleteHotel(id);
            return Response;
        }

    }
}
