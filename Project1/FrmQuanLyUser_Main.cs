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
    public partial class FrmQuanLyUser_Main : Form
    {
        public FrmQuanLyUser_Main()
        {
            InitializeComponent();
        }

        private void FrmQuanLyUser_Main_Load(object sender, EventArgs e)
        {
           
           // FrmQuanLyUser_Main frmQuanlyNguoiDung = new FrmQuanLyUser_Main();
            //frmQuanlyNguoiDung.ShowDialog();
        }

        private void ActionQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActionAdd_Click(object sender, EventArgs e)
        {
            FrmQuanLyUser_Modifiles frmThem = new FrmQuanLyUser_Modifiles();
            frmThem.isEditting = true;
            frmThem.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
