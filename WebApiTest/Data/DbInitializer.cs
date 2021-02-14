using System.Collections.Generic;
using System.Linq;
using WebApiTest.Models;

namespace WebApiTest.Data
{
    public class DbInitializer
    {

        public static void Initialize(UserContext context)
        {
            context.Database.EnsureCreated();



            var regions = new List<Region>
            {
                new Region
                {
                    Id = 1,
                    Name = "Abruzzo"
                },

                new Region
                {
                    Id = 2,
                    Name = "Basilicata"
                },

                new Region
                {
                    Id = 3,
                    Name = "Calabria"
                },

                new Region
                {
                    Id = 4,
                    Name = "Bla bla bla ..."
                },

                //[...]

                new Region
                {
                    Id = 9,
                    Name = "Veneto"
                }
            };

            foreach (var region in regions)
            {
                context.Regions.Add(region);
            }
            context.SaveChanges();



            var users = new List<User>
            {
                new User
                {
                    Id = 1,
                    FirstName = "Ivan",
                    LastName = "Zanolla",
                    Address = "Via Fossal, 3",
                    Region = regions.SingleOrDefault(r => r.Name.Contains("Veneto"))

                },
            };

            foreach (var user in users)
            {
                context.Users.Add(user);
            }
            context.SaveChanges();

        }
    }

}

