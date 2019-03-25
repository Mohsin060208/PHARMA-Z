using PHARMA_Z.DAL.Database;
using PHARMA_Z.Model;
using System.Data;
using System.Data.SqlClient;

namespace PHARMA_Z.DAL
{
    public class GenericService
    {
        private DbClient _dbClient = null;
        public GenericService()
        {
            _dbClient = DbClient.CreateDbClient();
        }
        public DataTable GetAllGenericMedicines()
        {
            SqlCommand command = this._dbClient.CreateSqlCommand("GetAllGeneric");
            DataTable dtGeneric = _dbClient.GetDataTable(command);
            return dtGeneric;
        }
    }
}