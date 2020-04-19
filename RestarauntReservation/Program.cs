using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RestarauntReservation.Models;

namespace RestarauntReservation {
    public class Program {
        private static ReservationDbContext _database = new ReservationDbContext();
        public static void Main(string[] args) {
            PopulateDataBase();





            ///ALL CODE ABOVE THIS LINE
            CreateHostBuilder(args).Build().Run();
        }


        public static void PopulateDataBase() {
            Location newLoc = new Location{Country = "Canada", Address = "3456 Main Street", PostalCode = "JHF7S8", City = "Toronto", Lat = "43",Long = "42"};
            Restaurant newRest = new Restaurant { Name = "Boston Pizza", FoodType = FoodType.Casual, Location = newLoc };

            _database.Restaurants.Add(newRest);
            _database.Locations.Add(newLoc);
            _database.SaveChanges();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => {
                    webBuilder.UseStartup<Startup>();
                });
    }



    
}
