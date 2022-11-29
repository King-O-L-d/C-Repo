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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project1
{
    public partial class Frm_ChangePassword : UserControl
    {
        private User user;
        BLLUser bLLUser = new BLLUser(Main.Instance.userDataPath);
        public Frm_ChangePassword(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void Frm_ChangePassword_Load(object sender, EventArgs e)
        {
            usernameText.Text = user.TaiKhoan;
            
        }

        private void labelChangePass_Click(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (passwordText.Text == "")
            {
                MessageBox.Show("Không hợp lệ");
                return;
            }
            if (passwordText.Text != confirmPasswordText.Text)
            {
                MessageBox.Show("Mật khẩu không khớp");
                return;
            }
            user.TaiKhoan = this.usernameText.Text;
            user.MatKhau = this.passwordText.Text;

            int userIndex = bLLUser.userDao.GetUserIndexByID(user.ID);
            bLLUser.userDao.EditUser(user, userIndex);

            MessageBoxButtons boxButtons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show("Đổi mật khẩu thành công", "Message" , boxButtons);
            if (result == DialogResult.OK)
            {
                Console.WriteLine("jajaj");
                Main.Instance.CloseTab();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Main.Instance.CloseTab();
        }
    }
}
