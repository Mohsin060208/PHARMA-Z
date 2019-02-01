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
    public class CompanyService
    {
        private DbClient _dbClient = null;
        public CompanyService ()
	    {
            _dbClient = DbClient.CreateDbClient();
        }
            public DataTable GetAllCompanies()
            {
            SqlCommand command = this._dbClient.CreateSqlCommand("GetAllCompanies");
            DataTable dtCompanies = _dbClient.GetDataTable(command);
            return dtCompanies;
	    }
    }
}

