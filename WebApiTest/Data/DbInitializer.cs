using System.Collections.Generic;
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
                }
            };

            foreach (var region in regions)
            {
                context.Regions.Add(region);
            }
            context.SaveChanges();


        }
    }

}

