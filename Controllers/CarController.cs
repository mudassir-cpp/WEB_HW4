using HW4.Models;
using Microsoft.AspNetCore.Mvc;

namespace HW4.Controllers
{
    public class CarController : Controller
    {
        static private List<Car> _availableCars=new List<Car>([
            new Car(1,"Alto",3000),
            new Car(2,"Corolla",6000),
            new Car(3,"Civic",8000)
            ]);
        static private List<Car> _bookedCars = new List<Car>();
        public IActionResult Index()
        {
            return View(_availableCars);
        }

        [HttpPost]
        public IActionResult Book(int carId)
        {
            Car? cr = _availableCars.FirstOrDefault((car) => car.Id == carId);

            //  as we are making list and then passing so car can't be null 
            if (cr != null){
                _availableCars.Remove(cr);
                _bookedCars.Add(cr);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Booked()
        {
            return View(_bookedCars);
        }
    }
}
