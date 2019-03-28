using PHARMA_Z.DAL.Database;
using PHARMA_Z.Model;
using System.Collections.Generic;
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
        public int GetGenericId(Generic generic)
        {
            SqlCommand command = this._dbClient.CreateSqlCommand("SELECT Id FROM Brand WHERE Name = '" + generic.Name + "'", null, CommandType.Text);
            DataTable dtBrand = _dbClient.GetDataTable(command);
            if (dtBrand != null && dtBrand.Rows.Count > 0)
            {
                for (int i = 0; i < dtBrand.Rows.Count; i++)
                {
                    generic.Id = dtBrand.Rows[i].Field<int>("Id");
                }
            }
            return generic.Id;
        }
        public DataTable GetAllBrands(int BrandId)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter()
            {
                ParameterName = "@id",
                Value = BrandId
            });
            SqlCommand command = this._dbClient.CreateSqlCommand("GetBrand", parameters);
            DataTable dtBrand = _dbClient.GetDataTable(command);
            return dtBrand;
        }
    }
}