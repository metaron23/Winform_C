namespace test
{
    partial class Form1
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
            this.lpl_hoten1 = new System.Windows.Forms.Label();
            this.txt_hoten1 = new System.Windows.Forms.TextBox();
            this.btn_hoten1 = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lpl_hoten1
            // 
            this.lpl_hoten1.AutoSize = true;
            this.lpl_hoten1.Location = new System.Drawing.Point(129, 49);
            this.lpl_hoten1.Name = "lpl_hoten1";
            this.lpl_hoten1.Size = new System.Drawing.Size(60, 13);
            this.lpl_hoten1.TabIndex = 0;
            this.lpl_hoten1.Text = "Họ và tên: ";
            // 
            // txt_hoten1
            // 
            this.txt_hoten1.Location = new System.Drawing.Point(195, 46);
            this.txt_hoten1.Name = "txt_hoten1";
            this.txt_hoten1.Size = new System.Drawing.Size(100, 20);
            this.txt_hoten1.TabIndex = 1;
            // 
            // btn_hoten1
            // 
            this.btn_hoten1.Location = new System.Drawing.Point(166, 90);
            this.btn_hoten1.Name = "btn_hoten1";
            this.btn_hoten1.Size = new System.Drawing.Size(75, 23);
            this.btn_hoten1.TabIndex = 2;
            this.btn_hoten1.Text = "Hiển thị";
            this.btn_hoten1.UseVisualStyleBackColor = true;
            this.btn_hoten1.Click += new System.EventHandler(this.btn_hoten1_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(265, 90);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(721, 346);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_hoten1);
            this.Controls.Add(this.txt_hoten1);
            this.Controls.Add(this.lpl_hoten1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lpl_hoten1;
        private System.Windows.Forms.TextBox txt_hoten1;
        private System.Windows.Forms.Button btn_hoten1;
        private System.Windows.Forms.Button btn_thoat;
    }
}

