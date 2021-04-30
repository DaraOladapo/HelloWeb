using CattyWebLibrary.Models;
using CattyWebLibrary.Models.View;
using CattyWebLibrary.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CattyWebTests.Utility
{
    public class VetUtilityTest
    {
        [Fact]
        public void GetViewModel()
        {
            //Arrange
            Vet testVet = new Vet()
            {
                ID = 1,
                Name = "Sammy D"
            };
            //Act
            var testVetVM = testVet.GetViewModel();
            //Assert
            Assert.IsType<VetViewModel>(testVetVM);
            Assert.NotNull(testVetVM);
            Assert.NotEmpty(testVetVM.Name);
        }
        [Fact]
        public void GetViewModels()
        {
            //Arrange
            List<Vet> testVets = new List<Vet>()
            {
                new Vet()
                {
                    ID = 1,
                    Name = "Sammy D"
                },    new Vet()
                {
                    ID = 2,
                    Name = "Sammy J"
                },    new Vet()
                {
                    ID = 3,
                    Name = "Sammy P"
                }
            };
            //Act
            var testVetsVM = testVets.GetViewModels();
            //Assert
            Assert.NotEmpty(testVetsVM);
            Assert.IsType<List<VetViewModel>>(testVetsVM);
        }
    }
}
