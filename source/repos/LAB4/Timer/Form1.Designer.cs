namespace Timer
{
    partial class frm_Timer
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
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_ngay = new System.Windows.Forms.Label();
            this.lbl_load = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btb_show = new System.Windows.Forms.Button();
            this.prb_load = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bây giờ là: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(162, 29);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(62, 17);
            this.lbl_time.TabIndex = 1;
            this.lbl_time.Text = "thời gian";
            this.lbl_time.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_ngay
            // 
            this.lbl_ngay.AutoSize = true;
            this.lbl_ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngay.Location = new System.Drawing.Point(248, 29);
            this.lbl_ngay.Name = "lbl_ngay";
            this.lbl_ngay.Size = new System.Drawing.Size(79, 17);
            this.lbl_ngay.TabIndex = 2;
            this.lbl_ngay.Text = "ngày tháng";
            // 
            // lbl_load
            // 
            this.lbl_load.AutoSize = true;
            this.lbl_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_load.Location = new System.Drawing.Point(172, 115);
            this.lbl_load.Name = "lbl_load";
            this.lbl_load.Size = new System.Drawing.Size(50, 17);
            this.lbl_load.TabIndex = 3;
            this.lbl_load.Text = "fsdfdsf";
            this.lbl_load.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_ngay);
            this.groupBox1.Controls.Add(this.lbl_time);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(-2, -7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 81);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btb_show
            // 
            this.btb_show.Location = new System.Drawing.Point(24, 144);
            this.btb_show.Name = "btb_show";
            this.btb_show.Size = new System.Drawing.Size(105, 23);
            this.btb_show.TabIndex = 5;
            this.btb_show.Text = "Hiển thị ngày giờ";
            this.btb_show.UseVisualStyleBackColor = true;
            this.btb_show.Click += new System.EventHandler(this.btb_show_Click);
            // 
            // prb_load
            // 
            this.prb_load.Location = new System.Drawing.Point(175, 144);
            this.prb_load.Name = "prb_load";
            this.prb_load.Size = new System.Drawing.Size(206, 23);
            this.prb_load.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(-2, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(421, 39);
            this.label5.TabIndex = 7;
            this.label5.Text = "Xin chào tất cả các bạn";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frm_Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 292);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.prb_load);
            this.Controls.Add(this.btb_show);
            this.Controls.Add(this.lbl_load);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Timer";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_ngay;
        private System.Windows.Forms.Label lbl_load;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btb_show;
        private System.Windows.Forms.ProgressBar prb_load;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

