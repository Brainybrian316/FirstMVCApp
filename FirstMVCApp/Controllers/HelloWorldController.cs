using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstMVCApp.Models;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs = new List<DogViewModel>();

        public IActionResult Details()
        {
            HotelBooking booking = new HotelBooking();

            booking.Id = 10;
            booking.GuestName = "John Doe";
            booking.StartDate = DateTime.Today;
            booking.EndDate = DateTime.Today.AddDays(3);

            return View(booking);
        }

        public IActionResult Index()
        {
            return View(dogs);
        }

        public IActionResult Hotel()
        {
            return View();

        }
        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Hello()
        {
            DogViewModel doggo = new DogViewModel() { Name = "Shadow", Age = 3 };
            return View(doggo);
        }
    }
}
