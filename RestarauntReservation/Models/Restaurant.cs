using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace RestarauntReservation.Models {
    public class Restaurant {
        private List<Table> _tables;
        private List<Reservation> _reservations;

        public int Id { get; set; }
        public string  Name { get; set; }
        public Location Location { get; set; }
        public FoodType FoodType { get; set; }
        public List<Table> Tables { get; set; }
        public List<Table> AvailableTables { get; set; }
        public List<Reservation> Reservations { get; set; }


        public Restaurant() {
            _tables = new List<Table>();
            _reservations = new List<Reservation>();
        }

        public Boolean CheckAvailability(int tableNum) {
            return true;//TODO Write this function delete placeholder
        }
    }
}
