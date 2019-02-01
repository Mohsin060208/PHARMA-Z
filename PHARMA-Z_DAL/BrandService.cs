using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHARMA_Z.Entities;
using PHARMA_Z.DAL.Database;

namespace PHARMA_Z.DAL
{
    public class BrandService
    {
        private DbClient _dbClient = null;
        public BrandService()
        {
            _dbClient = DbClient.CreateDbClient();
        }
        public Brand GetAllBrands()
        {
            var query = "SELECT * FROM Brand";
            var brands = new Brand();
            _dbClient.InvokeReader(query, sdr => {
                brands.BrandId = int.Parse(sdr["Id"].ToString());
                brands.BrandName = sdr["Name"].ToString();
                brands.CompanyId = int.Parse(sdr["CompanyId"].ToString());
                brands.GenericId = int.Parse(sdr["GenericId"].ToString());
                brands.FormId = int.Parse(sdr["FormId"].ToString());
            });
            return brands;
        }
    }
}
