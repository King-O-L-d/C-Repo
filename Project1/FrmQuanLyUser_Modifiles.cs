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
    public partial class FrmQuanLyUser_Modifiles : Form
    {
        public bool isEditting = false;
        public FrmQuanLyUser_Modifiles()
        {
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
            this.titleText.Text = "Sửa người dùng";
        }

        private void Adding()
        {
            this.titleText.Text = "Thêm người dùng";
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {

        }
    }
}
