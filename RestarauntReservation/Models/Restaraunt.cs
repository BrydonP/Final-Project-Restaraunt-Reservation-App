using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace RestarauntReservation.Models {
    public class Restaraunt {
        private List<Table> _tables;
        private List<Reservation> _reservations;

        public string  Name { get; set; }
        public Location Location { get; set; }
        public FoodType FoodType { get; set; }
        public List<Table> Tables { get; set; }
        public List<Reservation> Reservations { get; set; }


        public Restaraunt() {
            _tables = new List<Table>();
            _reservations = new List<Reservation>();
        }

        public Boolean CheckAvailability(int tableNum) {
            return _tables[tableNum].IsReservable ==  true;
        }
    }
}
