using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHARMA_Z.DAL;
using PHARMA_Z.Model;

namespace PHARMA_Z
{
    public partial class MainForm : Form
    {
        private AutoCompleteStringCollection _coll = new AutoCompleteStringCollection();
        private SystemConfigurationService _systemConfigurationService;
        private Generic _generic;
        private GenericService _genericService;
        private Brand _brand;
        private HeadacheMedicineService _headacheMedicineService;
        private BrandService _brandService;
        public MainForm()
        {
            InitializeComponent();
            _systemConfigurationService = new SystemConfigurationService();
            _generic = new Model.Generic();
            _genericService = new GenericService();
            _headacheMedicineService = new HeadacheMedicineService();
            _brand = new Model.Brand();
            _brandService = new BrandService();
            AutoComplete();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            var configuration = GlobalConfiguration.Config;
                if(configuration.ThemeToggle.Equals(Themes.Dark)){
                OffSwitch.Visible = false;
                OnSwitch.Visible = true;
                DarkThemeOn();
                }
            else
            {
                OnSwitch.Visible = false;
                OffSwitch.Visible = true;
                DarkThemeOff();
            }
            timer1.Start();
            Time.Text = DateTime.Now.ToLongTimeString();
            Date.Text = DateTime.Now.ToLongDateString();
            Subject.SelectedIndex = 0;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToLongTimeString();
        }
        private void Maximize_Click(object sender, EventArgs e)
        {
            if (TitlePanel.BackColor == Color.White)
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    this.WindowState = FormWindowState.Maximized;
                    Maximize.BackgroundImage = Properties.Resources.NormalState_Light;
                        Sidebar.Visible = false;
                        Sidebar.Width = 212;
                        MenuBtn.Visible = false;
                        PanelAnimator.ShowSync(Sidebar);
                        SidebarTitleAnimator.ShowSync(SidebarTitle);
                }
                else
                {
                    this.WindowState = FormWindowState.Normal;
                    Maximize.BackgroundImage = Properties.Resources.MaximizedState_Light;
                        MenuBtn.Visible = true;
                        SidebarTitle.Visible = false;
                        Sidebar.Visible = false;
                        Sidebar.Width = 62;
                        Menu_Expand_Animator.ShowSync(Sidebar);
                }
            }
            else
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    this.WindowState = FormWindowState.Maximized;
                    Maximize.BackgroundImage = Properties.Resources.NormalState_Dark;
                    Sidebar.Visible = false;
                    Sidebar.Width = 212;
                    MenuBtn.Visible = false;
                    PanelAnimator.ShowSync(Sidebar);
                    SidebarTitleAnimator.ShowSync(SidebarTitle);
                }
                else
                {
                    this.WindowState = FormWindowState.Normal;
                    Maximize.BackgroundImage = Properties.Resources.MaximizedState_Dark;
                    if (Sidebar.Width == 212)
                    {
                        MenuBtn.Visible = true;
                        SidebarTitle.Visible = false;
                        Sidebar.Visible = false;
                        Sidebar.Width = 62;
                        Menu_Expand_Animator.ShowSync(Sidebar);
                    }
                }
            }
        }
        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Off_Switch_Click(object sender, EventArgs e)
        {
            OffSwitch.Visible = false;
            OnSwitch.Visible = true;
            DarkThemeOn();
        }
        private void DarkThemeOn()
            {
               _systemConfigurationService.UpdateTheme(Themes.Dark);
                TitlePanelChangesDarkTheme();
                HeadingChangesDarkTheme();
                SidebarChangesDarkTheme();
                BottomPanelChangesDarkTheme();
                BodyChangesDarkTheme();
            }
        private void TitlePanelChangesDarkTheme()
        {
            TitleIcon.BackgroundImage = Properties.Resources.logo_title;
            title.ForeColor = Color.Lavender;
            TitlePanel.BackColor = Color.Black;
            Close_Btn.BackgroundImage = Properties.Resources.close;
            Minimize.BackgroundImage = Properties.Resources.Minimize_dark;
            Minimize.OnHovercolor = Color.FromArgb(31, 31, 31);
            if (this.WindowState == FormWindowState.Normal)
            {
                Maximize.BackgroundImage = Properties.Resources.MaximizedState_Dark;
            }
            else
            {
                Maximize.BackgroundImage = Properties.Resources.NormalState_Dark;
            }
            Maximize.OnHovercolor = Color.FromArgb(31, 31, 31);
        }
        private void HeadingChangesDarkTheme()
        {
            HeadingLabel.ForeColor = Color.Lavender;
            ThemeToggle.ForeColor = Color.Lavender;
            if (Home_Indicator.Visible == true)
            {
                Heading.BackColor = Color.FromArgb(31, 31, 31);
                HomeDesc.ForeColor = Color.Lavender;
                HeadingLabel.Text = "PHARMA-Z";
                FeedbackDesc.Visible = false;
                Search_desc.Visible = false;
                SearchResultDesc.Visible = false;
                SearchResult_Label.Visible = false;
                Back_btn.Visible = false;
            }
            else
            {
                Heading.BackColor = Color.Black;
                if (Feedback_Indicator.Visible == true)
                {
                    HeadingLabel.Text = "FEEDBACK";
                    FeedbackDesc.Visible = true;
                    FeedbackDesc.ForeColor = Color.Lavender;
                    SearchResultDesc.Visible = false;
                    SearchResult_Label.Visible = false;
                    Back_btn.Visible = false;
                }
                else if (Search_Indicator.Visible == true)
                {
                    if (SearchResult_Label.Visible == true)
                    {
                        Search_desc.Visible = false;
                        Back_btn.Visible = true;
                        SearchResult_Label.Visible = true;
                        SearchResult_Label.ForeColor = Color.Lavender;
                        SearchResultDesc.ForeColor = Color.Lavender;
                        Back_btn.Normalcolor = Color.Black;
                        Back_btn.OnHovercolor = Color.FromArgb(31, 31, 31);
                        Back_btn.Activecolor = Color.FromArgb(31, 31, 31);
                        Back_btn.DisabledColor = Color.Black;
                        Back_btn.Iconimage = Properties.Resources.Back_Dark;
                    }
                    else
                    {
                        SearchResultDesc.Visible = false;
                        HeadingLabel.Text = "SEARCH";
                        Search_desc.Visible = true;
                        Search_desc.ForeColor = Color.Lavender;
                        SearchResult_Label.ForeColor = Color.Lavender;
                        Back_btn.Visible = false;
                    }

                }
                else if (Disclaimer_Indicator.Visible == true)
                {
                    HeadingLabel.Text = "Disclaimer";
                    Search_desc.Visible = false;
                    SearchResultDesc.Visible = false;
                    SearchResult_Label.Visible = false;
                    Back_btn.Visible = false;
                }
                else if (About_Indicator.Visible == true)
                {
                    HeadingLabel.Text = "About";
                    Search_desc.Visible = false;
                    SearchResultDesc.Visible = false;
                    SearchResult_Label.Visible = false;
                    Back_btn.Visible = false;
                }
            }
        }
        private void SidebarChangesDarkTheme()
        {
            Sidebar.BackColor = Color.FromArgb(31, 31, 31);
            SidebarTitle.ForeColor = Color.Lavender;
            MenuBtn.Image = Properties.Resources.Menu_Dark;
            MenuBtn.BackColor = Color.FromArgb(31, 31, 31);
            Menu_Expand.Image = Properties.Resources.Menu_Dark;
            Menu_Expand.BackColor = Color.FromArgb(31, 31, 31);
            Home.Normalcolor = Color.FromArgb(31, 31, 31);
            Home.OnHovercolor = Color.FromArgb(43, 43, 43);
            Home.Activecolor = Color.FromArgb(31, 31, 31);
            Home.Iconimage = Properties.Resources.Home_dark;
            Back_to_home.Normalcolor = Color.FromArgb(31, 31, 31);
            Back_to_home.OnHovercolor = Color.FromArgb(43, 43, 43);
            Back_to_home.Activecolor = Color.FromArgb(31, 31, 31);
            Back_to_home.DisabledColor = Color.FromArgb(31, 31, 31);
            Back_to_home.Iconimage = Properties.Resources.Back_Dark;
            if (Home_Indicator.Visible == true)
            {
                Home.Textcolor = Color.FromArgb(0, 120, 215);
                Back_to_home.Enabled = false;
            }
            else
            {
                Home.Textcolor = Color.Lavender;
                Back_to_home.Enabled = true;
            }
            Home.OnHoverTextColor = Color.FromArgb(0, 120, 215);
            Home_Indicator.BackColor = Color.FromArgb(0, 120, 215);
            Search.Normalcolor = Color.FromArgb(31, 31, 31);
            Search.OnHovercolor = Color.FromArgb(43, 43, 43);
            Search.Activecolor = Color.FromArgb(31, 31, 31);
            Search.Iconimage = Properties.Resources.Search_small_dark;
            if (Search_Indicator.Visible == true)
            {
                Search.Textcolor = Color.FromArgb(0, 120, 215);
            }
            else
            {
                Search.Textcolor = Color.Lavender;
            }
            Search.OnHoverTextColor = Color.FromArgb(0, 120, 215);
            Search_Indicator.BackColor = Color.FromArgb(0, 120, 215);
            Recent.Normalcolor = Color.FromArgb(31, 31, 31);
            Recent.OnHovercolor = Color.FromArgb(43, 43, 43);
            Recent.Activecolor = Color.FromArgb(31, 31, 31);
            Recent.Iconimage = Properties.Resources.Recent_small_dark;
            if (RecentIndicator.Visible == true)
            {
                Recent.Textcolor = Color.FromArgb(0, 120, 215);
            }
            else
            {
                Recent.Textcolor = Color.Lavender;
            }
            Recent.OnHoverTextColor = Color.FromArgb(0, 120, 215);
            RecentIndicator.BackColor = Color.FromArgb(0, 120, 215);
            Favorites.Normalcolor = Color.FromArgb(31, 31, 31);
            Favorites.OnHovercolor = Color.FromArgb(43, 43, 43);
            Favorites.Activecolor = Color.FromArgb(31, 31, 31);
            Favorites.Iconimage = Properties.Resources.Favorites_small_dark;
            if (FavoritesIndicator.Visible == true)
            {
                Favorites.Textcolor = Color.FromArgb(0, 120, 215);
            }
            else
            {
                Favorites.Textcolor = Color.Lavender;
            }
            Favorites.OnHoverTextColor = Color.FromArgb(0, 120, 215);
            FavoritesIndicator.BackColor = Color.FromArgb(0, 120, 215);
            Disclaimer.Normalcolor = Color.FromArgb(31, 31, 31);
            Disclaimer.OnHovercolor = Color.FromArgb(43, 43, 43);
            Disclaimer.Activecolor = Color.FromArgb(31, 31, 31);
            Disclaimer.Iconimage = Properties.Resources.Disclaimer_small_dark;
            if (Disclaimer_Indicator.Visible == true)
            {
                Disclaimer.Textcolor = Color.FromArgb(0, 120, 215);
            }
            else
            {
                Disclaimer.Textcolor = Color.Lavender;
            }
            Disclaimer.OnHoverTextColor = Color.FromArgb(0, 120, 215);
            Disclaimer_Indicator.BackColor = Color.FromArgb(0, 120, 215);
            About.Normalcolor = Color.FromArgb(31, 31, 31);
            About.OnHovercolor = Color.FromArgb(43, 43, 43);
            About.Activecolor = Color.FromArgb(31, 31, 31);
            About.Iconimage = Properties.Resources.About_small_dark;
            if (About_Indicator.Visible == true)
            {
                About.Textcolor = Color.FromArgb(0, 120, 215);
            }
            else
            {
                About.Textcolor = Color.Lavender;
            }
            About.OnHoverTextColor = Color.FromArgb(0, 120, 215);
            About_Indicator.BackColor = Color.FromArgb(0, 120, 215);
            Feedback.Normalcolor = Color.FromArgb(31, 31, 31);
            Feedback.OnHovercolor = Color.FromArgb(43, 43, 43);
            Feedback.Activecolor = Color.FromArgb(31, 31, 31);
            Feedback.Iconimage = Properties.Resources.Feedback_small_dark;
            if (Feedback_Indicator.Visible == true)
            {
                Feedback.Textcolor = Color.FromArgb(0, 120, 215);
            }
            else
            {
                Feedback.Textcolor = Color.Lavender;
            }
            Feedback.OnHoverTextColor = Color.FromArgb(0, 120, 215);
            Feedback_Indicator.BackColor = Color.FromArgb(0, 120, 215);
        }
        private void BodyChangesDarkTheme()
        {
            this.BackColor = Color.Black;
            if (Home_Indicator.Visible == true)
            {
            Body.BackColor = Color.Black;
            Search_Tile.BackColor = Color.FromArgb(31, 31, 31);
            Search_Tile.colorActive = Color.FromArgb(43, 43, 43);
            Search_Tile.color = Color.FromArgb(31, 31, 31);
            Search_Tile.Image = Properties.Resources.Search_logo_dark;
            Search_Tile.ForeColor = Color.Lavender;
            Recent_Tile.BackColor = Color.FromArgb(31, 31, 31);
            Recent_Tile.colorActive = Color.FromArgb(43, 43, 43);
            Recent_Tile.color = Color.FromArgb(31, 31, 31);
            Recent_Tile.Image = Properties.Resources.Recent_logo_dark;
            Recent_Tile.ForeColor = Color.Lavender;
            Favorites_Tile.BackColor = Color.FromArgb(31, 31, 31);
            Favorites_Tile.colorActive = Color.FromArgb(43, 43, 43);
            Favorites_Tile.color = Color.FromArgb(31, 31, 31);
            Favorites_Tile.Image = Properties.Resources.Favorites_logo_dark;
            Favorites_Tile.ForeColor = Color.Lavender;
            Feedback_Panel.Visible = false;
            Feedback_Tile.BackColor = Color.FromArgb(31, 31, 31);
            Feedback_Tile.colorActive = Color.FromArgb(43, 43, 43);
            Feedback_Tile.color = Color.FromArgb(31, 31, 31);
            Feedback_Tile.Image = Properties.Resources.Feedback_logo_dark;
            Feedback_Tile.ForeColor = Color.Lavender;
            Disclaimer_Tile.BackColor = Color.FromArgb(31, 31, 31);
            Disclaimer_Tile.colorActive = Color.FromArgb(43, 43, 43);
            Disclaimer_Tile.color = Color.FromArgb(31, 31, 31);
            Disclaimer_Tile.Image = Properties.Resources.Disclaimer_logo_dark;
            Disclaimer_Tile.ForeColor = Color.Lavender;
            About_Tile.BackColor = Color.FromArgb(31, 31, 31);
            About_Tile.colorActive = Color.FromArgb(43, 43, 43);
            About_Tile.color = Color.FromArgb(31, 31, 31);
            About_Tile.Image = Properties.Resources.About_logo_dark;
            About_Tile.ForeColor = Color.Lavender;
            }
            else if (Feedback_Indicator.Visible == true)
            {
                Feedback_Panel.Visible = true;
                Search_Panel.Visible = false;
                Feedback_Panel.BackColor = Color.Black;
                ClientName_Label.ForeColor = Color.Lavender;
                ClientName.BorderColorMouseHover = Color.FromArgb(0,120,215);
                ClientName.BorderColorFocused = Color.FromArgb(0, 120, 215);
                ClientName.ForeColor = Color.Lavender;
                EmailLbl.ForeColor = Color.Lavender;
                Email_tb.BorderColorMouseHover = Color.FromArgb(0, 120, 215);
                Email_tb.BorderColorFocused = Color.FromArgb(0, 120, 215);
                Email_tb.ForeColor = Color.Lavender;
                SubjectLabel.ForeColor = Color.Lavender;
                Message.BackColor = Color.Black;
                Message.BorderColor = Color.FromArgb(104,104,104);
                Message.ForeColor = Color.Lavender;
                Subject.Theme = MetroFramework.MetroThemeStyle.Dark;
                Subject.Style = MetroFramework.MetroColorStyle.Black;
            }
            else if (Search_Indicator.Visible == true)
            {
                Feedback_Panel.Visible = true;
                Search_Panel.Visible = true;
                Search_Panel.BackColor = Color.Black;
                Search_tb.ForeColor = Color.Lavender;
                Search_tb.BackColor = Color.Black;
                SearchBtn.Image = Properties.Resources.Search_small_dark;
                SearchBtn.BackColor = Color.FromArgb(31, 31, 31);
                Search_lbl.ForeColor = Color.Lavender;
                Search_lbl.BackColor = Color.Black;
                Generic.ForeColor = Color.Lavender;
                Generic.BackColor = Color.Black;
                Brand.ForeColor = Color.Lavender;
                Brand.BackColor = Color.Black;
                Headache.BackColor = Color.FromArgb(31, 31, 31);
                Headache.color = Color.FromArgb(31, 31, 31);
                Headache.colorActive = Color.FromArgb(43, 43, 43);
                Headache.ForeColor = Color.Lavender;
                Cough.BackColor = Color.FromArgb(31, 31, 31);
                Cough.color = Color.FromArgb(31, 31, 31);
                Cough.colorActive = Color.FromArgb(43, 43, 43);
                Cough.ForeColor = Color.Lavender;
                Flu.BackColor = Color.FromArgb(31, 31, 31);
                Flu.color = Color.FromArgb(31, 31, 31);
                Flu.colorActive = Color.FromArgb(43, 43, 43);
                Flu.ForeColor = Color.Lavender;
                Fever.BackColor = Color.FromArgb(31, 31, 31);
                Fever.color = Color.FromArgb(31, 31, 31);
                Fever.colorActive = Color.FromArgb(43, 43, 43);
                Fever.ForeColor = Color.Lavender;
            }
            else if (Disclaimer_Indicator.Visible == true)
            {
                DisclaimerPanel.BackColor = Color.Black;
                DisclaimerPanelIcon.BackgroundImage = Properties.Resources.logo_title;
                DisclaimerLabel.ForeColor = Color.Lavender;
            }
            else if (About_Indicator.Visible == true)
            {
                AboutPanel.BackColor = Color.Black;
                AboutPanelIcon.BackgroundImage = Properties.Resources.logo_title;
                AboutLabel.ForeColor = Color.Lavender;
            }
        }
        private void BottomPanelChangesDarkTheme()
        {
            Bottom_Panel.BackColor = Color.Black;
            Date.ForeColor = Color.Lavender;
            Time.ForeColor = Color.Lavender;
        }
        private void On_switch_Click(object sender, EventArgs e)
        {
            OnSwitch.Visible = false;
            OffSwitch.Visible = true;
            DarkThemeOff();
        }
        private void DarkThemeOff()
            {
                _systemConfigurationService.UpdateTheme(Themes.Light);
                TitlePanelChangesLightTheme();
                HeadingChangesLightTheme();
                SidebarChangesLightTheme();
                BodyChangesLightTheme();
                BottomPanelChangesLightTheme();
            }
        private void TitlePanelChangesLightTheme()
            {
                TitlePanel.BackColor = Color.White;
                title.ForeColor = Color.Black;
                TitleIcon.BackgroundImage = Properties.Resources.logo_title_light;
                Close_Btn.BackgroundImage = Properties.Resources.close_black;
                Minimize.BackgroundImage = Properties.Resources.minimize;
                Minimize.OnHovercolor = Color.FromArgb(242,242,242);
                if (this.WindowState == FormWindowState.Normal)
                {
                    Maximize.BackgroundImage = Properties.Resources.MaximizedState_Light;
                }
                else
                {
                    Maximize.BackgroundImage = Properties.Resources.NormalState_Light;
                }
                Maximize.OnHovercolor = Color.FromArgb(242,242,242);
            }
        private void HeadingChangesLightTheme()
        {
                HeadingLabel.ForeColor = Color.FromArgb(104, 104, 104);
                ThemeToggle.ForeColor = Color.FromArgb(104, 104, 104);
                if (Home_Indicator.Visible == true)
                {
                    Heading.BackColor = Color.FromArgb(229,229,229);
                    HeadingLabel.Text = "PHARMA-Z";
                    HomeDesc.ForeColor = Color.Black;
                    FeedbackDesc.Visible = false;
                    Search_desc.Visible = false;
                    SearchResultDesc.Visible = false;
                    SearchResult_Label.Visible = false;
                    Back_btn.Visible = false;
                }
                else
                {
                    Heading.BackColor = Color.White;
                    if (Feedback_Indicator.Visible == true)
                    {
                        HeadingLabel.Text = "FEEDBACK";
                        FeedbackDesc.Visible = true;
                        FeedbackDesc.ForeColor = Color.Black;
                        Search_desc.Visible = false;
                        SearchResultDesc.Visible = false;
                        SearchResult_Label.Visible = false;
                        Back_btn.Visible = false;
                    }
                    else if (Search_Indicator.Visible == true)
                {
                    if (SearchResult_Label.Visible == true)
                    {
                        SearchResult_Label.ForeColor = Color.FromArgb(104, 104, 104);
                        SearchResultDesc.Visible = true;
                        SearchResultDesc.ForeColor = Color.Black;
                        Back_btn.Visible = true;
                        Back_btn.Normalcolor = Color.White;
                        Back_btn.OnHovercolor = Color.FromArgb(229, 229, 229);
                        Back_btn.Activecolor = Color.FromArgb(229, 229, 229);
                        Back_btn.Iconimage = Properties.Resources.Back_Light;
                        Back_btn.DisabledColor = Color.FromArgb(229, 229, 229);
                    }
                    else
                    {
                        SearchResult_Label.Visible = false;
                        SearchResultDesc.Visible = false;
                        HeadingLabel.Text = "SEARCH";
                        Search_desc.Visible = true;
                        Search_desc.ForeColor = Color.Black;
                        Back_btn.Visible = false;
                    }
                }
                    else if(Disclaimer_Indicator.Visible == true)
                    {
                        HeadingLabel.Text = "Disclaimer";
                        Search_desc.Visible = false;
                        SearchResultDesc.Visible = false;
                        SearchResult_Label.Visible = false;
                        Back_btn.Visible = false;
                    }
                else if (About_Indicator.Visible == true)
                {
                    HeadingLabel.Text = "About";
                    Search_desc.Visible = false;
                    SearchResultDesc.Visible = false;
                    SearchResult_Label.Visible = false;
                    Back_btn.Visible = false;
                }
               
            }   
        }
        private void SidebarChangesLightTheme()
            {
                Sidebar.BackColor = Color.FromArgb(229,229,229);
                SidebarTitle.ForeColor = Color.FromArgb(104, 104, 104);
                MenuBtn.Image = Properties.Resources.menu;
                MenuBtn.BackColor = Color.FromArgb(229,229,229);
                Menu_Expand.Image = Properties.Resources.menu;
                Menu_Expand.BackColor = Color.FromArgb(229,229,229);
                Home.Normalcolor = Color.FromArgb(229,229,229);
                Home.OnHovercolor = Color.FromArgb(242,242,242);
                Home.Activecolor = Color.FromArgb(229,229,229);
                Home.Iconimage = Properties.Resources.Home_Light;
                Back_to_home.Normalcolor = Color.FromArgb(229,229,229);
                Back_to_home.OnHovercolor = Color.FromArgb(242,242,242);
                Back_to_home.Activecolor = Color.FromArgb(229,229,229);
                Back_to_home.Iconimage = Properties.Resources.Back_Light;
                Back_to_home.DisabledColor = Color.FromArgb(229, 229, 229);
                if (Home_Indicator.Visible == true)
                {
                    Home.Textcolor = Color.Black;
                }
                else
                {
                    Home.Textcolor = Color.FromArgb(104, 104, 104);
                }
                Home.OnHoverTextColor = Color.Black;
                Home_Indicator.BackColor = Color.FromArgb(104, 104, 104);
                Search.Normalcolor = Color.FromArgb(229,229,229);
                Search.OnHovercolor = Color.FromArgb(242,242,242);
                Search.Activecolor = Color.FromArgb(229,229,229);
                Search.Iconimage = Properties.Resources.Search_small_light;
                if (Search_Indicator.Visible == true)
                {
                    Search.Textcolor = Color.Black;
                }
                else
                {
                    Search.Textcolor = Color.FromArgb(104, 104, 104);
                }
                Search.OnHoverTextColor = Color.Black;
                Search_Indicator.BackColor = Color.FromArgb(104, 104, 104);
                Recent.Normalcolor = Color.FromArgb(229,229,229);
                Recent.OnHovercolor = Color.FromArgb(242,242,242);
                Recent.Activecolor = Color.FromArgb(229,229,229);
                Recent.Iconimage = Properties.Resources.Recent_small_light;
                if (RecentIndicator.Visible == true)
                {
                    Recent.Textcolor = Color.Black;
                }
                else
                {
                    Recent.Textcolor = Color.FromArgb(104, 104, 104);
                }
                Recent.OnHoverTextColor = Color.Black;
                RecentIndicator.BackColor = Color.FromArgb(104, 104, 104);
                Favorites.Normalcolor = Color.FromArgb(229,229,229);
                Favorites.OnHovercolor = Color.FromArgb(242,242,242);
                Favorites.Activecolor = Color.FromArgb(229,229,229);
                Favorites.Iconimage = Properties.Resources.Favorites_small_light;
                if (FavoritesIndicator.Visible == true)
                {
                    Favorites.Textcolor = Color.Black;
                }
                else
                {
                    Favorites.Textcolor = Color.FromArgb(104, 104, 104);
                }
                Favorites.OnHoverTextColor = Color.Black;
                FavoritesIndicator.BackColor = Color.FromArgb(104, 104, 104);
                Disclaimer.Normalcolor = Color.FromArgb(229,229,229);
                Disclaimer.OnHovercolor = Color.FromArgb(242,242,242);
                Disclaimer.Activecolor = Color.FromArgb(229,229,229);
                Disclaimer.Iconimage = Properties.Resources.Disclaimer_small_light;
                if (Disclaimer_Indicator.Visible == true)
                {
                    Disclaimer.Textcolor = Color.Black;
                }
                else
                {
                    Disclaimer.Textcolor = Color.FromArgb(104, 104, 104);
                }
                Disclaimer.OnHoverTextColor = Color.Black;
                Disclaimer_Indicator.BackColor = Color.FromArgb(104, 104, 104);
                Feedback.Normalcolor = Color.FromArgb(229,229,229);
                Feedback.OnHovercolor = Color.FromArgb(242,242,242);
                Feedback.Activecolor = Color.FromArgb(229,229,229);
                Feedback.Iconimage = Properties.Resources.Feedback_small_light;
                if (Feedback_Indicator.Visible == true)
                {
                    Feedback.Textcolor = Color.Black;
                }
                else
                {
                    Feedback.Textcolor = Color.FromArgb(104, 104, 104);
                }
                Feedback.OnHoverTextColor = Color.Black;
                Feedback_Indicator.BackColor = Color.FromArgb(104, 104, 104);
                About.Normalcolor = Color.FromArgb(229,229,229);
                About.OnHovercolor = Color.FromArgb(242,242,242);
                About.Activecolor = Color.FromArgb(229,229,229);
                About.Iconimage = Properties.Resources.About_small_light;
                if (About_Indicator.Visible == true)
                {
                    About.Textcolor = Color.Black;
                }
                else
                {
                    About.Textcolor = Color.FromArgb(104, 104, 104);
                }
                About.OnHoverTextColor = Color.Black;
                About_Indicator.BackColor = Color.FromArgb(104, 104, 104);
            }
        private void BodyChangesLightTheme()
            {
                this.BackColor = Color.White;
                if (Home_Indicator.Visible == true)
                {
                Body.BackColor = Color.White;
                Search_Tile.BackColor = Color.FromArgb(229,229,229);
                Search_Tile.colorActive = Color.FromArgb(242,242,242);
                Search_Tile.color = Color.FromArgb(229,229,229);
                Search_Tile.Image = Properties.Resources.Search_logo_light;
                Search_Tile.ForeColor = Color.Black;
                Favorites_Tile.BackColor = Color.FromArgb(229,229,229);
                Favorites_Tile.colorActive = Color.FromArgb(242,242,242);
                Favorites_Tile.color = Color.FromArgb(229,229,229);
                Favorites_Tile.Image = Properties.Resources.Favorites_logo_light;
                Favorites_Tile.ForeColor = Color.Black;
                Recent_Tile.colorActive = Color.FromArgb(242,242,242);
                Recent_Tile.BackColor = Color.FromArgb(229,229,229);
                Recent_Tile.color = Color.FromArgb(229,229,229);
                Recent_Tile.Image = Properties.Resources.Recent_logo_light;
                Recent_Tile.ForeColor = Color.Black;
                Feedback_Panel.Visible = false;
                Feedback_Tile.BackColor = Color.FromArgb(229,229,229);
                Feedback_Tile.colorActive = Color.FromArgb(242,242,242);
                Feedback_Tile.color = Color.FromArgb(229,229,229);
                Feedback_Tile.Image = Properties.Resources.Feedback_logo_light;
                Feedback_Tile.ForeColor = Color.Black;
                Disclaimer_Tile.BackColor = Color.FromArgb(229,229,229);
                Disclaimer_Tile.colorActive = Color.FromArgb(242,242,242);
                Disclaimer_Tile.color = Color.FromArgb(229,229,229);
                Disclaimer_Tile.Image = Properties.Resources.Disclaimer_logo_light;
                Disclaimer_Tile.ForeColor = Color.Black;
                About_Tile.BackColor = Color.FromArgb(229,229,229);
                About_Tile.colorActive = Color.FromArgb(242,242,242);
                About_Tile.color = Color.FromArgb(229,229,229);
                About_Tile.Image = Properties.Resources.About_logo_light;
                About_Tile.ForeColor = Color.Black;
                }
                else if (Feedback_Indicator.Visible == true)
                {
                    Feedback_Panel.Visible = true;
                    Search_Panel.Visible = false;
                    Feedback_Panel.BackColor = Color.White;
                    ClientName_Label.ForeColor = Color.Black;
                    ClientName.BorderColorMouseHover = Color.Black;
                    ClientName.BorderColorFocused = Color.Black;
                    ClientName.ForeColor = Color.Black;
                    EmailLbl.ForeColor = Color.Black;
                    Email_tb.BorderColorMouseHover = Color.Black;
                    Email_tb.BorderColorFocused = Color.Black;
                    Email_tb.ForeColor = Color.Black;
                    SubjectLabel.ForeColor = Color.Black;
                    Subject.Theme = MetroFramework.MetroThemeStyle.Light;
                    Subject.Style = MetroFramework.MetroColorStyle.Blue;
                    Message.BorderColor = Color.FromArgb(104, 104, 104);
                    Message.BackColor = Color.White;
                    Message.ForeColor = Color.Black;
                }
                else if (Search_Indicator.Visible == true)
                {
                    Feedback_Panel.Visible = true;
                    Search_Panel.Visible = true;
                    Search_Panel.BackColor = Color.White;
                    SearchBtn.Image = Properties.Resources.Search_small_light;
                    SearchBtn.BackColor = Color.FromArgb(229,229,229);
                    Search_lbl.ForeColor = Color.Black;
                    Search_lbl.BackColor = Color.White;
                    Search_tb.ForeColor = Color.Black;
                    Search_tb.BackColor = Color.White;
                    Generic.ForeColor = Color.Black;
                    Generic.BackColor = Color.White;
                    Brand.ForeColor = Color.Black;
                    Brand.BackColor = Color.White;
                    Headache.BackColor = Color.FromArgb(229,229,229);
                    Headache.color = Color.FromArgb(229,229,229);
                    Headache.colorActive = Color.FromArgb(242,242,242);
                    Headache.ForeColor = Color.Black;
                    Cough.BackColor = Color.FromArgb(229,229,229);
                    Cough.color = Color.FromArgb(229,229,229);
                    Cough.colorActive = Color.FromArgb(242,242,242);
                    Cough.ForeColor = Color.Black;
                    Flu.BackColor = Color.FromArgb(229,229,229);
                    Flu.color = Color.FromArgb(229,229,229);
                    Flu.colorActive = Color.FromArgb(242,242,242);
                    Flu.ForeColor = Color.Black;
                    Fever.BackColor = Color.FromArgb(229,229,229);
                    Fever.color = Color.FromArgb(229,229,229);
                    Fever.colorActive = Color.FromArgb(242,242,242);
                    Fever.ForeColor = Color.Black;
                }
                else if (Disclaimer_Indicator.Visible == true)
                {
                    DisclaimerPanel.BackColor = Color.White;
                    DisclaimerPanelIcon.BackgroundImage = Properties.Resources.logo_title_light;
                    DisclaimerLabel.ForeColor = Color.Black;
                }
            else if (About_Indicator.Visible == true)
            {
                AboutPanel.BackColor = Color.White;
                AboutPanelIcon.BackgroundImage = Properties.Resources.logo_title_light;
                AboutLabel.ForeColor = Color.Black;
            }
        }
        private void BottomPanelChangesLightTheme()
            {
                Bottom_Panel.BackColor = Color.White;
                Date.ForeColor = Color.Black;
                Time.ForeColor = Color.Black;
            }
        private void Menu_Click(object sender, EventArgs e)
        {
            if (Sidebar.Width == 62)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 212;
                MenuBtn.Visible = false;
                PanelAnimator.ShowSync(Sidebar);
                SidebarTitleAnimator.ShowSync(SidebarTitle);
            }
            else
            {
                MenuBtn.Visible = true;
                SidebarTitle.Visible = false;
                Sidebar.Visible = false;
                Sidebar.Width = 62;
                Menu_Expand_Animator.ShowSync(Sidebar);
            }
        }
        private void Home_Click(object sender, EventArgs e)
        {
            HeadingLabel.Text = "PHARMA-Z";
            HomeDesc.Visible = true;
            Feedback_Panel.Visible = false;
            FeedbackDesc.Visible = false;
            Search_desc.Visible = false;
            SearchResult_Label.Visible = false;
            SearchResultDesc.Visible = false;
            Back_btn.Visible = false;
            Back_to_home.Enabled = false;
            DisclaimerPanel.Visible = false;

            if (TitlePanel.BackColor == Color.Black)
            {
                Back_to_home.Normalcolor = Color.FromArgb(31, 31, 31);
                Back_to_home.OnHovercolor = Color.FromArgb(43, 43, 43);
                Back_to_home.Activecolor = Color.FromArgb(31, 31, 31);
                Back_to_home.DisabledColor = Color.FromArgb(31, 31, 31);
                Back_to_home.Iconimage = Properties.Resources.Back_Dark;
                Heading.BackColor = Color.FromArgb(31, 31, 31);
                Home.Textcolor = Color.FromArgb(0,120,215);
                HomeDesc.ForeColor = Color.Lavender;
                Search.Textcolor = Color.Lavender;
                Recent.Textcolor = Color.Lavender;
                Favorites.Textcolor = Color.Lavender;
                Disclaimer.Textcolor = Color.Lavender;
                About.Textcolor = Color.Lavender;
                Feedback.Textcolor = Color.Lavender;
                Body.BackColor = Color.Black;
                Search_Tile.BackColor = Color.FromArgb(31, 31, 31);
                Search_Tile.colorActive = Color.FromArgb(43, 43, 43);
                Search_Tile.color = Color.FromArgb(31, 31, 31);
                Search_Tile.Image = Properties.Resources.Search_logo_dark;
                Search_Tile.ForeColor = Color.Lavender;
                Recent_Tile.BackColor = Color.FromArgb(31, 31, 31);
                Recent_Tile.colorActive = Color.FromArgb(43, 43, 43);
                Recent_Tile.color = Color.FromArgb(31, 31, 31);
                Recent_Tile.Image = Properties.Resources.Recent_logo_dark;
                Recent_Tile.ForeColor = Color.Lavender;
                Favorites_Tile.BackColor = Color.FromArgb(31, 31, 31);
                Favorites_Tile.colorActive = Color.FromArgb(43, 43, 43);
                Favorites_Tile.color = Color.FromArgb(31, 31, 31);
                Favorites_Tile.Image = Properties.Resources.Favorites_logo_dark;
                Favorites_Tile.ForeColor = Color.Lavender;
                Feedback_Panel.Visible = false;
                Feedback_Tile.BackColor = Color.FromArgb(31, 31, 31);
                Feedback_Tile.colorActive = Color.FromArgb(43, 43, 43);
                Feedback_Tile.color = Color.FromArgb(31, 31, 31);
                Feedback_Tile.Image = Properties.Resources.Feedback_logo_dark;
                Feedback_Tile.ForeColor = Color.Lavender;
                Disclaimer_Tile.BackColor = Color.FromArgb(31, 31, 31);
                Disclaimer_Tile.colorActive = Color.FromArgb(43, 43, 43);
                Disclaimer_Tile.color = Color.FromArgb(31, 31, 31);
                Disclaimer_Tile.Image = Properties.Resources.Disclaimer_logo_dark;
                Disclaimer_Tile.ForeColor = Color.Lavender;
                About_Tile.BackColor = Color.FromArgb(31, 31, 31);
                About_Tile.colorActive = Color.FromArgb(43, 43, 43);
                About_Tile.color = Color.FromArgb(31, 31, 31);
                About_Tile.Image = Properties.Resources.About_logo_dark;
                About_Tile.ForeColor = Color.Lavender;
            }
            else
            {
                Back_to_home.Normalcolor = Color.FromArgb(229, 229, 229);
                Back_to_home.OnHovercolor = Color.FromArgb(242, 242, 242);
                Back_to_home.Activecolor = Color.FromArgb(229, 229, 229);
                Back_to_home.Iconimage = Properties.Resources.Back_Light;
                Back_to_home.DisabledColor = Color.FromArgb(229, 229, 229);
                Heading.BackColor = Color.FromArgb(229,229,229);
                Home.Textcolor = Color.Black;
                HomeDesc.ForeColor = Color.Black;
                Body.BackColor = Color.White;
                Search.Textcolor = Color.FromArgb(104,104,104);
                Recent.Textcolor = Color.FromArgb(104, 104, 104);
                Favorites.Textcolor = Color.FromArgb(104, 104, 104);
                Disclaimer.Textcolor = Color.FromArgb(104, 104, 104);
                About.Textcolor = Color.FromArgb(104, 104, 104);
                Feedback.Textcolor = Color.FromArgb(104, 104, 104);
                Body.BackColor = Color.White;
                Search_Tile.BackColor = Color.FromArgb(229,229,229);
                Search_Tile.colorActive = Color.FromArgb(242,242,242);
                Search_Tile.color = Color.FromArgb(229,229,229);
                Search_Tile.Image = Properties.Resources.Search_logo_light;
                Search_Tile.ForeColor = Color.Black;
                Favorites_Tile.BackColor = Color.FromArgb(229,229,229);
                Favorites_Tile.colorActive = Color.FromArgb(242,242,242);
                Favorites_Tile.color = Color.FromArgb(229,229,229);
                Favorites_Tile.Image = Properties.Resources.Favorites_logo_light;
                Favorites_Tile.ForeColor = Color.Black;
                Recent_Tile.colorActive = Color.FromArgb(242,242,242);
                Recent_Tile.BackColor = Color.FromArgb(229,229,229);
                Recent_Tile.color = Color.FromArgb(229,229,229);
                Recent_Tile.Image = Properties.Resources.Recent_logo_light;
                Recent_Tile.ForeColor = Color.Black;
                Feedback_Tile.BackColor = Color.FromArgb(229,229,229);
                Feedback_Tile.colorActive = Color.FromArgb(242,242,242);
                Feedback_Tile.color = Color.FromArgb(229,229,229);
                Feedback_Tile.Image = Properties.Resources.Feedback_logo_light;
                Feedback_Tile.ForeColor = Color.Black;
                Disclaimer_Tile.BackColor = Color.FromArgb(229,229,229);
                Disclaimer_Tile.colorActive = Color.FromArgb(242,242,242);
                Disclaimer_Tile.color = Color.FromArgb(229,229,229);
                Disclaimer_Tile.Image = Properties.Resources.Disclaimer_logo_light;
                Disclaimer_Tile.ForeColor = Color.Black;
                About_Tile.BackColor = Color.FromArgb(229,229,229);
                About_Tile.colorActive = Color.FromArgb(242,242,242);
                About_Tile.color = Color.FromArgb(229,229,229);
                About_Tile.Image = Properties.Resources.About_logo_light;
                About_Tile.ForeColor = Color.Black;
            }
            Home_Indicator.Visible = true;
            Search_Indicator.Visible = false;
            RecentIndicator.Visible = false;
            FavoritesIndicator.Visible = false;
            Disclaimer_Indicator.Visible = false;
            About_Indicator.Visible = false;
            Feedback_Indicator.Visible = false;
        }
        private void Search_Click(object sender, EventArgs e)
        {
            Back_to_home.Enabled = true;
            Home_Indicator.Visible = false;
            Search_Indicator.Visible = true;
            RecentIndicator.Visible = false;
            FavoritesIndicator.Visible = false;
            Disclaimer_Indicator.Visible = false;
            About_Indicator.Visible = false;
            Feedback_Indicator.Visible = false;
            Feedback_Panel.Visible = true;
            DisclaimerPanel.Visible = true;
            AboutPanel.Visible = true;
            SearchResultPanel.Visible = false;
            Search_Panel.Visible = true;
            Search_desc.Visible = true;
            SearchResultDesc.Visible = false;
            if (TitlePanel.BackColor == Color.Black)
            {
                Back_to_home.Normalcolor = Color.FromArgb(31, 31, 31);
                Back_to_home.OnHovercolor = Color.FromArgb(43, 43, 43);
                Back_to_home.Activecolor = Color.FromArgb(31, 31, 31);
                Back_to_home.DisabledColor = Color.FromArgb(31, 31, 31);
                Back_to_home.Iconimage = Properties.Resources.Back_Dark;
                Heading.BackColor = Color.Black;
                HeadingLabel.Text = "SEARCH";
                HeadingLabel.ForeColor = Color.Lavender;
                Search_desc.ForeColor = Color.Lavender;
                Search_Panel.BackColor = Color.Black;
                Search_tb.ForeColor = Color.Lavender;
                SearchBtn.Image = Properties.Resources.Search_small_dark;
                SearchBtn.BackColor = Color.FromArgb(31, 31, 31);
                Search_tb.ForeColor = Color.Lavender;
                Search_tb.BackColor = Color.Black;
                Search_lbl.ForeColor = Color.Lavender;
                Search_lbl.BackColor = Color.Black;
                Generic.ForeColor = Color.Lavender;
                Generic.BackColor = Color.Black;
                Brand.ForeColor = Color.Lavender;
                Brand.BackColor = Color.Black;
                Headache.BackColor = Color.FromArgb(31, 31, 31);
                Headache.color = Color.FromArgb(31, 31, 31);
                Headache.colorActive = Color.FromArgb(43, 43, 43);
                Headache.ForeColor = Color.Lavender;
                Cough.BackColor = Color.FromArgb(31, 31, 31);
                Cough.color = Color.FromArgb(31, 31, 31);
                Cough.colorActive = Color.FromArgb(43, 43, 43);
                Cough.ForeColor = Color.Lavender;
                Flu.BackColor = Color.FromArgb(31, 31, 31);
                Flu.color = Color.FromArgb(31, 31, 31);
                Flu.colorActive = Color.FromArgb(43, 43, 43);
                Flu.ForeColor = Color.Lavender;
                Fever.BackColor = Color.FromArgb(31, 31, 31);
                Fever.color = Color.FromArgb(31, 31, 31);
                Fever.colorActive = Color.FromArgb(43, 43, 43);
                Fever.ForeColor = Color.Lavender;
                Search.Textcolor = Color.FromArgb(0,120,215);
                Home.Textcolor = Color.Lavender;
                Recent.Textcolor = Color.Lavender;
                Favorites.Textcolor = Color.Lavender;
                Disclaimer.Textcolor = Color.Lavender;
                About.Textcolor = Color.Lavender;
                Feedback.Textcolor = Color.Lavender;
            }
            else
            {
                Back_to_home.Normalcolor = Color.FromArgb(229, 229, 229);
                Back_to_home.OnHovercolor = Color.FromArgb(242, 242, 242);
                Back_to_home.Activecolor = Color.FromArgb(229, 229, 229);
                Back_to_home.Iconimage = Properties.Resources.Back_Light;
                Back_to_home.DisabledColor = Color.FromArgb(229, 229, 229);
                Heading.BackColor = Color.White;
                HeadingLabel.Text = "SEARCH";
                HeadingLabel.ForeColor = Color.FromArgb(104,104,104);
                Search_desc.ForeColor = Color.Black;
                Search_Panel.BackColor = Color.White;
                SearchBtn.Image = Properties.Resources.Search_small_light;
                SearchBtn.BackColor = Color.FromArgb(229,229,229);
                Search_tb.ForeColor = Color.Black;
                Search_tb.BackColor = Color.White;
                Search_lbl.ForeColor = Color.Black;
                Search_lbl.BackColor = Color.White;
                Search.Textcolor = Color.Black;
                Generic.ForeColor = Color.Black;
                Generic.BackColor = Color.White;
                Brand.ForeColor = Color.Black;
                Brand.BackColor = Color.White;
                Headache.BackColor = Color.FromArgb(229,229,229);
                Headache.color = Color.FromArgb(229,229,229);
                Headache.colorActive = Color.FromArgb(242,242,242);
                Headache.ForeColor = Color.Black;
                Cough.BackColor = Color.FromArgb(229,229,229);
                Cough.color = Color.FromArgb(229,229,229);
                Cough.colorActive = Color.FromArgb(242,242,242);
                Cough.ForeColor = Color.Black;
                Flu.BackColor = Color.FromArgb(229,229,229);
                Flu.color = Color.FromArgb(229,229,229);
                Flu.colorActive = Color.FromArgb(242,242,242);
                Flu.ForeColor = Color.Black;
                Fever.BackColor = Color.FromArgb(229,229,229);
                Fever.color = Color.FromArgb(229,229,229);
                Fever.colorActive = Color.FromArgb(242,242,242);
                Fever.ForeColor = Color.Black;
                Home.Textcolor = Color.FromArgb(104, 104, 104);
                Recent.Textcolor = Color.FromArgb(104, 104, 104);
                Favorites.Textcolor = Color.FromArgb(104, 104, 104);
                Disclaimer.Textcolor = Color.FromArgb(104, 104, 104);
                About.Textcolor = Color.FromArgb(104, 104, 104);
                Feedback.Textcolor = Color.FromArgb(104, 104, 104);
            }
        }
        private void Recent_Click(object sender, EventArgs e)
        {
            Back_to_home.Enabled = true;
            if (TitlePanel.BackColor == Color.Black)
            {
                Back_to_home.Normalcolor = Color.FromArgb(31, 31, 31);
                Back_to_home.OnHovercolor = Color.FromArgb(43, 43, 43);
                Back_to_home.Activecolor = Color.FromArgb(31, 31, 31);
                Back_to_home.DisabledColor = Color.FromArgb(31, 31, 31);
                Back_to_home.Iconimage = Properties.Resources.Back_Dark;
                Home.Textcolor = Color.Lavender;
                Search.Textcolor = Color.Lavender;
                Recent.Textcolor = Color.FromArgb(0, 120, 215);
                Favorites.Textcolor = Color.Lavender;
                Disclaimer.Textcolor = Color.Lavender;
                About.Textcolor = Color.Lavender;
                Feedback.Textcolor = Color.Lavender;
            }
            else
            {
                Back_to_home.Normalcolor = Color.FromArgb(229, 229, 229);
                Back_to_home.OnHovercolor = Color.FromArgb(242, 242, 242);
                Back_to_home.Activecolor = Color.FromArgb(229, 229, 229);
                Back_to_home.Iconimage = Properties.Resources.Back_Light;
                Back_to_home.DisabledColor = Color.FromArgb(229, 229, 229);
                Recent.Textcolor = Color.Black;
                Search.Textcolor = Color.FromArgb(104, 104, 104);
                Home.Textcolor = Color.FromArgb(104, 104, 104);
                Favorites.Textcolor = Color.FromArgb(104, 104, 104);
                Disclaimer.Textcolor = Color.FromArgb(104, 104, 104);
                About.Textcolor = Color.FromArgb(104, 104, 104);
                Feedback.Textcolor = Color.FromArgb(104, 104, 104);
            }
            Home_Indicator.Visible = false;
            Search_Indicator.Visible = false;
            RecentIndicator.Visible = true;
            FavoritesIndicator.Visible = false;
            Disclaimer_Indicator.Visible = false;
            About_Indicator.Visible = false;
            Feedback_Indicator.Visible = false;
        }
        private void Favorites_Click(object sender, EventArgs e)
        {
            Back_to_home.Enabled = true;
            if (TitlePanel.BackColor == Color.Black)
            {
                Back_to_home.Normalcolor = Color.FromArgb(31, 31, 31);
                Back_to_home.OnHovercolor = Color.FromArgb(43, 43, 43);
                Back_to_home.Activecolor = Color.FromArgb(31, 31, 31);
                Back_to_home.DisabledColor = Color.FromArgb(31, 31, 31);
                Back_to_home.Iconimage = Properties.Resources.Back_Dark;
                Home.Textcolor = Color.Lavender;
                Favorites.Textcolor = Color.FromArgb(0, 120, 215);
                Recent.Textcolor = Color.Lavender;
                Search.Textcolor = Color.Lavender;
                Disclaimer.Textcolor = Color.Lavender;
                About.Textcolor = Color.Lavender;
                Feedback.Textcolor = Color.Lavender;
            }
            else
            {
                Back_to_home.Normalcolor = Color.FromArgb(229, 229, 229);
                Back_to_home.OnHovercolor = Color.FromArgb(242, 242, 242);
                Back_to_home.Activecolor = Color.FromArgb(229, 229, 229);
                Back_to_home.Iconimage = Properties.Resources.Back_Light;
                Back_to_home.DisabledColor = Color.FromArgb(229, 229, 229);
                Favorites.Textcolor = Color.Black;
                Search.Textcolor = Color.FromArgb(104, 104, 104);
                Recent.Textcolor = Color.FromArgb(104, 104, 104);
                Home.Textcolor = Color.FromArgb(104, 104, 104);
                Disclaimer.Textcolor = Color.FromArgb(104, 104, 104);
                About.Textcolor = Color.FromArgb(104, 104, 104);
                Feedback.Textcolor = Color.FromArgb(104, 104, 104);
            }
            Home_Indicator.Visible = false;
            Search_Indicator.Visible = false;
            RecentIndicator.Visible = false;
            FavoritesIndicator.Visible = true;
            Disclaimer_Indicator.Visible = false;
            About_Indicator.Visible = false;
            Feedback_Indicator.Visible = false;
        }
        private void Disclaimer_Click(object sender, EventArgs e)
        {
            Back_to_home.Enabled = true;
            Back_btn.Visible = false;
            HeadingLabel.Text = "Disclaimer";
            Feedback_Panel.Visible = true;
            Body.Visible = true;
            Search_Panel.Visible = true;
            DisclaimerPanel.Visible = true;
            AboutPanel.Visible = false;
            HomeDesc.Visible = false;
            SearchResultDesc.Visible = false;
            Search_desc.Visible = false;
            FeedbackDesc.Visible = false;
            SearchResult_Label.Visible = false;
            SearchResultDesc.Visible = false;
            if (TitlePanel.BackColor == Color.Black)
            {
                Back_to_home.Normalcolor = Color.FromArgb(31, 31, 31);
                Back_to_home.OnHovercolor = Color.FromArgb(43, 43, 43);
                Back_to_home.Activecolor = Color.FromArgb(31, 31, 31);
                Back_to_home.DisabledColor = Color.FromArgb(31, 31, 31);
                Back_to_home.Iconimage = Properties.Resources.Back_Dark;
                Home.Textcolor = Color.Lavender;
                Disclaimer.Textcolor = Color.FromArgb(0, 120, 215);
                Recent.Textcolor = Color.Lavender;
                Favorites.Textcolor = Color.Lavender;
                Search.Textcolor = Color.Lavender;
                About.Textcolor = Color.Lavender;
                Feedback.Textcolor = Color.Lavender;
                DisclaimerLabel.ForeColor = Color.Lavender;
                DisclaimerPanel.BackColor = Color.Black;
                DisclaimerPanelIcon.BackgroundImage = Properties.Resources.logo_title;
            }
            else
            {
                Back_to_home.Normalcolor = Color.FromArgb(229, 229, 229);
                Back_to_home.OnHovercolor = Color.FromArgb(242, 242, 242);
                Back_to_home.Activecolor = Color.FromArgb(229, 229, 229);
                Back_to_home.Iconimage = Properties.Resources.Back_Light;
                Back_to_home.DisabledColor = Color.FromArgb(229, 229, 229);
                Disclaimer.Textcolor = Color.Black;
                Search.Textcolor = Color.FromArgb(104, 104, 104);
                Recent.Textcolor = Color.FromArgb(104, 104, 104);
                Favorites.Textcolor = Color.FromArgb(104, 104, 104);
                Home.Textcolor = Color.FromArgb(104, 104, 104);
                About.Textcolor = Color.FromArgb(104, 104, 104);
                Feedback.Textcolor = Color.FromArgb(104, 104, 104);
                DisclaimerLabel.ForeColor = Color.Black;
                DisclaimerPanel.BackColor = Color.White;
                DisclaimerPanelIcon.BackgroundImage = Properties.Resources.logo_title_light; 
            }
            Home_Indicator.Visible = false;
            Search_Indicator.Visible = false;
            RecentIndicator.Visible = false;
            FavoritesIndicator.Visible = false;
            Disclaimer_Indicator.Visible = true;
            About_Indicator.Visible = false;
            Feedback_Indicator.Visible = false;
        }
        private void About_Click(object sender, EventArgs e)
        {
            Back_to_home.Enabled = true;
            if (TitlePanel.BackColor == Color.Black)
            {
                Back_to_home.Normalcolor = Color.FromArgb(31, 31, 31);
                Back_to_home.OnHovercolor = Color.FromArgb(43, 43, 43);
                Back_to_home.Activecolor = Color.FromArgb(31, 31, 31);
                Back_to_home.DisabledColor = Color.FromArgb(31, 31, 31);
                Back_to_home.Iconimage = Properties.Resources.Back_Dark;
                Home.Textcolor = Color.Lavender;
                About.Textcolor = Color.FromArgb(0, 120, 215);
                Recent.Textcolor = Color.Lavender;
                Favorites.Textcolor = Color.Lavender;
                Disclaimer.Textcolor = Color.Lavender;
                Search.Textcolor = Color.Lavender;
                Feedback.Textcolor = Color.Lavender;
                AboutLabel.ForeColor = Color.Lavender;
                AboutPanel.BackColor = Color.Black;
                AboutPanelIcon.BackgroundImage = Properties.Resources.logo_title;
            }
            else
            {
                Back_to_home.Normalcolor = Color.FromArgb(229, 229, 229);
                Back_to_home.OnHovercolor = Color.FromArgb(242, 242, 242);
                Back_to_home.Activecolor = Color.FromArgb(229, 229, 229);
                Back_to_home.Iconimage = Properties.Resources.Back_Light;
                Back_to_home.DisabledColor = Color.FromArgb(229, 229, 229);
                About.Textcolor = Color.Black;
                Search.Textcolor = Color.FromArgb(104, 104, 104);
                Recent.Textcolor = Color.FromArgb(104, 104, 104);
                Favorites.Textcolor = Color.FromArgb(104, 104, 104);
                Disclaimer.Textcolor = Color.FromArgb(104, 104, 104);
                Home.Textcolor = Color.FromArgb(104, 104, 104);
                Feedback.Textcolor = Color.FromArgb(104, 104, 104);
                AboutLabel.ForeColor = Color.Black;
                AboutPanel.BackColor = Color.White;
                AboutPanelIcon.BackgroundImage = Properties.Resources.logo_title_light;
            }
            Back_btn.Visible = false;
            AboutPanel.Visible = true;
            HeadingLabel.Text = "About";
            Feedback_Panel.Visible = true;
            Body.Visible = true;
            Search_Panel.Visible = false;
            DisclaimerPanel.Visible = true;
            HomeDesc.Visible = false;
            Search_desc.Visible = false;
            SearchResult_Label.Visible = false;
            SearchResultDesc.Visible = false;
            FeedbackDesc.Visible = false;
            Home_Indicator.Visible = false;
            Search_Indicator.Visible = false;
            RecentIndicator.Visible = false;
            FavoritesIndicator.Visible = false;
            Disclaimer_Indicator.Visible = false;
            About_Indicator.Visible = true;
            Feedback_Indicator.Visible = false;
        }
        private void Feedback_Click(object sender, EventArgs e)
        {
            Back_to_home.Enabled = true;
            Back_btn.Visible = false;
            Home_Indicator.Visible = false;
            Search_Indicator.Visible = false;
            Search_Panel.Visible = false;
            RecentIndicator.Visible = false;
            FavoritesIndicator.Visible = false;
            Disclaimer_Indicator.Visible = false;
            About_Indicator.Visible = false;
            Feedback_Indicator.Visible = true;
            SearchResult_Label.Visible = false;
            SearchResultDesc.Visible = false;
            FeedbackDesc.Visible = true;
            Search_desc.Visible = false;
            Feedback_Panel.Visible = true;
            DisclaimerPanel.Visible = false;
            if (TitlePanel.BackColor == Color.Black)
            {
                Back_to_home.Normalcolor = Color.FromArgb(31, 31, 31);
                Back_to_home.OnHovercolor = Color.FromArgb(43, 43, 43);
                Back_to_home.Activecolor = Color.FromArgb(31, 31, 31);
                Back_to_home.DisabledColor = Color.FromArgb(31, 31, 31);
                Back_to_home.Iconimage = Properties.Resources.Back_Dark;
                Home.Textcolor = Color.Lavender;
                Recent.Textcolor = Color.Lavender;
                Favorites.Textcolor = Color.Lavender;
                Disclaimer.Textcolor = Color.Lavender;
                Search.Textcolor = Color.Lavender;
                About.Textcolor = Color.Lavender;
                Feedback.Textcolor = Color.FromArgb(0, 120, 215);
                Feedback_Panel.BackColor = Color.Black;
                FeedbackDesc.ForeColor = Color.Lavender;
                HeadingLabel.Text = "FEEDBACK";
                HeadingLabel.ForeColor = Color.Lavender;
                Heading.BackColor = Color.Black;
                FeedbackDesc.ForeColor = Color.Lavender;
                ClientName_Label.ForeColor = Color.Lavender;
                ClientName.BorderColorMouseHover = Color.FromArgb(0,120,215);
                ClientName.BorderColorFocused = Color.FromArgb(0,120,215);
                ClientName.ForeColor = Color.Lavender;
                EmailLbl.ForeColor = Color.Lavender;
                Email_tb.BorderColorMouseHover = Color.FromArgb(0, 120, 215);
                Email_tb.BorderColorFocused = Color.FromArgb(0, 120, 215);
                Email_tb.ForeColor = Color.Lavender;
                SubjectLabel.ForeColor = Color.Lavender;
                Subject.Theme = MetroFramework.MetroThemeStyle.Dark;
                Subject.Style = MetroFramework.MetroColorStyle.Black;
                Message.BorderColor = Color.FromArgb(104, 104, 104);
                Message.ForeColor = Color.Lavender;
                Message.BackColor = Color.Black;
            }
            else
            {
                Back_to_home.Normalcolor = Color.FromArgb(229, 229, 229);
                Back_to_home.OnHovercolor = Color.FromArgb(242, 242, 242);
                Back_to_home.Activecolor = Color.FromArgb(229, 229, 229);
                Back_to_home.Iconimage = Properties.Resources.Back_Light;
                Back_to_home.DisabledColor = Color.FromArgb(229, 229, 229);
                Search.Textcolor = Color.FromArgb(104, 104, 104);
                Recent.Textcolor = Color.FromArgb(104, 104, 104);
                Favorites.Textcolor = Color.FromArgb(104, 104, 104);
                Disclaimer.Textcolor = Color.FromArgb(104, 104, 104);
                Home.Textcolor = Color.FromArgb(104, 104, 104);
                About.Textcolor = Color.FromArgb(104, 104, 104);
                Feedback.Textcolor = Color.Black;
                Feedback_Panel.BackColor = Color.White;
                FeedbackDesc.ForeColor = Color.Black;
                HeadingLabel.Text = "FEEDBACK";
                HeadingLabel.ForeColor = Color.FromArgb(104,104,104);
                Heading.BackColor = Color.White;
                ClientName_Label.ForeColor = Color.Black;
                ClientName.BorderColorMouseHover = Color.Black;
                ClientName.BorderColorFocused = Color.Black;
                ClientName.ForeColor = Color.Black;
                EmailLbl.ForeColor = Color.Black;
                Email_tb.BorderColorMouseHover = Color.Black;
                Email_tb.BorderColorFocused = Color.Black;
                Email_tb.ForeColor = Color.Black;
                SubjectLabel.ForeColor = Color.Black;
                Subject.Theme = MetroFramework.MetroThemeStyle.Light;
                Subject.Style = MetroFramework.MetroColorStyle.Blue;
                Message.BorderColor = Color.FromArgb(104, 104, 104);
                Message.BackColor = Color.White;
                Message.ForeColor = Color.Black;
            }
        }
        private void Message_Click(object sender, EventArgs e)
        {
            if (TitlePanel.BackColor == Color.Black)
            {
                Message.BorderColor = Color.FromArgb(0, 120, 215);
            }
            if (TitlePanel.BackColor == Color.White)
            {
                Message.BorderColor = Color.FromArgb(104,104,104);
            }
            if (Message.Text == "Enter Your Message Here.")
            {
                Message.Text = "";
            }
        }
        private void Send_Click(object sender, EventArgs e)
        {
            try
            {
                    var feedback = GlobalConfiguration.Feedback;
                MailMessage msg = new MailMessage
                {
                    From = new MailAddress(feedback.EmailFrom)
                };
                msg.To.Add(new MailAddress(feedback.EmailTo));
                    msg.Subject = ClientName.Text.Trim() + " (" + Subject.SelectedItem.ToString() + ")";
                    msg.Body = ClientName.Text.Trim() + " (" + Email_tb.Text + ") says, " + Message.Text.Trim();
                SmtpClient smtp = new SmtpClient
                {
                    Port = 587,
                    Host = "smtp.outlook.com",
                    EnableSsl = true,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(feedback.EmailFrom, feedback.Pwd)
                };
                smtp.SendAsync(msg,new object());
                    MessageBox.Show("We have received your feedback! 👍", "Success");
                    ClientName.ResetText();
                    Email_tb.ResetText();
                    Message.ResetText();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        private void Back_btn_Click(object sender, EventArgs e)
        {
                SearchResultPanel.Visible = false;
                SearchResult_Label.Visible = false;
                SearchResultDesc.Visible = false;
                Feedback_Panel.Visible = true;
                DisclaimerPanel.Visible = true;
                AboutPanel.Visible = true;
                Search_Panel.Visible = true;
                HeadingLabel.Text = "SEARCH";
                Search_desc.Visible = true;
                Search_tb.Visible = true;
                Search_tb.ResetText();
                Back_btn.Visible = false;
                HomeDesc.Visible = false;
            if (TitlePanel.BackColor == Color.Black)
            {
                Search_desc.ForeColor = Color.Lavender;
            }
            else
            {
                Search_desc.ForeColor = Color.Black;
            }
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        //private void Generic_Click(object sender, EventArgs e)
        //{
        //    Search_tb.Text = "Search for Generic Medicine";
        //}

        //private void Brand_Click(object sender, EventArgs e)
        //{
        //    Search_tb.Text = "Search for Brand";
        //}

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Body.Visible = true;
            Feedback_Panel.Visible = true;
            Search_Panel.Visible = true;
            DisclaimerPanel.Visible = true;
            AboutPanel.Visible = true;
            SearchResult_Label.Visible = true;
            SearchResult_Label.Text = "Your Search Result";
            SearchResultDesc.Visible = false;
            Search_desc.Visible = false;
            FeedbackDesc.Visible = false;
            HomeDesc.Visible = false;
            Back_btn.Visible = true;
            Search_tb.Visible = false;
            if (Generic.Checked == true)
            {
                _generic.Name = Search_tb.Text;
                _generic.Id = _genericService.GetGenericId(_generic);
                if (_generic.Id == 0)
                {
                    MessageBox.Show("Please Check The Spellings before clicking Search");
                }
                else
                {
                SearchResultPanel.Visible = true;
                var dtSource = _genericService.GetGeneric(_generic.Id);
                SearchResultGrid.DataSource = dtSource;
                }
            } 
            else if (Brand.Checked == true)
            {
                _brand.BrandName = Search_tb.Text;
                _brand.BrandId = _brandService.GetBrandId(_brand);
                if (_brand.BrandId == 0)
                {
                    MessageBox.Show("Please Check The Spellings before clicking Search");
                }
                else
                {
                    SearchResultPanel.Visible = true;
                    var dtSource = _brandService.GetBrand(_brand.BrandId);
                    SearchResultGrid.DataSource = dtSource;
                }
            }
            if (TitlePanel.BackColor == Color.Black)
            {
                SearchResult_Label.ForeColor = Color.Lavender;
                Back_btn.Normalcolor = Color.FromArgb(31, 31, 31);
                Back_btn.OnHovercolor = Color.FromArgb(43, 43, 43);
                Back_btn.Activecolor = Color.FromArgb(31, 31, 31);
                Back_btn.DisabledColor = Color.FromArgb(31, 31, 31);
                Back_btn.Iconimage = Properties.Resources.Back_Dark;
            }
            else
            {
                SearchResult_Label.ForeColor = Color.FromArgb(104, 104, 104);
                Back_btn.Normalcolor = Color.FromArgb(229, 229, 229);
                Back_btn.OnHovercolor = Color.FromArgb(242, 242, 242);
                Back_btn.Activecolor = Color.FromArgb(229, 229, 229);
                Back_btn.Iconimage = Properties.Resources.Back_Light;
                Back_btn.DisabledColor = Color.FromArgb(229, 229, 229);
            }
        }

        private void Headache_Click(object sender, EventArgs e)
        {
            Body.Visible = true;
            Feedback_Panel.Visible = true;
            Search_Panel.Visible = true;
            DisclaimerPanel.Visible = true;
            AboutPanel.Visible = true;
            SearchResultPanel.Visible = true;
            SearchResult_Label.Visible = true;
            SearchResultDesc.Visible = true;
            Search_desc.Visible = false;
            FeedbackDesc.Visible = false;
            HomeDesc.Visible = false;
            Back_btn.Visible = true;
            var dtsource = _headacheMedicineService.GetHeadacheMedicines();
            SearchResultGrid.DataSource = dtsource;
            if (TitlePanel.BackColor == Color.Black)
            {
                SearchResult_Label.ForeColor = Color.Lavender;
                SearchResultDesc.ForeColor = Color.Lavender;
                Back_btn.Normalcolor = Color.Black;
                Back_btn.OnHovercolor = Color.FromArgb(31, 31, 31);
                Back_btn.Activecolor = Color.FromArgb(31, 31, 31);
                Back_btn.DisabledColor = Color.Black;
                Back_btn.Iconimage = Properties.Resources.Back_Dark;
            }
            else
            {
                SearchResult_Label.ForeColor = Color.FromArgb(104,104,104);
                SearchResultDesc.ForeColor = Color.Black;
                Back_btn.Normalcolor = Color.White;
                Back_btn.OnHovercolor = Color.FromArgb(229, 229, 229);
                Back_btn.Activecolor = Color.FromArgb(229, 229, 229);
                Back_btn.Iconimage = Properties.Resources.Back_Light;
                Back_btn.DisabledColor = Color.FromArgb(229, 229, 229);
            }
        }
        void AutoComplete()
        {
            Search_tb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Search_tb.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void Search_tb_TextChanged(object sender, EventArgs e)
        {
            if (Brand.Checked == true)
            {
                _coll.AddRange(_brandService.GetBrandNames().ToArray());
            }
            else if (Generic.Checked == true)
            {
                _coll.AddRange(_genericService.GetGenericNames().ToArray());
            }
            Search_tb.AutoCompleteCustomSource = _coll;
        }
    }
}