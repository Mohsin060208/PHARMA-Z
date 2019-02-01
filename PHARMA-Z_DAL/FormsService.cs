using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHARMA_Z.DAL.Database;
using PHARMA_Z.Model;

namespace PHARMA_Z.DAL
{
    public class FormsService
    {
        private DbClient _dbClient = null;
        public FormsService()
        {
            _dbClient = DbClient.CreateDbClient();
        }
        public Forms GetAllForms()
        {
            var query = "SELECT * FROM Forms";
            var forms = new Forms();
            _dbClient.InvokeReader(query,sdr =>
            {   
                while (sdr.Read())
                {
                    forms.Id = int.Parse(sdr["Id"].ToString());
                    forms.Image = sdr["Image"].ToString();
                    forms.MedicineForm = sdr["Medicine_Form"].ToString();
                    forms.Price = float.Parse(sdr["Price"].ToString());
                }
            });
            return forms;
        }
    }
}
