namespace Test_Winform
{
    partial class frm_QLSV
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
            this.txt_MaSV = new System.Windows.Forms.TextBox();
            this.lbl_ten = new System.Windows.Forms.Label();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.txt_Truong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdo_nam = new System.Windows.Forms.RadioButton();
            this.rdo_nu = new System.Windows.Forms.RadioButton();
            this.rdo_khac = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cls_ngoaingu = new System.Windows.Forms.CheckedListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chk_phatgiao = new System.Windows.Forms.CheckBox();
            this.chk_thchua = new System.Windows.Forms.CheckBox();
            this.chk_ando = new System.Windows.Forms.CheckBox();
            this.chk_khong = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_dantoc = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_nganh = new System.Windows.Forms.TextBox();
            this.txt_khoa = new System.Windows.Forms.TextBox();
            this.txt_lop = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rtxt_diachi = new System.Windows.Forms.RichTextBox();
            this.date_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_MaSV
            // 
            this.txt_MaSV.Location = new System.Drawing.Point(112, 22);
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.Size = new System.Drawing.Size(143, 20);
            this.txt_MaSV.TabIndex = 1;
            this.txt_MaSV.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_ten
            // 
            this.lbl_ten.AutoSize = true;
            this.lbl_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ten.Location = new System.Drawing.Point(23, 58);
            this.lbl_ten.Name = "lbl_ten";
            this.lbl_ten.Size = new System.Drawing.Size(63, 13);
            this.lbl_ten.TabIndex = 2;
            this.lbl_ten.Text = "Tên đầy đủ";
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(112, 55);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(143, 20);
            this.txt_Ten.TabIndex = 3;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(434, 343);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 23);
            this.btn_Luu.TabIndex = 4;
            this.btn_Luu.Text = "LƯU";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Truong
            // 
            this.txt_Truong.Location = new System.Drawing.Point(399, 22);
            this.txt_Truong.Name = "txt_Truong";
            this.txt_Truong.Size = new System.Drawing.Size(143, 20);
            this.txt_Truong.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(201, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Somsant Surapatpichai Thanh Hùng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giới tính";
            // 
            // rdo_nam
            // 
            this.rdo_nam.AutoSize = true;
            this.rdo_nam.Location = new System.Drawing.Point(3, 9);
            this.rdo_nam.Name = "rdo_nam";
            this.rdo_nam.Size = new System.Drawing.Size(47, 17);
            this.rdo_nam.TabIndex = 8;
            this.rdo_nam.TabStop = true;
            this.rdo_nam.Text = "Nam";
            this.rdo_nam.UseVisualStyleBackColor = true;
            this.rdo_nam.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdo_nu
            // 
            this.rdo_nu.AutoSize = true;
            this.rdo_nu.Location = new System.Drawing.Point(3, 30);
            this.rdo_nu.Name = "rdo_nu";
            this.rdo_nu.Size = new System.Drawing.Size(39, 17);
            this.rdo_nu.TabIndex = 9;
            this.rdo_nu.TabStop = true;
            this.rdo_nu.Text = "Nữ";
            this.rdo_nu.UseVisualStyleBackColor = true;
            // 
            // rdo_khac
            // 
            this.rdo_khac.AutoSize = true;
            this.rdo_khac.Location = new System.Drawing.Point(3, 53);
            this.rdo_khac.Name = "rdo_khac";
            this.rdo_khac.Size = new System.Drawing.Size(50, 17);
            this.rdo_khac.TabIndex = 10;
            this.rdo_khac.TabStop = true;
            this.rdo_khac.Text = "Khác";
            this.rdo_khac.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_nam);
            this.groupBox1.Controls.Add(this.rdo_khac);
            this.groupBox1.Controls.Add(this.rdo_nu);
            this.groupBox1.Location = new System.Drawing.Point(112, 78);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(65, 74);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cls_ngoaingu);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.cb_dantoc);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.txt_sdt);
            this.groupBox2.Controls.Add(this.btn_Luu);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txt_email);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txt_nganh);
            this.groupBox2.Controls.Add(this.txt_khoa);
            this.groupBox2.Controls.Add(this.txt_lop);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_Truong);
            this.groupBox2.Controls.Add(this.rtxt_diachi);
            this.groupBox2.Controls.Add(this.date_ngaysinh);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_Ten);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_MaSV);
            this.groupBox2.Controls.Add(this.lbl_ten);
            this.groupBox2.Location = new System.Drawing.Point(12, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 396);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sinh viên";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cls_ngoaingu
            // 
            this.cls_ngoaingu.FormattingEnabled = true;
            this.cls_ngoaingu.Items.AddRange(new object[] {
            "Tiếng Anh",
            "Tiếng Pháp",
            "Tiếng Nhật",
            "Tiếng Việt"});
            this.cls_ngoaingu.Location = new System.Drawing.Point(399, 155);
            this.cls_ngoaingu.Name = "cls_ngoaingu";
            this.cls_ngoaingu.Size = new System.Drawing.Size(120, 94);
            this.cls_ngoaingu.TabIndex = 13;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chk_phatgiao);
            this.groupBox5.Controls.Add(this.chk_thchua);
            this.groupBox5.Controls.Add(this.chk_ando);
            this.groupBox5.Controls.Add(this.chk_khong);
            this.groupBox5.Location = new System.Drawing.Point(112, 309);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(176, 57);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            // 
            // chk_phatgiao
            // 
            this.chk_phatgiao.AutoSize = true;
            this.chk_phatgiao.Location = new System.Drawing.Point(6, 10);
            this.chk_phatgiao.Name = "chk_phatgiao";
            this.chk_phatgiao.Size = new System.Drawing.Size(71, 17);
            this.chk_phatgiao.TabIndex = 19;
            this.chk_phatgiao.Text = "Phật giáo";
            this.chk_phatgiao.UseVisualStyleBackColor = true;
            this.chk_phatgiao.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chk_thchua
            // 
            this.chk_thchua.AutoSize = true;
            this.chk_thchua.Location = new System.Drawing.Point(90, 10);
            this.chk_thchua.Name = "chk_thchua";
            this.chk_thchua.Size = new System.Drawing.Size(80, 17);
            this.chk_thchua.TabIndex = 20;
            this.chk_thchua.Text = "Thiên chúa";
            this.chk_thchua.UseVisualStyleBackColor = true;
            this.chk_thchua.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chk_ando
            // 
            this.chk_ando.AutoSize = true;
            this.chk_ando.Location = new System.Drawing.Point(6, 33);
            this.chk_ando.Name = "chk_ando";
            this.chk_ando.Size = new System.Drawing.Size(78, 17);
            this.chk_ando.TabIndex = 33;
            this.chk_ando.Text = "Ấn độ giáo";
            this.chk_ando.UseVisualStyleBackColor = true;
            // 
            // chk_khong
            // 
            this.chk_khong.AutoSize = true;
            this.chk_khong.Location = new System.Drawing.Point(90, 33);
            this.chk_khong.Name = "chk_khong";
            this.chk_khong.Size = new System.Drawing.Size(57, 17);
            this.chk_khong.TabIndex = 34;
            this.chk_khong.Text = "Không";
            this.chk_khong.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(567, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // cb_dantoc
            // 
            this.cb_dantoc.FormattingEnabled = true;
            this.cb_dantoc.Items.AddRange(new object[] {
            "Không dân tộc",
            "Kinh",
            "Ê đê",
            "H\'Mông"});
            this.cb_dantoc.Location = new System.Drawing.Point(112, 282);
            this.cb_dantoc.Name = "cb_dantoc";
            this.cb_dantoc.Size = new System.Drawing.Size(143, 21);
            this.cb_dantoc.TabIndex = 13;
            this.cb_dantoc.Text = "Không dân tộc";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(383, 380);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(181, 13);
            this.linkLabel1.TabIndex = 39;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://kcntt.duytan.dtu.edu.vn";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(399, 299);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(143, 20);
            this.txt_sdt.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(318, 302);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Số điện thoại";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(399, 259);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(143, 20);
            this.txt_email.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(318, 266);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Email";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(318, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Ngoại ngữ";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txt_nganh
            // 
            this.txt_nganh.Location = new System.Drawing.Point(399, 119);
            this.txt_nganh.Name = "txt_nganh";
            this.txt_nganh.Size = new System.Drawing.Size(143, 20);
            this.txt_nganh.TabIndex = 27;
            // 
            // txt_khoa
            // 
            this.txt_khoa.Location = new System.Drawing.Point(399, 86);
            this.txt_khoa.Name = "txt_khoa";
            this.txt_khoa.Size = new System.Drawing.Size(143, 20);
            this.txt_khoa.TabIndex = 26;
            // 
            // txt_lop
            // 
            this.txt_lop.Location = new System.Drawing.Point(399, 55);
            this.txt_lop.Name = "txt_lop";
            this.txt_lop.Size = new System.Drawing.Size(143, 20);
            this.txt_lop.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(318, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Ngành";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(318, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Khoa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(318, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Lớp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(318, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Trường";
            // 
            // rtxt_diachi
            // 
            this.rtxt_diachi.Location = new System.Drawing.Point(112, 197);
            this.rtxt_diachi.Name = "rtxt_diachi";
            this.rtxt_diachi.Size = new System.Drawing.Size(143, 71);
            this.rtxt_diachi.TabIndex = 18;
            this.rtxt_diachi.Text = "";
            // 
            // date_ngaysinh
            // 
            this.date_ngaysinh.CustomFormat = "dd/MM/yyyy";
            this.date_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_ngaysinh.Location = new System.Drawing.Point(112, 163);
            this.date_ngaysinh.Name = "date_ngaysinh";
            this.date_ngaysinh.Size = new System.Drawing.Size(143, 20);
            this.date_ngaysinh.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tôn giáo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Dân tộc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ngày sinh";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // frm_QLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 433);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_QLSV";
            this.Text = "Câu 1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.Label lbl_ten;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.TextBox txt_Truong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdo_nam;
        private System.Windows.Forms.RadioButton rdo_nu;
        private System.Windows.Forms.RadioButton rdo_khac;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chk_phatgiao;
        private System.Windows.Forms.RichTextBox rtxt_diachi;
        private System.Windows.Forms.DateTimePicker date_ngaysinh;
        private System.Windows.Forms.CheckBox chk_thchua;
        private System.Windows.Forms.ComboBox cb_dantoc;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chk_khong;
        private System.Windows.Forms.CheckBox chk_ando;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_nganh;
        private System.Windows.Forms.TextBox txt_khoa;
        private System.Windows.Forms.TextBox txt_lop;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckedListBox cls_ngoaingu;
    }
}

