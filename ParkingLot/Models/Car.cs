using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingLot.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string CarPlate { get; set; }
        public string Brand { get; set; }
        public string CarModel { get; set; }
        public string Color { get; set; }
        public int ParkingSpotNumber { get; set; }
        public DateTime EnterDate { get; set; }
        public string Hour { get; set; }
    }
}