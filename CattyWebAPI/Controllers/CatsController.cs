using CattyWebAPI.Data;
using CattyWebLibrary.Models;
using CattyWebLibrary.Models.Binding;
using CattyWebLibrary.Models.View;
using CattyWebLibrary.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CattyWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatsController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public CatsController(ApplicationDbContext applicationDbContext)
        {
            dbContext = applicationDbContext;
        }
        [HttpGet("")]
        public IActionResult GetAllCats()
        {
            var allCats = dbContext.Cats.ToList();
            return Ok(allCats.GetViewModels());
        }
        [HttpGet("{id:int}")]
        public IActionResult GetCatById(int id)
        {
            var CatById = dbContext.Cats.FirstOrDefault(c => c.ID == id);
            if (CatById == null)
                return NotFound();
            return Ok(CatById.GetViewModel());
        }
        [HttpPost("")]
        public IActionResult CreateCat([FromBody] AddCatBindingModel bindingModel)
        {
            var CatToCreate = new Cat
            {
                Name = bindingModel.Name,
                Age = bindingModel.Age,
                Size = bindingModel.Size,
                Color = bindingModel.Color,
                PictureURL = "https://th.bing.com/th/id/R80677ad4549c7ab35bc3e3cca9f5fa4e?rik=nlG0uuKC%2fVgkDg&pid=ImgRaw",
                CreatedAt = DateTime.Now
            };
            var createdCat = dbContext.Cats.Add(CatToCreate).Entity;
            dbContext.SaveChanges();
            return Ok(CatToCreate.GetViewModel());

        }
        [HttpPut("{id:int}")]
        public IActionResult UpdateCat([FromBody] Cat Cat, int id)
        {
            var CatById = dbContext.Cats.FirstOrDefault(c => c.ID == id);
            if (CatById == null)
                return NotFound();
            CatById.Name = Cat.Name;
            CatById.Age = Cat.Age;
            CatById.PictureURL = Cat.PictureURL;
            CatById.Size = Cat.Size;
            CatById.Color = Cat.Color;
            dbContext.SaveChanges();
            return Ok(CatById.GetViewModel());
        }
        [HttpDelete("{id:int}")]
        public IActionResult DeleteCat(int id)
        {
            var CatToDelete = dbContext.Cats.FirstOrDefault(c => c.ID == id);
            if (CatToDelete == null)
                return NotFound();
            dbContext.Cats.Remove(CatToDelete);
            dbContext.SaveChanges();
            return NoContent();
        }
    }
}
