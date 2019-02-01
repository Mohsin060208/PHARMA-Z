using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHARMA_Z.DAL;
using PHARMA_Z_Entities;

namespace PHARMA_Z_Business
{
    class ThemeToggle_Business
    {
        private SystemConfigurationService tt_Dal = null;
        public int Update(System_Configuration sys_conf)
        {
            try
            {
                return tt_Dal.Update(sys_conf);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
