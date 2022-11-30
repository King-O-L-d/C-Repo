namespace Project1
{
    partial class FrmQuanLyLH_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        
          /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyLH_Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripNapLai = new System.Windows.Forms.ToolStripButton();
            this.actionAdd = new System.Windows.Forms.ToolStripButton();
            this.actionUpdate = new System.Windows.Forms.ToolStripButton();
            this.actionDelete = new System.Windows.Forms.ToolStripButton();
            this.actionQuit = new System.Windows.Forms.ToolStripLabel();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSiSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgvUser = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(dgvUser)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUser
            // 
            dgvUser.AllowUserToAddRows = false;
            dgvUser.AllowUserToDeleteRows = false;
            dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvUser.BackgroundColor = System.Drawing.Color.Azure;
            dgvUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colTenLop,
            this.colSiSo});
            dgvUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            dgvUser.Location = new System.Drawing.Point(0, 28);
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.RowHeadersWidth = 51;
            dgvUser.Size = new System.Drawing.Size(800, 422);
            dgvUser.TabIndex = 2;
            dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellContentClick);
            dgvUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellContentClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNapLai,
            this.actionAdd,
            this.actionUpdate,
            this.actionDelete,
            this.actionQuit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "Nạp Lại";
            // 
            // toolStripNapLai
            // 
            this.toolStripNapLai.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNapLai.Image")));
            this.toolStripNapLai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNapLai.Name = "toolStripNapLai";
            this.toolStripNapLai.Size = new System.Drawing.Size(65, 22);
            this.toolStripNapLai.Text = "Nạp lại";
            this.toolStripNapLai.Click += new System.EventHandler(this.toolStripNapLai_Click);
            // 
            // actionAdd
            // 
            this.actionAdd.Image = ((System.Drawing.Image)(resources.GetObject("actionAdd.Image")));
            this.actionAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.actionAdd.Name = "actionAdd";
            this.actionAdd.Size = new System.Drawing.Size(58, 22);
            this.actionAdd.Text = "Thêm";
            this.actionAdd.Click += new System.EventHandler(this.ActionAdd_Click);
            // 
            // actionUpdate
            // 
            this.actionUpdate.Image = ((System.Drawing.Image)(resources.GetObject("actionUpdate.Image")));
            this.actionUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.actionUpdate.Name = "actionUpdate";
            this.actionUpdate.Size = new System.Drawing.Size(47, 22);
            this.actionUpdate.Text = "Sửa";
            this.actionUpdate.Click += new System.EventHandler(this.actionUpdate_Click);
            // 
            // actionDelete
            // 
            this.actionDelete.Image = ((System.Drawing.Image)(resources.GetObject("actionDelete.Image")));
            this.actionDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.actionDelete.Name = "actionDelete";
            this.actionDelete.Size = new System.Drawing.Size(48, 22);
            this.actionDelete.Text = "Xóa";
            this.actionDelete.Click += new System.EventHandler(this.actionDelete_Click);
            // 
            // actionQuit
            // 
            this.actionQuit.Name = "actionQuit";
            this.actionQuit.Size = new System.Drawing.Size(37, 22);
            this.actionQuit.Text = "Thoát";
            this.actionQuit.Click += new System.EventHandler(this.ActionQuit_Click);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "ID";
            this.colId.FillWeight = 9.963343F;
            this.colId.HeaderText = "Id";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colTenLop
            // 
            this.colTenLop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colTenLop.DataPropertyName = "Tên lớp";
            this.colTenLop.HeaderText = "Tên lớp";
            this.colTenLop.MinimumWidth = 450;
            this.colTenLop.Name = "colTenLop";
            this.colTenLop.ReadOnly = true;
            this.colTenLop.Width = 450;
            // 
            // colSiSo
            // 
            this.colSiSo.DataPropertyName = "MatKhau";
            this.colSiSo.FillWeight = 54.30022F;
            this.colSiSo.HeaderText = "Sỉ số";
            this.colSiSo.MinimumWidth = 6;
            this.colSiSo.Name = "colSiSo";
            this.colSiSo.ReadOnly = true;
            // 
            // FrmQuanLyLH_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(dgvUser);
            this.Name = "FrmQuanLyLH_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quan Ly Lop Hoc";
            this.Load += new System.EventHandler(this.FrmQuanLyUser_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(dgvUser)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripNapLai;
        private System.Windows.Forms.ToolStripButton actionAdd;
        private System.Windows.Forms.ToolStripButton actionUpdate;
        private System.Windows.Forms.ToolStripButton actionDelete;
        private System.Windows.Forms.ToolStripLabel actionQuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSiSo;
        System.Windows.Forms.DataGridView dgvUser;

    }
}
