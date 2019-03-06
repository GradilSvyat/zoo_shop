using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using zoo_shop.Models;

namespace zoo_shop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            Pet d = new Pet();
            return View("Add", d);
        }
        [HttpPost]
        public IActionResult Add(PetForm petForm)
        {
            return View("Add name", petForm);
        }
        [HttpPost]
        public IActionResult Add_finish(string Name, string Breed, string type)
        {
            Pet new_pet = new Pet();
            switch (type)
            {
                case "Dog":
                    new_pet = new Dog(Name, Breed);
                   break;
                case "Cat":
                    new_pet = new Cat(Name, Breed);
                    break;
            }
            Petshop.AddPet(new_pet);
            return View("Add_finish",new_pet);
        }
        
        public IActionResult Show()
        {

            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
