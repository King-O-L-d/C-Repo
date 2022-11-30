using Project1.BusinessLayer;
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
    public partial class FrmQuanLyLH_Modifiles : Form
    {
        FrmQuanLyLH_Main data;
        public bool isEditting = false;
        BLLClass bLLUser = new BLLClass(Main.Instance.classDataPath);
        public FrmQuanLyLH_Modifiles(FrmQuanLyLH_Main data = null)
        {
            this.data = data;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmQuanLyUser_Modifiles_Load(object sender, EventArgs e)
        {
            if (isEditting)
            {
                Editting();
            }
            else
            {
                Adding();
            }
        }

        private void Editting()
        {
            this.titleText.Text = "Sửa lớp";
        }

        public void SetData(Class user)
        {
            if (user == null)
                return;

            this.textID.Text = user.GetId().ToString();
            this.textUserName.Text = user.GetTenLop();
            this.textUserName.Text = user.GetSiSo().ToString();
        }

        private void Adding()
        {
            this.titleText.Text = "Thêm lớp";
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            Class user = new Class();
            user.SetTenLop(this.textUserName.Text) ;

            if (isEditting)
            {
                //int userIndex = bLLUser.userDao.GetUserIndexByID(user.ID);
               // bLLUser.userDao.EditUser(user, userIndex);
            }
            else
            {
                bLLUser.classDao.AddClass(user);
            }

            if (this.data != null)
            {
                data.Refresh();
            }

            this.Close();
        }
    }
}
