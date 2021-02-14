using Microsoft.EntityFrameworkCore;

namespace WebApiTest.Models
{

    public class UserContext : DbContext
    {

        public UserContext(DbContextOptions<UserContext> options)
           : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Region> Regions { get; set; }

    }
}
