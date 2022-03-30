using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count != 0)
            {
                for (int i = 0; i < listBox1.SelectedItems.Count; i++)
                {
                    listBox2.Items.Add(listBox1.SelectedItems[i].ToString());
                    listBox1.Items.Remove(listBox1.SelectedItems[i]);
                    i--;
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn");
            }
            listBox2.Sorted = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox2.Items.Add(listBox1.Items[i].ToString());
                    listBox1.Items.Remove(listBox1.Items[i]);
                    i--;
                }
            }
            else
            {
                MessageBox.Show("Trống");
            }
            listBox2.Sorted = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.SelectedItems.Count; i++)
            {
                listBox1.Items.Add(listBox2.SelectedItems[i].ToString());
                listBox2.Items.Remove(listBox2.SelectedItems[i]);
                i--;
            }
            listBox1.Sorted = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                listBox1.Items.Add(listBox2.Items[i].ToString());
                listBox2.Items.Remove(listBox2.Items[i]);
                i--;
            }
            listBox1.Sorted = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string item in hoten[cb1.SelectedItem.ToString()])
            {
                listBox1.Items.Add(item);
            }
        }
        Dictionary<string, string[]> hoten = new Dictionary<string, string[]>();
        string[] ten1 = { "Huỳnh Văn A", "Huỳnh Văn B", "Huỳnh Văn C" };
        string[] ten2 = { "Phạm Văn A", "Phạm Văn B", "Phạm Văn C" };
        string[] ten3 = { "Nguyễn Văn A", "Nguyễn Văn B", "Nguyễn Văn C" };
        private void Form1_Load(object sender, EventArgs e)
        {            
            hoten.Add("Huỳnh", ten1);
            hoten.Add("Phạm", ten2);
            hoten.Add("Nguyễn", ten3);
            foreach(string item in hoten.Keys)
            {
                cb1.Items.Add(item);
            }
        }
    }
}
