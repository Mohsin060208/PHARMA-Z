using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHARMA_Z.DAL;
using PHARMA_Z.Model;

namespace PHARMA_Z
{
    public partial class Disclaimer : Form
    {
        SystemConfigurationService _systemConfigurationService = new SystemConfigurationService();
        public Disclaimer()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm frm = new MainForm();
            frm.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
            _systemConfigurationService.Update(true);    
            }
            else
            {
            _systemConfigurationService.Update(true);       
            }
        }
    }
}