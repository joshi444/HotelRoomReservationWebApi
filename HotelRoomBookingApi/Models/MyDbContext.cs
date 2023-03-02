using Microsoft.EntityFrameworkCore;

namespace HotelRoomBookingApi.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
       
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Booking> Bookings{ get; set; }

    }
}
