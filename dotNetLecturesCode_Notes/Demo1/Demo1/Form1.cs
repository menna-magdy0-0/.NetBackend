using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btn_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                txtValue.Text = "0";
                flag = true;
            }
            if (txtValue.Text == "0")
                txtValue.Text = "";
            //txtValue.Text += "1";
            txtValue.Text += (sender as Button).Text;
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                txtValue.Text = "0";
                flag = true;
            }
            if (txtValue.Text.IndexOf(".")==-1)
                txtValue.Text += ".";

        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtValue.Text = "0";
        }
        float x = 0;
        float y = 0;
        float res = 0;
        char op = '\0';
        bool flag=true;
        private void op_Click(object sender, EventArgs e)
        {
            
            op=char.Parse((sender as Button).Text);
            x=float.Parse(txtValue.Text);
            //txtValue.Text = "0";
            flag = false;

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            y=float.Parse(txtValue.Text);
            switch (op)
            {
                case '+':
                    res = x + y;
                    break;
                case '-':
                    res = x - y;
                    break;
                case '*':
                    res = x * y;
                    break;
                case '/':
                    res = x / y;
                    break;

            }
            txtValue.Text=res.ToString();


        }
    }
}
