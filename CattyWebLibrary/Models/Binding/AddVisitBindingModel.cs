using CattyWebLibrary.Models.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CattyWebLibrary.Models.Binding
{
    public class AddVisitBindingModel
    {
        public List<VetViewModel> Vets { get; set; }
        public int VetID { get; set; }
        public int CatID { get; set; }
    }
}
