using CattyWebLibary.Models;
using CattyWebLibrary.Models.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CattyWebLibrary.Utility
{
    public static class CatUtility
    {
        public static CatViewModel GetViewModel(this Cat cat)
        {
            var catVM = new CatViewModel()
            {
                Age = cat.Age,
                Color = cat.Color,
                CreatedAt = cat.CreatedAt,
                ID = cat.ID,
                Name = cat.Name,
                PictureURL = cat.PictureURL,
                Size = cat.Size
            };
            return catVM;
        }
        public static List<CatViewModel> GetViewModels(this List<Cat> cats)
        {
            var allCatsVM = new List<CatViewModel>();
            foreach (var cat in cats)
            {
                allCatsVM.Add(new CatViewModel()
                {
                    Age = cat.Age,
                    Color = cat.Color,
                    CreatedAt = cat.CreatedAt,
                    ID = cat.ID,
                    Name = cat.Name,
                    PictureURL = cat.PictureURL,
                    Size = cat.Size
                });
            }
            return allCatsVM;
        }
    }
}
