using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHARMA_Z;
using PHARMA_Z.DAL.Database;
using PHARMA_Z.Model;
using System.Data.SqlClient;
using System.Data;

namespace PHARMA_Z.DAL
{
    class CoughMedicineService
    {
        private DbClient _dbClient = null; 
        public CoughMedicineService()
        {
            _dbClient = DbClient.CreateDbClient();
        }
        public DataTable GetCoughMedicines()
        {

            SqlCommand command = this._dbClient.CreateSqlCommand("GetAllCoughMedicines");
            DataTable dtCough = _dbClient.GetDataTable(command);
            return dtCough;
        }
    }
}
