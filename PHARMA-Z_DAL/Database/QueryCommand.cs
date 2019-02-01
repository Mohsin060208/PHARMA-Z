using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHARMA_Z.DAL.Database
{
    public class QueryCommand :IDisposable
    {
        private SqlCommand _cmd = null;
        public QueryCommand(SqlCommand cmd)
        {
            _cmd = cmd;
            _cmd.Connection.Open();
        }
        public SqlDataReader ExecuteReader()
        {
            return _cmd.ExecuteReader();
        }
        public object ExecuteScalar()
        {
            return _cmd.ExecuteScalar();
        }
        public void Dispose()
        {
            _cmd.Connection.Close();
        }
    }
}
