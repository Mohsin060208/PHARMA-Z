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

namespace PHARMA_Z
{
    public partial class Disclaimer : Form
    {
        private string conString = ConfigurationManager.ConnectionStrings["connStr"].ToString();
        private string query;
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
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            query = "UPDATE System_Configuration SET Disclaimer_Check = 1";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}