using System;

namespace CattyWebLibrary.Models
{
    public class Kitten
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string PictureURL { get; set; }
        public Size Size { get; set; }
        public string Color { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Cat Cat { get; set; }
    }
}
