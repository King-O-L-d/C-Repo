﻿using Project1.BusinessLayer;
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
    public partial class FrmQuanLySV_Main : Form
    {
        public User selectedUser;
        private BLLUser bLLUser;
        public FrmQuanLySV_Main()
        {
            InitializeComponent();
        }

        public void FrmQuanLyUser_Main_Load(object sender, EventArgs e)
        {
            this.bLLUser = new BLLUser(Main.Instance.userDataPath);
            ShowListUser(bLLUser);
        }

        public void ShowListUser(BLLUser bLLUser)
        {
            var bindingList = new BindingList<User>(bLLUser.userDao.ListUser);
            var source = new BindingSource(bindingList, null);
            this.dgvUser.DataSource = source;
        }

        private void ActionQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActionAdd_Click(object sender, EventArgs e)
        {
            FrmQuanLySV_Modifiles frmThem = new FrmQuanLySV_Modifiles(this);
            frmThem.isEditting = false;
            frmThem.ShowDialog();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            long userID = Convert.ToInt64(dgvUser[0, dgvUser.CurrentRow.Index].Value);

            selectedUser = bLLUser.userDao.GetUserByID(userID);

        }

        private void toolStripNapLai_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        public override void Refresh()
        {
            base.Refresh();
            selectedUser = null;
            this.Controls.Clear();
            InitializeComponent();
            FrmQuanLyUser_Main_Load(this, new EventArgs());
        }

        private void actionUpdate_Click(object sender, EventArgs e)
        {
            if (selectedUser == null)
            {
                MessageBox.Show("Hãy chọn 1 user");
                return;
            }

            FrmQuanLySV_Modifiles frmQuanLyUser = new FrmQuanLySV_Modifiles(this);
            frmQuanLyUser.isEditting = true;
            frmQuanLyUser.SetData(selectedUser);
            frmQuanLyUser.ShowDialog();
        }

        private void actionDelete_Click(object sender, EventArgs e)
        {
            if (selectedUser == null)
            {
                MessageBox.Show("Hãy chọn 1 user");
                return;
            }
            dgvUser.DataSource = null;
            bLLUser.userDao.DeleteUser(selectedUser);
            ShowListUser(bLLUser);
            //Refresh();
        }

        private void OnDataSourceChange()
        {

        }
    }
}