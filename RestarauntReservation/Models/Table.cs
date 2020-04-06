using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestarauntReservation.Models {
    public class Table {
        public Boolean IsReservable { get; set; }
        public int Seats { get; set; }
        public SeatType SeatType { get; set; }
    }
}
