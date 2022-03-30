namespace test
{
    partial class Form2
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
            this.txt_so1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_so2 = new System.Windows.Forms.TextBox();
            this.btn_cong = new System.Windows.Forms.Button();
            this.btn_tru = new System.Windows.Forms.Button();
            this.btn_nhan = new System.Windows.Forms.Button();
            this.btn_chia = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nhap = new System.Windows.Forms.TextBox();
            this.lst_Box = new System.Windows.Forms.ListBox();
            this.btn_nhap = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tong = new System.Windows.Forms.TextBox();
            this.btn_xoachon = new System.Windows.Forms.Button();
            this.btn_xoadau = new System.Windows.Forms.Button();
            this.btn_xoacuoi = new System.Windows.Forms.Button();
            this.btn_xoafull = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_color = new System.Windows.Forms.ComboBox();
            this.btn_doimau = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.lbl_head = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số thứ nhất";
            // 
            // txt_so1
            // 
            this.txt_so1.Location = new System.Drawing.Point(162, 39);
            this.txt_so1.Name = "txt_so1";
            this.txt_so1.Size = new System.Drawing.Size(100, 20);
            this.txt_so1.TabIndex = 1;
            this.txt_so1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_so1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số thứ hai";
            // 
            // txt_so2
            // 
            this.txt_so2.Location = new System.Drawing.Point(162, 79);
            this.txt_so2.Name = "txt_so2";
            this.txt_so2.Size = new System.Drawing.Size(100, 20);
            this.txt_so2.TabIndex = 3;
            this.txt_so2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_so2_KeyPress);
            // 
            // btn_cong
            // 
            this.btn_cong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cong.Location = new System.Drawing.Point(65, 124);
            this.btn_cong.Name = "btn_cong";
            this.btn_cong.Size = new System.Drawing.Size(30, 23);
            this.btn_cong.TabIndex = 4;
            this.btn_cong.Text = "+";
            this.btn_cong.UseVisualStyleBackColor = true;
            this.btn_cong.Click += new System.EventHandler(this.btn_cong_Click);
            // 
            // btn_tru
            // 
            this.btn_tru.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tru.Location = new System.Drawing.Point(115, 124);
            this.btn_tru.Name = "btn_tru";
            this.btn_tru.Size = new System.Drawing.Size(30, 23);
            this.btn_tru.TabIndex = 5;
            this.btn_tru.Text = "-";
            this.btn_tru.UseVisualStyleBackColor = true;
            this.btn_tru.Click += new System.EventHandler(this.btn_tru_Click);
            // 
            // btn_nhan
            // 
            this.btn_nhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhan.Location = new System.Drawing.Point(162, 124);
            this.btn_nhan.Name = "btn_nhan";
            this.btn_nhan.Size = new System.Drawing.Size(30, 23);
            this.btn_nhan.TabIndex = 6;
            this.btn_nhan.Text = "*";
            this.btn_nhan.UseVisualStyleBackColor = true;
            this.btn_nhan.Click += new System.EventHandler(this.btn_nhan_Click);
            // 
            // btn_chia
            // 
            this.btn_chia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chia.Location = new System.Drawing.Point(210, 124);
            this.btn_chia.Name = "btn_chia";
            this.btn_chia.Size = new System.Drawing.Size(30, 23);
            this.btn_chia.TabIndex = 7;
            this.btn_chia.Text = "/";
            this.btn_chia.UseVisualStyleBackColor = true;
            this.btn_chia.Click += new System.EventHandler(this.btn_chia_Click);
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.Location = new System.Drawing.Point(256, 124);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(40, 23);
            this.btn_del.TabIndex = 8;
            this.btn_del.Text = "Del";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kết quả";
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(162, 166);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(100, 20);
            this.txt_result.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(348, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nhập thông tin";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_nhap
            // 
            this.txt_nhap.Location = new System.Drawing.Point(445, 75);
            this.txt_nhap.Name = "txt_nhap";
            this.txt_nhap.Size = new System.Drawing.Size(134, 20);
            this.txt_nhap.TabIndex = 12;
            // 
            // lst_Box
            // 
            this.lst_Box.FormattingEnabled = true;
            this.lst_Box.Location = new System.Drawing.Point(635, 42);
            this.lst_Box.Name = "lst_Box";
            this.lst_Box.Size = new System.Drawing.Size(256, 95);
            this.lst_Box.TabIndex = 13;
            this.lst_Box.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_nhap
            // 
            this.btn_nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhap.Location = new System.Drawing.Point(445, 114);
            this.btn_nhap.Name = "btn_nhap";
            this.btn_nhap.Size = new System.Drawing.Size(102, 23);
            this.btn_nhap.TabIndex = 14;
            this.btn_nhap.Text = "Nhập thông tin";
            this.btn_nhap.UseVisualStyleBackColor = true;
            this.btn_nhap.Click += new System.EventHandler(this.btn_nhap_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(632, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tổng số người đã khai báo";
            // 
            // txt_tong
            // 
            this.txt_tong.Location = new System.Drawing.Point(798, 162);
            this.txt_tong.Name = "txt_tong";
            this.txt_tong.Size = new System.Drawing.Size(93, 20);
            this.txt_tong.TabIndex = 16;
            // 
            // btn_xoachon
            // 
            this.btn_xoachon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoachon.Location = new System.Drawing.Point(615, 206);
            this.btn_xoachon.Name = "btn_xoachon";
            this.btn_xoachon.Size = new System.Drawing.Size(157, 23);
            this.btn_xoachon.TabIndex = 17;
            this.btn_xoachon.Text = "Xoá thông tin đang chọn";
            this.btn_xoachon.UseVisualStyleBackColor = true;
            this.btn_xoachon.Click += new System.EventHandler(this.btn_xoachon_Click);
            // 
            // btn_xoadau
            // 
            this.btn_xoadau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoadau.Location = new System.Drawing.Point(798, 206);
            this.btn_xoadau.Name = "btn_xoadau";
            this.btn_xoadau.Size = new System.Drawing.Size(130, 23);
            this.btn_xoadau.TabIndex = 18;
            this.btn_xoadau.Text = "Xoá thông tin đầu";
            this.btn_xoadau.UseVisualStyleBackColor = true;
            this.btn_xoadau.Click += new System.EventHandler(this.btn_xoadau_Click);
            // 
            // btn_xoacuoi
            // 
            this.btn_xoacuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoacuoi.Location = new System.Drawing.Point(798, 250);
            this.btn_xoacuoi.Name = "btn_xoacuoi";
            this.btn_xoacuoi.Size = new System.Drawing.Size(130, 23);
            this.btn_xoacuoi.TabIndex = 19;
            this.btn_xoacuoi.Text = "Xoá thông tin cuối";
            this.btn_xoacuoi.UseVisualStyleBackColor = true;
            this.btn_xoacuoi.Click += new System.EventHandler(this.btn_xoacuoi_Click);
            // 
            // btn_xoafull
            // 
            this.btn_xoafull.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoafull.Location = new System.Drawing.Point(615, 250);
            this.btn_xoafull.Name = "btn_xoafull";
            this.btn_xoafull.Size = new System.Drawing.Size(157, 23);
            this.btn_xoafull.TabIndex = 20;
            this.btn_xoafull.Text = "Xoá toàn bộ thông tin";
            this.btn_xoafull.UseVisualStyleBackColor = true;
            this.btn_xoafull.Click += new System.EventHandler(this.btn_xoafull_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Chọn màu";
            // 
            // cbo_color
            // 
            this.cbo_color.FormattingEnabled = true;
            this.cbo_color.Items.AddRange(new object[] {
            "Yellow",
            "Red",
            "Blue",
            "Black"});
            this.cbo_color.Location = new System.Drawing.Point(141, 236);
            this.cbo_color.Name = "cbo_color";
            this.cbo_color.Size = new System.Drawing.Size(121, 21);
            this.cbo_color.TabIndex = 22;
            // 
            // btn_doimau
            // 
            this.btn_doimau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doimau.Location = new System.Drawing.Point(90, 275);
            this.btn_doimau.Name = "btn_doimau";
            this.btn_doimau.Size = new System.Drawing.Size(102, 23);
            this.btn_doimau.TabIndex = 23;
            this.btn_doimau.Text = "Đổi màu";
            this.btn_doimau.UseVisualStyleBackColor = true;
            this.btn_doimau.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(210, 275);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(102, 23);
            this.btn_thoat.TabIndex = 24;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // lbl_head
            // 
            this.lbl_head.AutoSize = true;
            this.lbl_head.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_head.Location = new System.Drawing.Point(112, 206);
            this.lbl_head.Name = "lbl_head";
            this.lbl_head.Size = new System.Drawing.Size(205, 13);
            this.lbl_head.TabIndex = 25;
            this.lbl_head.Text = "CHÀO MỪNG BẠN ĐẾN VỚI FORM";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 390);
            this.Controls.Add(this.lbl_head);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_doimau);
            this.Controls.Add(this.cbo_color);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_xoafull);
            this.Controls.Add(this.btn_xoacuoi);
            this.Controls.Add(this.btn_xoadau);
            this.Controls.Add(this.btn_xoachon);
            this.Controls.Add(this.txt_tong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_nhap);
            this.Controls.Add(this.lst_Box);
            this.Controls.Add(this.txt_nhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_chia);
            this.Controls.Add(this.btn_nhan);
            this.Controls.Add(this.btn_tru);
            this.Controls.Add(this.btn_cong);
            this.Controls.Add(this.txt_so2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_so1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_so1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_so2;
        private System.Windows.Forms.Button btn_cong;
        private System.Windows.Forms.Button btn_tru;
        private System.Windows.Forms.Button btn_nhan;
        private System.Windows.Forms.Button btn_chia;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nhap;
        private System.Windows.Forms.ListBox lst_Box;
        private System.Windows.Forms.Button btn_nhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tong;
        private System.Windows.Forms.Button btn_xoachon;
        private System.Windows.Forms.Button btn_xoadau;
        private System.Windows.Forms.Button btn_xoacuoi;
        private System.Windows.Forms.Button btn_xoafull;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_color;
        private System.Windows.Forms.Button btn_doimau;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label lbl_head;
    }
}