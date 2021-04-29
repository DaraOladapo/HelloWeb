using CattyWebLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace CattyWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Cat> Cats { get; set; }
        public DbSet<Kitten> Kittens { get; set; }
        public DbSet<Vet> Vets { get; set; }
        public DbSet<Visit> Visits { get; set; }
    }
}