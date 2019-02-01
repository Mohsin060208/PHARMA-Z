using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHARMA_Z.Entities;
using PHARMA_Z.DAL.Database;

namespace PHARMA_Z.DAL
{
    public class DosageService
    {
        private DbClient _dbClient = null;
        public DosageService()
        {
            _dbClient = DbClient.CreateDbClient();
        }
        public Dosages getDosages()
        {
            var query = "SELECT * FROM Dosages";
            var dosages = new Dosages();
            _dbClient.InvokeReader(query, sdr =>{
                dosages.Id = int.Parse(sdr["Id"].ToString());
                dosages.Adult = sdr["Adult"].ToString();
                dosages.Neonatal = sdr["Neonatal"].ToString();
                dosages.Pedriatic = sdr["Pedriatic"].ToString();
            });
            return dosages;
        }
    }
}