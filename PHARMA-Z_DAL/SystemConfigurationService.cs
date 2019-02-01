using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHARMA_Z.Model;
using PHARMA_Z.DAL.Database;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace PHARMA_Z.DAL
{
    public class SystemConfigurationService
    {
        private DbClient _dbClient = null;
        private SystemConfiguration _configuration;
        public SystemConfigurationService()
        {
            _dbClient = DbClient.CreateDbClient();
            _configuration = new SystemConfiguration();
        }
        public void UpdateTheme(Themes theme)
        {
            List<SqlParameter> parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter()
            {
                ParameterName = "@theme",
                Value = (int)theme
            });
            SqlCommand command = this._dbClient.CreateSqlCommand("UpdateTheme", parameter,CommandType.StoredProcedure);
            object result = _dbClient.ExecuteScalar(command);
        }
        public void Update(bool value)
        {            
            List<SqlParameter> parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter()
            {
                ParameterName = "@DisclaimerCheck",
                Value = value
            });
            SqlCommand command = this._dbClient.CreateSqlCommand("UpdateDisclaimerCheck", parameter);
            _dbClient.ExecuteScalar(command);
        }
        public SystemConfiguration Get()
        {
            SqlCommand command = this._dbClient.CreateSqlCommand("GetInitialSystemConfiguration");
            DataTable dtSys = _dbClient.GetDataTable(command);
            _configuration.DisclaimerCheck = dtSys.Rows[0].Field<bool>("Disclaimer_Check");
            _configuration.ThemeToggle = dtSys.Rows[0].Field<Themes>("Theme_Toggle");
            return _configuration;
        }
    }
}