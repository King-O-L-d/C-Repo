namespace Project1
{
    partial class FrmQuanLyLH_Modifiles
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtId = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.titleText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(126, 94);
            this.txtId.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.txtId.Name = "txtId";
            this.txtId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtId.Size = new System.Drawing.Size(21, 17);
            this.txtId.TabIndex = 0;
            this.txtId.Text = "ID";
            this.txtId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textID
            // 
            this.textID.Enabled = false;
            this.textID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.Location = new System.Drawing.Point(161, 88);
            this.textID.Margin = new System.Windows.Forms.Padding(7);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(275, 23);
            this.textID.TabIndex = 1;
            // 
            // textUserName
            // 
            this.textUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUserName.Location = new System.Drawing.Point(161, 132);
            this.textUserName.Margin = new System.Windows.Forms.Padding(7);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(342, 23);
            this.textUserName.TabIndex = 3;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.AutoSize = true;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(79, 135);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTaiKhoan.Size = new System.Drawing.Size(56, 17);
            this.txtTaiKhoan.TabIndex = 2;
            this.txtTaiKhoan.Text = "Tên lớp";
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(161, 168);
            this.textPassword.Margin = new System.Windows.Forms.Padding(7);
            this.textPassword.Name = "textPassword";
            this.textPassword.ReadOnly = true;
            this.textPassword.Size = new System.Drawing.Size(342, 23);
            this.textPassword.TabIndex = 5;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.AutoSize = true;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(79, 174);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMatKhau.Size = new System.Drawing.Size(39, 17);
            this.txtMatKhau.TabIndex = 4;
            this.txtMatKhau.Text = "Sỉ số";
            // 
            // applyButton
            // 
            this.applyButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.applyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.applyButton.Location = new System.Drawing.Point(179, 293);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(99, 35);
            this.applyButton.TabIndex = 9;
            this.applyButton.Text = "Xác Nhận";
            this.applyButton.UseVisualStyleBackColor = false;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(308, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.ForeColor = System.Drawing.SystemColors.Highlight;
            this.titleText.Location = new System.Drawing.Point(213, 23);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(185, 29);
            this.titleText.TabIndex = 10;
            this.titleText.Text = "Sửa Thông Tin";
            // 
            // FrmQuanLyLH_Modifiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 385);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.txtId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "FrmQuanLyLH_Modifiles";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chinh sua thong tin lop hoc";
            this.Load += new System.EventHandler(this.FrmQuanLyUser_Modifiles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
 
        

        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Label txtTaiKhoan;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label txtMatKhau;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label titleText;
    }
    }
