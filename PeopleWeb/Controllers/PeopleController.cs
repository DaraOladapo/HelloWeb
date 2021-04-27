using Microsoft.AspNetCore.Mvc;
using PeopleWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleWeb.Controllers
{
    public class PeopleController : Controller
    {
        [Route("every-person-in-the-org")]
        public IActionResult Index()
        {
            List<Person> People = new List<Person>()
            {
                new Person{Name="Smith A", EmailAddress="smith@anderson.com", Thumbnail="https://usercontent.one/wp/daraoladapo.com/wp-content/uploads/2020/07/NewProPic.jpg"},
                new Person{Name="James A", EmailAddress="james@anderson.com", Thumbnail="https://usercontent.one/wp/daraoladapo.com/wp-content/uploads/2020/07/NewProPic.jpg"},
                new Person{Name="Elizabeth A", EmailAddress="lizzy@anderson.com", Thumbnail="https://usercontent.one/wp/daraoladapo.com/wp-content/uploads/2020/07/NewProPic.jpg"},
                new Person{Name="Jones A", EmailAddress="jones@anderson.com", Thumbnail="https://usercontent.one/wp/daraoladapo.com/wp-content/uploads/2020/07/NewProPic.jpg"}
            };
            return View(People);
        }
        [Route("details-of-person")]
        public IActionResult Details()
        {
            var person = new Person { Name = "Smith A", EmailAddress = "smith@anderson.com", Thumbnail = "https://usercontent.one/wp/daraoladapo.com/wp-content/uploads/2020/07/NewProPic.jpg" };
            return View(person);

        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
