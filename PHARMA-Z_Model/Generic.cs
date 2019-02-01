using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHARMA_Z.Model
{
    public class Generic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Overview { get; set; }
        public string Indications { get; set; }
        public string Contraindication { get; set; }
        public string Warnings { get; set; }
        public int DosagesId { get; set; }
        public string Side_Effects { get; set; }
        public string High_Risk_Groups { get; set; }
        public bool? isFavorited { get; set; }
    }
}
