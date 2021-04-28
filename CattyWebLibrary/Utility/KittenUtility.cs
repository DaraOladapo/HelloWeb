using CattyWebLibary.Models;
using CattyWebLibrary.Models.View;
using System.Collections.Generic;

namespace CattyWebLibrary.Utility
{
    public static class KittenUtility
    {
        public static KittenViewModel GetViewModel(this Kitten kitten)
        {
            var kittenVM = new KittenViewModel()
            {
                Age = kitten.Age,
                Color = kitten.Color,
                CreatedAt = kitten.CreatedAt,
                ID = kitten.ID,
                Name = kitten.Name,
                PictureURL = kitten.PictureURL,
                Size = kitten.Size
            };
            return kittenVM;
        }
        public static List<KittenViewModel> GetViewModels(this List<Kitten> kittens)
        {
            var allkittensVM = new List<KittenViewModel>();
            foreach (var kitten in kittens)
            {
                allkittensVM.Add(new KittenViewModel()
                {
                    Age = kitten.Age,
                    Color = kitten.Color,
                    CreatedAt = kitten.CreatedAt,
                    ID = kitten.ID,
                    Name = kitten.Name,
                    PictureURL = kitten.PictureURL,
                    Size = kitten.Size
                });
            }
            return allkittensVM;
        }
    }
}
