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
    public partial class FrmQuanLyLH_Main : Form
    {
        public Class selectedUser;
        private BLLClass bLLUser;
        public FrmQuanLyLH_Main()
        {
            InitializeComponent();
        }

        public void FrmQuanLyUser_Main_Load(object sender, EventArgs e)
        {
            this.bLLUser = new BLLClass(Main.Instance.classDataPath);
            ShowListUser(bLLUser);
        }

        public void ShowListUser(BLLClass bLLUser)
        {
            var bindingList = new BindingList<Class>(bLLUser.classDao.ListClass);
            var source = new BindingSource(bindingList, null);
            this.dgvUser.DataSource = source;
        }

        private void ActionQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActionAdd_Click(object sender, EventArgs e)
        {
            FrmQuanLyLH_Modifiles frmThem = new FrmQuanLyLH_Modifiles(this);
            frmThem.isEditting = false;
            frmThem.ShowDialog();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUser.CurrentRow == null)
            {
                return;
            }

            long userID = Convert.ToInt64(dgvUser[0, dgvUser.CurrentRow.Index].Value);
            selectedUser = bLLUser.classDao.GetClassByID(userID);
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

            FrmQuanLyLH_Modifiles frmQuanLyUser = new FrmQuanLyLH_Modifiles(this);
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
            bLLUser.classDao.DeleteClass(selectedUser);
            ShowListUser(bLLUser);
            //Refresh();
        }

        private void OnDataSourceChange()
        {

        }
    }
}