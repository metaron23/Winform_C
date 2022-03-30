namespace True_View
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
            this.label1 = new System.Windows.Forms.Label();
            this.tv1 = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TenNode = new System.Windows.Forms.TextBox();
            this.btn_add_goc = new System.Windows.Forms.Button();
            this.btn_add_con = new System.Windows.Forms.Button();
            this.btn_xoa_all = new System.Windows.Forms.Button();
            this.btn_xoa_select = new System.Windows.Forms.Button();
            this.btn_count_full = new System.Windows.Forms.Button();
            this.btn_extend = new System.Windows.Forms.Button();
            this.btn_collapse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Treeview";
            // 
            // tv1
            // 
            this.tv1.Location = new System.Drawing.Point(41, 54);
            this.tv1.Name = "tv1";
            this.tv1.Size = new System.Drawing.Size(183, 208);
            this.tv1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiêu đề Node";
            // 
            // txt_TenNode
            // 
            this.txt_TenNode.Location = new System.Drawing.Point(343, 51);
            this.txt_TenNode.Name = "txt_TenNode";
            this.txt_TenNode.Size = new System.Drawing.Size(127, 20);
            this.txt_TenNode.TabIndex = 3;
            // 
            // btn_add_goc
            // 
            this.btn_add_goc.Location = new System.Drawing.Point(267, 90);
            this.btn_add_goc.Name = "btn_add_goc";
            this.btn_add_goc.Size = new System.Drawing.Size(203, 23);
            this.btn_add_goc.TabIndex = 4;
            this.btn_add_goc.Text = "Thêm Node gốc";
            this.btn_add_goc.UseVisualStyleBackColor = true;
            this.btn_add_goc.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_add_con
            // 
            this.btn_add_con.Location = new System.Drawing.Point(267, 131);
            this.btn_add_con.Name = "btn_add_con";
            this.btn_add_con.Size = new System.Drawing.Size(203, 23);
            this.btn_add_con.TabIndex = 5;
            this.btn_add_con.Text = "Thêm Node con";
            this.btn_add_con.UseVisualStyleBackColor = true;
            this.btn_add_con.Click += new System.EventHandler(this.btn_add_con_Click);
            // 
            // btn_xoa_all
            // 
            this.btn_xoa_all.Location = new System.Drawing.Point(267, 173);
            this.btn_xoa_all.Name = "btn_xoa_all";
            this.btn_xoa_all.Size = new System.Drawing.Size(203, 23);
            this.btn_xoa_all.TabIndex = 6;
            this.btn_xoa_all.Text = "Xoá tất cả các Node";
            this.btn_xoa_all.UseVisualStyleBackColor = true;
            this.btn_xoa_all.Click += new System.EventHandler(this.btn_xoa_all_Click);
            // 
            // btn_xoa_select
            // 
            this.btn_xoa_select.Location = new System.Drawing.Point(267, 216);
            this.btn_xoa_select.Name = "btn_xoa_select";
            this.btn_xoa_select.Size = new System.Drawing.Size(203, 23);
            this.btn_xoa_select.TabIndex = 7;
            this.btn_xoa_select.Text = "Xoá Node đang chọn";
            this.btn_xoa_select.UseVisualStyleBackColor = true;
            this.btn_xoa_select.Click += new System.EventHandler(this.btn_xoa_select_Click);
            // 
            // btn_count_full
            // 
            this.btn_count_full.Location = new System.Drawing.Point(267, 264);
            this.btn_count_full.Name = "btn_count_full";
            this.btn_count_full.Size = new System.Drawing.Size(203, 23);
            this.btn_count_full.TabIndex = 8;
            this.btn_count_full.Text = "Đếm tổng Node Treeview";
            this.btn_count_full.UseVisualStyleBackColor = true;
            this.btn_count_full.Click += new System.EventHandler(this.btn_count_full_Click);
            // 
            // btn_extend
            // 
            this.btn_extend.Location = new System.Drawing.Point(267, 304);
            this.btn_extend.Name = "btn_extend";
            this.btn_extend.Size = new System.Drawing.Size(54, 23);
            this.btn_extend.TabIndex = 9;
            this.btn_extend.Text = "+";
            this.btn_extend.UseVisualStyleBackColor = true;
            this.btn_extend.Click += new System.EventHandler(this.btn_extend_Click);
            // 
            // btn_collapse
            // 
            this.btn_collapse.Location = new System.Drawing.Point(356, 304);
            this.btn_collapse.Name = "btn_collapse";
            this.btn_collapse.Size = new System.Drawing.Size(54, 23);
            this.btn_collapse.TabIndex = 10;
            this.btn_collapse.Text = "-";
            this.btn_collapse.UseVisualStyleBackColor = true;
            this.btn_collapse.Click += new System.EventHandler(this.btn_collapse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 339);
            this.Controls.Add(this.btn_collapse);
            this.Controls.Add(this.btn_extend);
            this.Controls.Add(this.btn_count_full);
            this.Controls.Add(this.btn_xoa_select);
            this.Controls.Add(this.btn_xoa_all);
            this.Controls.Add(this.btn_add_con);
            this.Controls.Add(this.btn_add_goc);
            this.Controls.Add(this.txt_TenNode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tv1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView tv1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TenNode;
        private System.Windows.Forms.Button btn_add_goc;
        private System.Windows.Forms.Button btn_add_con;
        private System.Windows.Forms.Button btn_xoa_all;
        private System.Windows.Forms.Button btn_xoa_select;
        private System.Windows.Forms.Button btn_count_full;
        private System.Windows.Forms.Button btn_extend;
        private System.Windows.Forms.Button btn_collapse;
    }
}

