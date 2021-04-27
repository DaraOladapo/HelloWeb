using CattyWebApp.Data;
using CattyWebApp.Models;
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
        //READ
        public IActionResult Index()
        {
            var allCats = dbContext.Cats.ToList();
            return View(allCats);
        }
        [Route("details/{id:int}")]
        public IActionResult Details(int id)
        {
            var catById = dbContext.Cats.FirstOrDefault(c => c.ID == id);
            return View(catById);
        }

        //CREATE
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(AddCatBindingModel bindingModel)
        {
            var catToCreate = new Cat
            {
                Name = bindingModel.Name,
                Age = bindingModel.Age,
                Size = bindingModel.Size,
                Color = bindingModel.Color,
                PictureURL= "https://th.bing.com/th/id/R80677ad4549c7ab35bc3e3cca9f5fa4e?rik=nlG0uuKC%2fVgkDg&pid=ImgRaw",
                CreatedAt = DateTime.Now
            };
            dbContext.Cats.Add(catToCreate);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        //UPDATE
        [Route("update/{id:int}")]
        public IActionResult Update(int id)
        {
            var catById = dbContext.Cats.FirstOrDefault(c => c.ID == id);
            return View(catById);
        }
        //DELETE
        //public IActionResult Delete()
        //{
        //    return View();
        //}
    }
}
