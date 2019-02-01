using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHARMA_Z.Model
{
    public class Brand : Generic
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public int GenericId { get; set; }
        public int CompanyId { get; set; }
        public int FormId { get; set; }
    }
}