using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingLot.Models
{
    public class Context
    {
        public static IList<Car> cars = new List<Car>
        {
            new Car
            {
                ID = 001, Brand = "Ford", Color = "Blue", CarModel = "Mustang", ParkingSpotNumber = 001, CarPlate = "111-AAA", EnterDate = new DateTime(2018, 1, 1, 18, 50, 00)
            },
            new Car
            {
                ID = 002, Brand = "Honda", Color = "Silver", CarModel = "Civic", ParkingSpotNumber = 002, CarPlate = "222-BBB", EnterDate = new DateTime(2018, 1, 1, 19, 50, 00)
            },
            new Car
            {
                ID = 003, Brand = "Volkswagen", Color = "Red", CarModel = "Jetta", ParkingSpotNumber = 003, CarPlate = "333-CCC", EnterDate = new DateTime(2018, 1, 1, 22, 50, 00)
            },
        };
    }
}