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
        public List<string> GetGenericNames()
        {
            List<string> GenericList = new List<string>();
            SqlCommand command = this._dbClient.CreateSqlCommand("GetGenericName");
            DataTable dtBrand = _dbClient.GetDataTable(command);
            if (dtBrand != null && dtBrand.Rows.Count > 0)
            {
                for (int i = 0; i < dtBrand.Rows.Count; i++)
                {
                    GenericList.Add(dtBrand.Rows[i].Field<string>("Name"));
                }
            }
            return GenericList;
        }
        public int GetGenericId(Generic generic)
        {
            SqlCommand command = this._dbClient.CreateSqlCommand("SELECT Id FROM Generic WHERE Name = '" + generic.Name + "'", null, CommandType.Text);
            DataTable dtBrand = _dbClient.GetDataTable(command);
            if (dtBrand != null && dtBrand.Rows.Count > 0)
            {
                for (int i = 0; i < dtBrand.Rows.Count; i++)
                {
                    generic.Id = dtBrand.Rows[i].Field<int>("Id");
                }
            }
            else
            {
                generic.Id = 0;
            }
            return generic.Id;
        }
        public DataTable GetGeneric (int GenericId)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter()
            {
                ParameterName = "@id",
                Value = GenericId
            });
            SqlCommand command = this._dbClient.CreateSqlCommand("GetGenericMedicine", parameters);
            DataTable dtBrand = _dbClient.GetDataTable(command);
            return dtBrand;
        }
    }
}