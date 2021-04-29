using CattyWebApp.Data;
using CattyWebLibrary.Models;
using CattyWebLibrary.Models.Binding;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CattyWebApp.Controllers
{
    [Route("[Controller]")]
    public class VetsController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public VetsController(ApplicationDbContext applicationDbContext)
        {
            dbContext = applicationDbContext;
        }
        //READ
        [Route("")]
        public IActionResult Index()
        {
            var allVets = dbContext.Vets.ToList();
            return View(allVets);
        }
        [Route("details/{id:int}")]
        public IActionResult Details(int id)
        {
            var vetById = dbContext.Vets.FirstOrDefault(c => c.ID == id);
            return View(vetById);
        }
        //CREATE
        [Route("create")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost("create")]
        public IActionResult Create(AddVetBindingModel bindingModel)
        {
            var vetToCreate = new Vet
            {
                Name = bindingModel.Name
            };
            dbContext.Vets.Add(vetToCreate);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        //UPDATE
        [Route("update/{id:int}")]
        public IActionResult Update(int id)
        {
            var vetById = dbContext.Vets.FirstOrDefault(c => c.ID == id);
            return View(vetById);
        }
        [HttpPost]
        [Route("update/{id:int}")]
        public IActionResult Update(Vet vet, int id)
        {
            var vetToUpdate = dbContext.Vets.FirstOrDefault(c => c.ID == id);
            vetToUpdate.Name = vet.Name;
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        //DELETE
        [Route("delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            var vetToDelete = dbContext.Vets.FirstOrDefault(c => c.ID == id);
            dbContext.Vets.Remove(vetToDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
