using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHARMA_Z.Model
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public int CompanyId { get; set; }
        public string Use { get; set; }
        public string Precautions { get; set; }
        public string Meta { get; set; }
        public bool IsRecent { get; set; }
        public bool IsFavorite { get; set; }
        public int FormsId { get; set; }
    }
}