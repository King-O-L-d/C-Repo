namespace Project1
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.TitlePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuSystemDropdown = new System.Windows.Forms.FlowLayoutPanel();
            this.titleSystemMenu = new System.Windows.Forms.Button();
            this.manageStuButton = new System.Windows.Forms.Button();
            this.manageClassButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.changePassButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabFormControl1 = new DevComponents.DotNetBar.Controls.TabFormControl();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.exitBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TitlePanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuSystemDropdown.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TitlePanel.Controls.Add(this.label1);
            this.TitlePanel.Controls.Add(this.label2);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Margin = new System.Windows.Forms.Padding(4);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(1113, 44);
            this.TitlePanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(125)))), ((int)(((byte)(226)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1109, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "King Of Lỏd";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1121, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.titleSystemMenu);
            this.flowLayoutPanel1.Controls.Add(this.menuSystemDropdown);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 44);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(267, 596);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // menuSystemDropdown
            // 
            this.menuSystemDropdown.Controls.Add(this.manageStuButton);
            this.menuSystemDropdown.Controls.Add(this.manageClassButton);
            this.menuSystemDropdown.Controls.Add(this.changePassButton);
            this.menuSystemDropdown.Controls.Add(this.logoutButton);
            this.menuSystemDropdown.Controls.Add(this.exitBtn);
            this.menuSystemDropdown.Controls.Add(this.exitButton);
            this.menuSystemDropdown.Controls.Add(this.button1);
            this.menuSystemDropdown.Location = new System.Drawing.Point(4, 48);
            this.menuSystemDropdown.Margin = new System.Windows.Forms.Padding(4);
            this.menuSystemDropdown.MaximumSize = new System.Drawing.Size(248, 225);
            this.menuSystemDropdown.MinimumSize = new System.Drawing.Size(248, 44);
            this.menuSystemDropdown.Name = "menuSystemDropdown";
            this.menuSystemDropdown.Size = new System.Drawing.Size(248, 225);
            this.menuSystemDropdown.TabIndex = 0;
            this.menuSystemDropdown.Paint += new System.Windows.Forms.PaintEventHandler(this.menuSystemDropdown_Paint);
            // 
            // titleSystemMenu
            // 
            this.titleSystemMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(125)))), ((int)(((byte)(226)))));
            this.titleSystemMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleSystemMenu.Location = new System.Drawing.Point(0, 0);
            this.titleSystemMenu.Margin = new System.Windows.Forms.Padding(0);
            this.titleSystemMenu.Name = "titleSystemMenu";
            this.titleSystemMenu.Size = new System.Drawing.Size(244, 44);
            this.titleSystemMenu.TabIndex = 0;
            this.titleSystemMenu.Text = "Hệ thống";
            this.titleSystemMenu.UseVisualStyleBackColor = false;
            // 
            // manageStuButton
            // 
            this.manageStuButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.manageStuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageStuButton.Location = new System.Drawing.Point(0, 0);
            this.manageStuButton.Margin = new System.Windows.Forms.Padding(0);
            this.manageStuButton.Name = "manageStuButton";
            this.manageStuButton.Size = new System.Drawing.Size(244, 44);
            this.manageStuButton.TabIndex = 3;
            this.manageStuButton.Text = "Quản lý sinh viên";
            this.manageStuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageStuButton.UseVisualStyleBackColor = false;
            this.manageStuButton.Click += new System.EventHandler(this.manageUserButton_Click);
            // 
            // manageClassButton
            // 
            this.manageClassButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.manageClassButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageClassButton.Location = new System.Drawing.Point(0, 44);
            this.manageClassButton.Margin = new System.Windows.Forms.Padding(0);
            this.manageClassButton.Name = "manageClassButton";
            this.manageClassButton.Size = new System.Drawing.Size(244, 44);
            this.manageClassButton.TabIndex = 6;
            this.manageClassButton.Text = "Quản lý lớp học";
            this.manageClassButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageClassButton.UseVisualStyleBackColor = false;
            this.manageClassButton.Click += new System.EventHandler(this.manageClassButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(0, 132);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(0);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(244, 44);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Đăng xuất";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // changePassButton
            // 
            this.changePassButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.changePassButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePassButton.Location = new System.Drawing.Point(0, 88);
            this.changePassButton.Margin = new System.Windows.Forms.Padding(0);
            this.changePassButton.Name = "changePassButton";
            this.changePassButton.Size = new System.Drawing.Size(244, 44);
            this.changePassButton.TabIndex = 2;
            this.changePassButton.Text = "Đổi mật khẩu";
            this.changePassButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changePassButton.UseVisualStyleBackColor = false;
            this.changePassButton.Click += new System.EventHandler(this.changePassButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(0, 220);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(244, 44);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Thoát";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 264);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Quản lý sinh viên";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            // 
            // tabFormControl1
            // 
            // 
            // 
            // 
            this.tabFormControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tabFormControl1.Location = new System.Drawing.Point(0, 0);
            this.tabFormControl1.Name = "tabFormControl1";
            this.tabFormControl1.TabIndex = 0;
            this.tabFormControl1.TabStripFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tabControl
            // 
            this.tabControl.HotTrack = true;
            this.tabControl.Location = new System.Drawing.Point(275, 44);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(823, 596);
            this.tabControl.TabIndex = 1;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(0, 176);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(244, 44);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Thoát";
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Project1.Properties.Resources._09407652664ea810f15f;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(4, 281);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 123);
            this.panel1.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 640);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.TitlePanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.menuSystemDropdown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel TitlePanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel menuSystemDropdown;
        private System.Windows.Forms.Button titleSystemMenu;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button changePassButton;
        private System.Windows.Forms.Button manageStuButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Timer timer1;
        private DevComponents.DotNetBar.Controls.TabFormControl tabFormControl1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button manageClassButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitBtn;
    }
}