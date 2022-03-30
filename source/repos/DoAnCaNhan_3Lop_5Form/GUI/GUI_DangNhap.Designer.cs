namespace GUI
{
    partial class GUI_DangNhap
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
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.chk_hien = new System.Windows.Forms.CheckBox();
            this.btn_dn = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.lkl_quenpass = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // txt_tk
            // 
            this.txt_tk.Location = new System.Drawing.Point(158, 58);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(176, 20);
            this.txt_tk.TabIndex = 2;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(158, 93);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(176, 20);
            this.txt_pass.TabIndex = 3;
            this.txt_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pass_KeyPress);
            // 
            // chk_hien
            // 
            this.chk_hien.AutoSize = true;
            this.chk_hien.Location = new System.Drawing.Point(158, 128);
            this.chk_hien.Name = "chk_hien";
            this.chk_hien.Size = new System.Drawing.Size(48, 17);
            this.chk_hien.TabIndex = 4;
            this.chk_hien.Text = "Hiện";
            this.chk_hien.UseVisualStyleBackColor = true;
            this.chk_hien.CheckedChanged += new System.EventHandler(this.chk_hien_CheckedChanged);
            // 
            // btn_dn
            // 
            this.btn_dn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dn.Location = new System.Drawing.Point(158, 164);
            this.btn_dn.Name = "btn_dn";
            this.btn_dn.Size = new System.Drawing.Size(75, 23);
            this.btn_dn.TabIndex = 5;
            this.btn_dn.Text = "Đăng nhập";
            this.btn_dn.UseVisualStyleBackColor = true;
            this.btn_dn.Click += new System.EventHandler(this.btn_dn_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(259, 164);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // lkl_quenpass
            // 
            this.lkl_quenpass.AutoSize = true;
            this.lkl_quenpass.Location = new System.Drawing.Point(258, 128);
            this.lkl_quenpass.Name = "lkl_quenpass";
            this.lkl_quenpass.Size = new System.Drawing.Size(76, 13);
            this.lkl_quenpass.TabIndex = 7;
            this.lkl_quenpass.TabStop = true;
            this.lkl_quenpass.Text = "Đổi mật khẩu?";
            this.lkl_quenpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkl_quenpass_LinkClicked);
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
            // GUI_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 223);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lkl_quenpass);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_dn);
            this.Controls.Add(this.chk_hien);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_tk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GUI_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.CheckBox chk_hien;
        private System.Windows.Forms.Button btn_dn;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.LinkLabel lkl_quenpass;
        private System.Windows.Forms.Label label3;
    }
}

