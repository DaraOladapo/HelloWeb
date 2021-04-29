using CattyWebLibrary.Models;
using CattyWebLibrary.Models.View;
using System.Collections.Generic;

namespace CattyWebLibrary.Utility
{
    public static class VetUtility
    {
        public static VetViewModel GetViewModel(this Vet vet)
        {
            var vetVM = new VetViewModel()
            {
                ID = vet.ID,
                Name = vet.Name
            };
            return vetVM;
        }
        public static List<VetViewModel> GetViewModels(this List<Vet> vets)
        {
            var allVetsVM = new List<VetViewModel>();
            foreach (var vet in vets)
            {
                allVetsVM.Add(new VetViewModel()
                {
                    ID = vet.ID,
                    Name = vet.Name
                });
            }
            return allVetsVM;
        }
    }
}
