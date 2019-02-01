using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHARMA_Z.DAL.Database;
using PHARMA_Z.Entities;

namespace PHARMA_Z.DAL
{
    public class GenericService
    {
        private DbClient _dbClient = null;
        public GenericService()
        {
            _dbClient = DbClient.CreateDbClient();
        }
        public Generic GetAllGenericMedicines()
        {
            var query = "SELECT * FROM Generic";
            var generic = new Generic();
            _dbClient.InvokeReader(query, sdr =>
            {
                while (sdr.Read())
                {
                    generic.Id = int.Parse(sdr["Id"].ToString());
                    generic.High_Risk_Groups = sdr["High_Risk_Groups"].ToString();
                    generic.Indications = sdr["Indications"].ToString();
                    generic.Name = sdr["Name"].ToString();
                    generic.isFavorited = (bool)sdr["isFavorited"];
                    generic.Overview = sdr["OvervieW"].ToString();
                    generic.Side_Effects = sdr["Side_Effects"].ToString();
                    generic.Warnings = sdr["Warnings"].ToString();
                    generic.Contraindication = sdr["Contraindication"].ToString();
                    generic.DosagesId = int.Parse(sdr["DosagesId"].ToString());
                }
            });
            return generic;
        }
    }
}