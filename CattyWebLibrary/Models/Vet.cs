using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CattyWebLibrary.Models
{
    public class Vet
    {
        public int ID { get; set; }
        public string Name { get; set; }

        //Relationships
        public virtual List<Visit> Visits { get; set; }
    }
}
