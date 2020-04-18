using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestarauntReservation.Models;

namespace RestarauntReservation {
    class ReservationDbContext : DbContext{
        //TODO Put in Tables

        public DbSet<User> Users { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Table> Tables { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(
                @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ReservationsDatabase;Data Source=WINDOWS-LAPTOP\SQLEXPRESS");
        }
    }
}
