using CattyWebLibrary.Models;
using CattyWebLibrary.Models.View;
using CattyWebLibrary.Utility;
using System;
using System.Collections.Generic;
using Xunit;

namespace CattyWebTests.Utility
{
    public class CatUtilityTest
    {
        [Fact]
        public void GetViewModel()
        {
            //Arrange
            Cat testCat = new Cat()
            {
                ID = 1,
                Name = "Sammy D",
                Age = 1,
                PictureURL = "https://th.bing.com/th/id/R80677ad4549c7ab35bc3e3cca9f5fa4e?rik=nlG0uuKC%2fVgkDg&pid=ImgRaw",
                Size = Size.Small,
                Color = "White",
                CreatedAt = DateTime.Now.AddMonths(-5)
            };
            //Act
            var testCatVM = testCat.GetViewModel();
            //Assert
            Assert.IsType<CatViewModel>(testCatVM);
            Assert.NotNull(testCatVM);
            Assert.NotEmpty(testCatVM.PictureURL);
        }
        [Fact]
        public void GetViewModels()
        {
            //Arrange
            List<Cat> testCats = new List<Cat>()
            {
                new Cat()
                {
                    ID = 1,
                    Name = "Sammy D",
                    Age = 1,
                    PictureURL = "https://th.bing.com/th/id/R80677ad4549c7ab35bc3e3cca9f5fa4e?rik=nlG0uuKC%2fVgkDg&pid=ImgRaw",
                    Size = Size.Small,
                    Color = "White",
                    CreatedAt = DateTime.Now.AddMonths(-5)
                },    new Cat()
                {
                    ID = 2,
                    Name = "Sammy J",
                    Age = 2,
                    PictureURL = "https://th.bing.com/th/id/R80677ad4549c7ab35bc3e3cca9f5fa4e?rik=nlG0uuKC%2fVgkDg&pid=ImgRaw",
                    Size = Size.Medium,
                    Color = "Black",
                    CreatedAt = DateTime.Now.AddMonths(-4)
                },    new Cat()
                {
                    ID = 3,
                    Name = "Sammy P",
                    Age = 1,
                    PictureURL = "https://th.bing.com/th/id/R80677ad4549c7ab35bc3e3cca9f5fa4e?rik=nlG0uuKC%2fVgkDg&pid=ImgRaw",
                    Size = Size.Small,
                    Color = "Blue",
                    CreatedAt = DateTime.Now.AddMonths(-1)
                }
            };
            //Act
            var testCatsVM = testCats.GetViewModels();
            //Assert
            Assert.NotEmpty(testCatsVM);
            Assert.IsType<List<CatViewModel>>(testCatsVM);
        }
    }
}
