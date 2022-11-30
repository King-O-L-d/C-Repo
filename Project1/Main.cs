using Project1.Data_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Main : Form
    {
        public static Main Instance;
        private User currentUser;
        public string userDataPath { get; private set; }
        public string classDataPath { get; private set; }
        public string userDataCachePath { get; private set; }
        bool isSystemMenuCollapse = false;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Instance = this;
            userDataPath = string.Format(@"{0}/user.init", Application.StartupPath);
            classDataPath = string.Format(@"{0}/class.init", Application.StartupPath);
            userDataCachePath = string.Format(@"{0}/userCache.init", Application.StartupPath);
            LoadFormLogin();
        }

        private void LoadFormLogin()
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();

        }

        private void LoadFormQLSV()
        {
           FrmQuanLySV_Main frmQuanLySV = new FrmQuanLySV_Main();
            frmQuanLySV.ShowDialog();
        }

        private void LoadFormQLLH()
        {
            FrmQuanLyLH_Main frmQuanLyLH_Main = new FrmQuanLyLH_Main();
            frmQuanLyLH_Main.ShowDialog();
        }

        public void SetUserInfo(User user)
        {
            currentUser = user;
        }


        private void titleText_TextChanged(object sender, EventArgs e)
        {

        }

        

   

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoadFormLogin();
        }

        private void changePassButton_Click(object sender, EventArgs e)
        {
            Frm_ChangePassword userControl1 = new Frm_ChangePassword(currentUser);
            AddTab("Đổi mật khẩu", userControl1);
            //frmQuanLyUser.ShowDialog();
        }

        private void AddTab(string tabName, Control control)
        {
            TabPage page = new TabPage(tabName);
            page.Controls.Add(control);
            tabControl.TabPages.Add(page);
        }

        private void resultTab_Click(object sender, EventArgs e)
        {

        }

        public void CloseTab()
        {
            tabControl.TabPages.Remove(tabControl.SelectedTab);
        }

        

        private void manageUserButton_Click(object sender, EventArgs e)
        {
            LoadFormQLSV();
        }

        private void menuSystemDropdown_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void manageClassButton_Click(object sender, EventArgs e)
        {
            LoadFormQLLH();
        }
    }
}
