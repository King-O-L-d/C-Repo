namespace Project1
{
    partial class FrmQuanLyUser_Modifiles
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.Label();
            this.chkMatKhau = new System.Windows.Forms.CheckBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.titleText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Location = new System.Drawing.Point(156, 95);
            this.txtId.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.txtId.Name = "txtId";
            this.txtId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtId.Size = new System.Drawing.Size(36, 29);
            this.txtId.TabIndex = 0;
            this.txtId.Text = "ID";
            this.txtId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(243, 89);
            this.textBox1.Margin = new System.Windows.Forms.Padding(7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(547, 35);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(243, 157);
            this.textBox2.Margin = new System.Windows.Forms.Padding(7);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(547, 35);
            this.textBox2.TabIndex = 3;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.AutoSize = true;
            this.txtTaiKhoan.Location = new System.Drawing.Point(69, 163);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTaiKhoan.Size = new System.Drawing.Size(123, 29);
            this.txtTaiKhoan.TabIndex = 2;
            this.txtTaiKhoan.Text = "Tài Khoản";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(243, 231);
            this.textBox3.Margin = new System.Windows.Forms.Padding(7);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(547, 35);
            this.textBox3.TabIndex = 5;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.AutoSize = true;
            this.txtMatKhau.Location = new System.Drawing.Point(79, 237);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMatKhau.Size = new System.Drawing.Size(113, 29);
            this.txtMatKhau.TabIndex = 4;
            this.txtMatKhau.Text = "Mật Khẩu";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(243, 306);
            this.textBox4.Margin = new System.Windows.Forms.Padding(7);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(547, 35);
            this.textBox4.TabIndex = 7;
            // 
            // txtHoTen
            // 
            this.txtHoTen.AutoSize = true;
            this.txtHoTen.Location = new System.Drawing.Point(65, 312);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtHoTen.Size = new System.Drawing.Size(127, 29);
            this.txtHoTen.TabIndex = 6;
            this.txtHoTen.Text = "Họ Và Tên";
            // 
            // chkMatKhau
            // 
            this.chkMatKhau.AutoSize = true;
            this.chkMatKhau.Location = new System.Drawing.Point(243, 376);
            this.chkMatKhau.Margin = new System.Windows.Forms.Padding(7);
            this.chkMatKhau.Name = "chkMatKhau";
            this.chkMatKhau.Size = new System.Drawing.Size(183, 33);
            this.chkMatKhau.TabIndex = 8;
            this.chkMatKhau.Text = "Nhớ Mật Khẩu";
            this.chkMatKhau.UseVisualStyleBackColor = true;
            // 
            // applyButton
            // 
            this.applyButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.applyButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.applyButton.Location = new System.Drawing.Point(243, 429);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(266, 61);
            this.applyButton.TabIndex = 9;
            this.applyButton.Text = "Xác Nhận";
            this.applyButton.UseVisualStyleBackColor = false;
            this.applyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(524, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(266, 61);
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
            this.titleText.Location = new System.Drawing.Point(424, 31);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(185, 29);
            this.titleText.TabIndex = 10;
            this.titleText.Text = "Sửa Thông Tin";
            // 
            // FrmQuanLyUser_Modifiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 570);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.chkMatKhau);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "FrmQuanLyUser_Modifiles";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "FrmQuanLyUser_Modifies";
            this.Load += new System.EventHandler(this.FrmQuanLyUser_Modifiles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
 
        

        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtTaiKhoan;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txtMatKhau;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label txtHoTen;
        private System.Windows.Forms.CheckBox chkMatKhau;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label titleText;
    }
    }
