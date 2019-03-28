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
    public class FeverMedicineService
    {
        private DbClient _dbClient = null;
        public FeverMedicineService()
        {
        _dbClient = DbClient.CreateDbClient();
        }
        public DataTable GetFeverMedicines()
        {
        SqlCommand command = this._dbClient.CreateSqlCommand("GetAllFeverMedicines");
        DataTable dtFever = _dbClient.GetDataTable(command);
        return dtFever;
        }
    }
}
