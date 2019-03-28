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
        public string Gramage { get; set; }
        public int BrandId { get; set; }
        public bool? IsRecent { get; set; }
        public string Indications { get; set; }
        public string SideEffects { get; set; }
    }
}
