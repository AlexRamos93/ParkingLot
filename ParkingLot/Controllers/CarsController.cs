using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ParkingLot.Models;

namespace ParkingLot.Controllers
{
    public class CarsController : Controller
    {
        // GET: Carro
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            return PartialView(Context.cars);
        }

        // GET: Carro/Details/5
        public ActionResult Details(int id)
        {
            var car = Context.cars.FirstOrDefault(c => c.ID.Equals(id));
            return PartialView(car);
        }

        // GET: Carro/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Carro/Create
        [HttpPost]
        public ActionResult Create(CarInput input)
        {
            if (!ModelState.IsValid)
            {
                return View(input);
            }
            Context.cars.Add(new Car { ID = input.ID, Color = input.Color, Brand = input.Brand, CarModel = input.CarModel, ParkingSpotNumber = input.ParkingSpotNumber, CarPlate = input.CarPlate, EnterDate = DateTime.Now });
            return RedirectToAction("List");
        }

        // GET: Carro/Edit/5
        public ActionResult Edit(int id)
        {
            var car = Context.cars.FirstOrDefault(c => c.ID.Equals(id));
            return PartialView(car);
        }

        // POST: Carro/Edit/5
        [HttpPost]
        public ActionResult Edit(Car car)
        {
            try
            {
                var NewCar = Context.cars.FirstOrDefault(c => c.ID.Equals(car.ID));

                NewCar.CarModel = car.CarModel;
                NewCar.Color = car.Color;
                NewCar.Brand = car.Brand;
                NewCar.ParkingSpotNumber = car.ParkingSpotNumber;
                NewCar.CarPlate = car.CarPlate;

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Carro/Delete/5
        public ActionResult Delete(int id)
        {
            var car = Context.cars.FirstOrDefault(c => c.ID.Equals(id));
            return PartialView(car);
        }

        // POST: Carro/Delete/5
        [HttpPost]
        public ActionResult Delete(Car car)
        {
            try
            {

                Context.cars.Remove(Context.cars.FirstOrDefault(c => c.ID.Equals(car.ID)));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public class CarInput
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
}