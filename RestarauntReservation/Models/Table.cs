using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestarauntReservation.Models {
    public class Table {
        public int Id { get; set; }
        public int Seats { get; set; } //How many Seats
        public SeatType SeatType { get; set; }
    }
}
