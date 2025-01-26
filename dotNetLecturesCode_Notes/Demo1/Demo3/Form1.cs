using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstNames.Items.Add("Khaled");
            lstNames.Items.Add("Ahmed");
            lstNames.Items.Add("Sara");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstNames.Items.Add(textBox1.Text);
            textBox1.Text = "";
        }

        private void lstNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text= lstNames.SelectedItem?.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //lstNames.SelectedItem = null;
            int x=lstNames.SelectedIndex;
            lstNames.Items.RemoveAt(x);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstNames.Items.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int x=lstNames.SelectedIndex;
            lstNames.Items[x]=textBox1.Text;
        }
    }
}
