using System;

namespace CattyWebLibrary.Models.View
{
    public class VisitViewModel
    {
        public int ID { get; set; }
        public DateTime VisitDate { get; set; }
        public VetViewModel Vet{ get; set; }
        public CatViewModel Cat{ get; set; }
    }
}
