using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestarauntReservation.Models {
    public class User {
        public int Id { get; set; }
        public String Username { get; set; }
        public String FirstName { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
    }
}
