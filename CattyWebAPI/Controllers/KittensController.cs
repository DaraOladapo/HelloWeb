using CattyWebAPI.Data;
using CattyWebLibrary.Models;
using CattyWebLibrary.Models.Binding;
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
    public class KittensController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public KittensController(ApplicationDbContext applicationDbContext)
        {
            dbContext = applicationDbContext;
        }
        [HttpGet("")]
        public IActionResult GetAllKittens()
        {
            var allkittens = dbContext.Kittens.ToList();
            return Ok(allkittens.GetViewModels());
        }
        [HttpGet("{id:int}")]
        public IActionResult GetKittenById(int id)
        {
            var kittenById = dbContext.Kittens.FirstOrDefault(c => c.ID == id);
            if (kittenById == null)
                return NotFound();
            return Ok(kittenById.GetViewModel());
        }
        [HttpPost("")]
        public IActionResult CreateKitten([FromBody] AddKittenBindingModel bindingModel)
        {
            var kittenToCreate = new Kitten
            {
                Name = bindingModel.Name,
                Age = bindingModel.Age,
                Size = bindingModel.Size,
                Cat = dbContext.Cats.FirstOrDefault(c => c.ID == bindingModel.CatID),
                Color = bindingModel.Color,
                PictureURL = "https://th.bing.com/th/id/R80677ad4549c7ab35bc3e3cca9f5fa4e?rik=nlG0uuKC%2fVgkDg&pid=ImgRaw",
                CreatedAt = DateTime.Now
            };
            var createdKitten = dbContext.Kittens.Add(kittenToCreate).Entity;
            dbContext.SaveChanges();
            return Ok(createdKitten.GetViewModel());

        }
        [HttpPut("{id:int}")]
        public IActionResult UpdateKitten([FromBody] Kitten kitten, int id)
        {
            var kittenById = dbContext.Kittens.FirstOrDefault(c => c.ID == id);
            if (kittenById == null)
                return NotFound();
            kittenById.Name = kitten.Name;
            kittenById.Age = kitten.Age;
            kittenById.PictureURL = kitten.PictureURL;
            kittenById.Size = kitten.Size;
            kittenById.Color = kitten.Color;
            dbContext.SaveChanges();
            return Ok(kittenById.GetViewModel());
        }
        [HttpDelete("{id:int}")]
        public IActionResult DeleteKitten(int id)
        {
            var kittenToDelete = dbContext.Kittens.FirstOrDefault(c => c.ID == id);
            if (kittenToDelete == null)
                return NotFound();
            dbContext.Kittens.Remove(kittenToDelete);
            dbContext.SaveChanges();
            return NoContent();
        }
    }
}
