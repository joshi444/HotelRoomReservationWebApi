using HotelRoomBookingApi.Models;
using HotelRoomBookingApi.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HotelRoomBookingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingRepo Repositories = null;
        public BookingController(IBookingRepo repo)
        {
            Repositories = repo;
        }
        [HttpGet]
        public ActionResult<List<Booking>> Get()
        {
            List<Booking> booking = Repositories.GetAllBookings();
            if (booking.Count > 0)
            {
                return booking;
            }
            else
            {
                return NotFound();
            }
        }
        [Route("{id:int}")]
        [HttpGet]
        public ActionResult<Booking> Get(int id)
        {
            Booking booking = Repositories.GetBookingById(id);
            if (booking != null)
            {
                return booking;
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public string Post(Booking booking)
        {
            string Response = Repositories.AddNewBooking(booking);
            return Response;
        }
        [HttpPut]
        public string Put(Booking booking)
        {
            string Response = Repositories.UpdateBooking(booking);
            return Response;
        }

        [Route("{id:int}")]
        [HttpDelete]
        public string Delete(int id)
        {
            string Response = Repositories.DeletBooking(id);
            return Response;
        }
    }
}
