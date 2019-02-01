using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHARMA_Z.Model;
using System.Data.SqlClient;
using PHARMA_Z.DAL.Database;
using System.Configuration;
using System.Data;

namespace PHARMA_Z.DAL
{
    public class FeedbackService
    {
        private DbClient _dbClient = null;
        private Feedback _feedback;
        public FeedbackService()
        {
            _dbClient = DbClient.CreateDbClient();
            _feedback = new Feedback();
        }
        public Feedback Get()
        {
            SqlCommand command = this._dbClient.CreateSqlCommand("InitializeFeedback");
            DataTable dtFdb = _dbClient.GetDataTable(command);
            _feedback.EmailFrom = dtFdb.Rows[0].Field<string>("EmailFrom");
           _feedback.EmailTo = dtFdb.Rows[0].Field<string>("EmailTo");
           _feedback.Pwd = dtFdb.Rows[0].Field<string>("Pwd");
           return _feedback;
        }
    }
}