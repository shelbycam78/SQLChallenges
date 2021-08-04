using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Challenges.Challenge2
{
    public class Vehicle
    {
        public Guid VehicleId { get; set; }
        public string LicensePlate { get; set; }
        public string VIN { get; set; }
        public decimal Miles { get; set; }
    }
}
