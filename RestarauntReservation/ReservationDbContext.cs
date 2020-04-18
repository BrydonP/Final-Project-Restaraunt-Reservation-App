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


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(
                @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ReservationsDatabase;Data Source=boba.fast.sheridanc.on.ca:1521/aces;uid=s7_parsobry; password=991546642");
               // < add name = "dbnameConnectionString" connectionString = "server=.;database=dbname;uid=user;password=pass;Initial Catalog=dbname;Integrated Security= false" providerName = "System.Data.SqlClient" />
        }
    }
}
