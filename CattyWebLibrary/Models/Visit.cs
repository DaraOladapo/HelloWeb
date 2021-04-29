using System;

namespace CattyWebLibrary.Models
{
    public class Visit
    {
        public int ID { get; set; }
        public DateTime VisitDate { get; set; }

        //Relationships
        public virtual Vet Vet { get; set; }
        public virtual Cat Cat { get; set; }
    }
}