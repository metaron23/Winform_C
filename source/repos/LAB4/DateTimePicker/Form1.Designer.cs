namespace DateTimePicker
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.btn_dk = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_start = new System.Windows.Forms.TextBox();
            this.txt_end = new System.Windows.Forms.TextBox();
            this.txt_min = new System.Windows.Forms.TextBox();
            this.txt_max = new System.Windows.Forms.TextBox();
            this.txt_today = new System.Windows.Forms.TextBox();
            this.btn_display = new System.Windows.Forms.Button();
            this.txt_countday = new System.Windows.Forms.TextBox();
            this.txt_counthour = new System.Windows.Forms.TextBox();
            this.btn_countday = new System.Windows.Forms.Button();
            this.btn_counthour = new System.Windows.Forms.Button();
            this.moc1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(141, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG KÝ KHOÁ HỌC TRỰC TUYẾN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thời gian";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(200, 64);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(209, 20);
            this.txt_ten.TabIndex = 5;
            this.txt_ten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ten_KeyPress);
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(200, 88);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(209, 20);
            this.txt_sdt.TabIndex = 6;
            this.txt_sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sdt_KeyPress);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(200, 115);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(209, 20);
            this.txt_email.TabIndex = 7;
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(200, 142);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(209, 20);
            this.dtp1.TabIndex = 8;
            // 
            // btn_dk
            // 
            this.btn_dk.Location = new System.Drawing.Point(200, 182);
            this.btn_dk.Name = "btn_dk";
            this.btn_dk.Size = new System.Drawing.Size(75, 23);
            this.btn_dk.TabIndex = 9;
            this.btn_dk.Text = "Đăng ký";
            this.btn_dk.UseVisualStyleBackColor = true;
            this.btn_dk.Click += new System.EventHandler(this.btn_dk_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(334, 182);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 10;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ngày bắt đầu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(509, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ngày kết thúc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(509, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Min_Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(509, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Max_Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(509, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Day date";
            // 
            // txt_start
            // 
            this.txt_start.Location = new System.Drawing.Point(605, 64);
            this.txt_start.Name = "txt_start";
            this.txt_start.Size = new System.Drawing.Size(209, 20);
            this.txt_start.TabIndex = 16;
            // 
            // txt_end
            // 
            this.txt_end.Location = new System.Drawing.Point(605, 88);
            this.txt_end.Name = "txt_end";
            this.txt_end.Size = new System.Drawing.Size(209, 20);
            this.txt_end.TabIndex = 17;
            // 
            // txt_min
            // 
            this.txt_min.Location = new System.Drawing.Point(605, 114);
            this.txt_min.Name = "txt_min";
            this.txt_min.Size = new System.Drawing.Size(209, 20);
            this.txt_min.TabIndex = 18;
            // 
            // txt_max
            // 
            this.txt_max.Location = new System.Drawing.Point(605, 145);
            this.txt_max.Name = "txt_max";
            this.txt_max.Size = new System.Drawing.Size(209, 20);
            this.txt_max.TabIndex = 19;
            // 
            // txt_today
            // 
            this.txt_today.Location = new System.Drawing.Point(605, 168);
            this.txt_today.Name = "txt_today";
            this.txt_today.Size = new System.Drawing.Size(209, 20);
            this.txt_today.TabIndex = 20;
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(605, 194);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(209, 23);
            this.btn_display.TabIndex = 21;
            this.btn_display.Text = "Hiển thị";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // txt_countday
            // 
            this.txt_countday.Location = new System.Drawing.Point(512, 223);
            this.txt_countday.Name = "txt_countday";
            this.txt_countday.Size = new System.Drawing.Size(117, 20);
            this.txt_countday.TabIndex = 22;
            // 
            // txt_counthour
            // 
            this.txt_counthour.Location = new System.Drawing.Point(512, 249);
            this.txt_counthour.Name = "txt_counthour";
            this.txt_counthour.Size = new System.Drawing.Size(117, 20);
            this.txt_counthour.TabIndex = 23;
            // 
            // btn_countday
            // 
            this.btn_countday.Location = new System.Drawing.Point(647, 223);
            this.btn_countday.Name = "btn_countday";
            this.btn_countday.Size = new System.Drawing.Size(116, 23);
            this.btn_countday.TabIndex = 24;
            this.btn_countday.Text = "Đếm ngày";
            this.btn_countday.UseVisualStyleBackColor = true;
            this.btn_countday.Click += new System.EventHandler(this.btn_countday_Click);
            // 
            // btn_counthour
            // 
            this.btn_counthour.Location = new System.Drawing.Point(647, 249);
            this.btn_counthour.Name = "btn_counthour";
            this.btn_counthour.Size = new System.Drawing.Size(116, 23);
            this.btn_counthour.TabIndex = 25;
            this.btn_counthour.Text = "Đếm tiếng";
            this.btn_counthour.UseVisualStyleBackColor = true;
            this.btn_counthour.Click += new System.EventHandler(this.btn_counthour_Click);
            // 
            // moc1
            // 
            this.moc1.Location = new System.Drawing.Point(826, 64);
            this.moc1.MaxSelectionCount = 15;
            this.moc1.Name = "moc1";
            this.moc1.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1073, 355);
            this.Controls.Add(this.moc1);
            this.Controls.Add(this.btn_counthour);
            this.Controls.Add(this.btn_countday);
            this.Controls.Add(this.txt_counthour);
            this.Controls.Add(this.txt_countday);
            this.Controls.Add(this.btn_display);
            this.Controls.Add(this.txt_today);
            this.Controls.Add(this.txt_max);
            this.Controls.Add(this.txt_min);
            this.Controls.Add(this.txt_end);
            this.Controls.Add(this.txt_start);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_dk);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Button btn_dk;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_start;
        private System.Windows.Forms.TextBox txt_end;
        private System.Windows.Forms.TextBox txt_min;
        private System.Windows.Forms.TextBox txt_max;
        private System.Windows.Forms.TextBox txt_today;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.TextBox txt_countday;
        private System.Windows.Forms.TextBox txt_counthour;
        private System.Windows.Forms.Button btn_countday;
        private System.Windows.Forms.Button btn_counthour;
        private System.Windows.Forms.MonthCalendar moc1;
    }
}

