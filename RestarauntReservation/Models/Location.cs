using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace RestarauntReservation.Models {
    public class Location {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Lat { get; set; }
        public string Long { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
    }
}
