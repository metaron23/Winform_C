namespace GUI
{
    partial class GUI_DoiMatKhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.txt_mkcu = new System.Windows.Forms.TextBox();
            this.btn_doipass = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_mkmoi = new System.Windows.Forms.TextBox();
            this.txt_nhaplaimkmoi = new System.Windows.Forms.TextBox();
            this.chk_hien = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu hiện tại";
            // 
            // txt_tk
            // 
            this.txt_tk.Location = new System.Drawing.Point(140, 36);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(176, 20);
            this.txt_tk.TabIndex = 2;
            // 
            // txt_mkcu
            // 
            this.txt_mkcu.Location = new System.Drawing.Point(140, 66);
            this.txt_mkcu.Name = "txt_mkcu";
            this.txt_mkcu.PasswordChar = '*';
            this.txt_mkcu.Size = new System.Drawing.Size(176, 20);
            this.txt_mkcu.TabIndex = 3;
            // 
            // btn_doipass
            // 
            this.btn_doipass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_doipass.Location = new System.Drawing.Point(140, 188);
            this.btn_doipass.Name = "btn_doipass";
            this.btn_doipass.Size = new System.Drawing.Size(75, 23);
            this.btn_doipass.TabIndex = 6;
            this.btn_doipass.Text = "Đổi mật khẩu";
            this.btn_doipass.UseVisualStyleBackColor = true;
            this.btn_doipass.Click += new System.EventHandler(this.btn_dn_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(241, 188);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 7;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.PeachPuff;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label3.Size = new System.Drawing.Size(475, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "ĐĂNG NHẬP HỆ THỐNG";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mật khẩu mới";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nhập lại mật khẩu mới";
            // 
            // txt_mkmoi
            // 
            this.txt_mkmoi.Location = new System.Drawing.Point(140, 97);
            this.txt_mkmoi.Name = "txt_mkmoi";
            this.txt_mkmoi.PasswordChar = '*';
            this.txt_mkmoi.Size = new System.Drawing.Size(176, 20);
            this.txt_mkmoi.TabIndex = 4;
            // 
            // txt_nhaplaimkmoi
            // 
            this.txt_nhaplaimkmoi.Location = new System.Drawing.Point(140, 126);
            this.txt_nhaplaimkmoi.Name = "txt_nhaplaimkmoi";
            this.txt_nhaplaimkmoi.PasswordChar = '*';
            this.txt_nhaplaimkmoi.Size = new System.Drawing.Size(176, 20);
            this.txt_nhaplaimkmoi.TabIndex = 5;
            // 
            // chk_hien
            // 
            this.chk_hien.AutoSize = true;
            this.chk_hien.Location = new System.Drawing.Point(140, 152);
            this.chk_hien.Name = "chk_hien";
            this.chk_hien.Size = new System.Drawing.Size(48, 17);
            this.chk_hien.TabIndex = 13;
            this.chk_hien.Text = "Hiện";
            this.chk_hien.UseVisualStyleBackColor = true;
            this.chk_hien.CheckedChanged += new System.EventHandler(this.chk_hien_CheckedChanged);
            // 
            // GUI_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 223);
            this.Controls.Add(this.chk_hien);
            this.Controls.Add(this.txt_nhaplaimkmoi);
            this.Controls.Add(this.txt_mkmoi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_doipass);
            this.Controls.Add(this.txt_mkcu);
            this.Controls.Add(this.txt_tk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GUI_DoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.TextBox txt_mkcu;
        private System.Windows.Forms.Button btn_doipass;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_mkmoi;
        private System.Windows.Forms.TextBox txt_nhaplaimkmoi;
        private System.Windows.Forms.CheckBox chk_hien;
    }
}

