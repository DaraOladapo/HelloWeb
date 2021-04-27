using CattyWebApp.Data;
using CattyWebApp.Models.Binding;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CattyWebApp.Controllers
{
    public class CatsController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public CatsController(ApplicationDbContext applicationDbContext)
        {
            dbContext = applicationDbContext;
        }
        public IActionResult Index()
        {
            var allCats = dbContext.Cats.ToList();
            return View(allCats);
        }
        //[Route("details/[int:id]")]
        //public IActionResult Details(int id)
        //{
        //    var catById = dbContext.Cats.FirstOrDefault(c => c.ID == id);
        //    return View(catById);
        //}
        //public IActionResult Create()
        //{
        //    return View();
        //}
        //[Route("update/{int:id}")]
        //public IActionResult Update(int id)
        //{
        //    var catById = dbContext.Cats.FirstOrDefault(c => c.ID == id);
        //    return View(catById);
        //}
        //public IActionResult Delete()
        //{
        //    return View();
        //}
    }
}
