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
    public partial class Splash : Form
    {
        private string conString = ConfigurationManager.ConnectionStrings["connStr"].ToString();
        private string query;
        public Splash()
        {
            InitializeComponent();
        }
        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bunifuProgressBar1.Value < 100)
            {
                bunifuProgressBar1.Value += 10;
                label2.Text = bunifuProgressBar1.Value + " %";
                if (label2.Text == "100 %")
                {
                    label3.Text = "Loading Complete";
                }
            }
            else
            {
                timer1.Stop();
                bool state = false;
                SqlConnection conn = new SqlConnection(conString);
                conn.Open();
                query = "SELECT Disclaimer_Check FROM System_Configuration";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    state = (bool)sdr["Disclaimer_Check"];
                }
                if (state == true)
                {
                    this.Hide();
                    MainForm frm = new MainForm();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    this.Hide();
                    Disclaimer frm = new Disclaimer();
                    frm.ShowDialog();
                    this.Close();
                }
                conn.Close();
            }
        }
    }
}