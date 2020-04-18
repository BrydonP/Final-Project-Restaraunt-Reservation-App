using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestarauntReservation.Models {
    public class Reservation {
        public int Id { get; set; }
        public Restaurant Restaurant { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Notes { get; set; }
        public int TableNumber { get; set; }
        public Table TableType { get; set; }

        public void MakeReservation(Restaurant rest) {
            if (rest.CheckAvailability(TableNumber)) {//Table Available
                // TODO Link these to View Text Boxes
                //rest.Reservations[TableNumber].StartTime = TextBox.text;
                //rest.Reservations[TableNumber].EndTime = TextBox.text;
                //rest.Reservations[TableNumber].Notes = TextBox.text;
            }
        }


        public void CancelReservation() {

        }
    }
}
