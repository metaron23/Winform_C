using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace True_View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_TenNode.Text))
            {
                bool check = false;
                TreeNode Node = new TreeNode();
                Node.Text = txt_TenNode.Text;
                foreach(TreeNode a in tv1.Nodes)
                {
                    if (String.Equals(Node.Text, a.Text))
                    {
                        MessageBox.Show("Node already exists");
                        check = true;
                    }
                }
                if(check == false)
                {
                    tv1.Nodes.Add(Node);
                }
                txt_TenNode.Clear();
                txt_TenNode.Focus();
            }
            else
            {
                MessageBox.Show("Node cannot be empty!");
            }
        }

        private void btn_add_con_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_TenNode.Text))
            {
                if(tv1.SelectedNode != null)
                {
                    TreeNode subnode = new TreeNode();
                    subnode.Text = txt_TenNode.Text;
                    tv1.SelectedNode.Nodes.Add(subnode);
                    txt_TenNode.Clear();
                    txt_TenNode.Focus();
                }
                else
                {
                    MessageBox.Show("You haven't selected the location to create node");
                }
            }
            else
            {
                MessageBox.Show("Node cannot be empty!");
            }
        }

        private void btn_xoa_all_Click(object sender, EventArgs e)
        {
            tv1.Nodes.Clear();
        }

        private void btn_xoa_select_Click(object sender, EventArgs e)
        {
            if(tv1.SelectedNode != null)
            {
                tv1.SelectedNode.Remove();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn node cần xoá");
            }
        }

        private void btn_extend_Click(object sender, EventArgs e)
        {
            tv1.ExpandAll();
        }

        private void btn_collapse_Click(object sender, EventArgs e)
        {
            tv1.CollapseAll();
        }

        private void btn_count_full_Click(object sender, EventArgs e)
        {
            int n = tv1.GetNodeCount(true);
            MessageBox.Show("Tổng số Node trong TreeView : " + n);
        }
    }
}
