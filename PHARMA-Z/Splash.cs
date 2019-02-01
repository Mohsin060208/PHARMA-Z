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
    public partial class Splash : Form
    {
        SystemConfigurationService _systemConfigurationService = new SystemConfigurationService();
        FeedbackService _feedbackService = new FeedbackService();
        public Splash()
        {
            InitializeComponent();
        }
        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
           GlobalConfiguration.Config =  _systemConfigurationService.Get();
           GlobalConfiguration.Feedback = _feedbackService.Get();
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
                var configuration = GlobalConfiguration.Config;
                if (configuration.DisclaimerCheck == true)
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
            }
        }
    }
}