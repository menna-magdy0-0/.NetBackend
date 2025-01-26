using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.BackColor=Color.Red;
            //this is object from form1 
            //this.Text = "khaled";
            //this.Click += myfun;
            //add controls 
            //Button btn =new Button();
            //btn.Text= "save";
            //btn.Width = 100;
            //btn.Height = 100;
            //btn.BackColor=Color.Yellow;
            //btn.ForeColor=Color.Black;
            //btn.Location=new Point(100,100);
            //this.Controls.Add(btn);

        }
        //event handler 
        private void button1_Click(object sender, EventArgs e)
        {
            //object sender is Button 
            this.Text = txtAge.Text;
        }

        private void txtAge_Click(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            txtbdate.Text = txtAge.Text;
        }

        private void txtAge_TextChanged_1(object sender, EventArgs e)
        {
            txtbdate.Text = txtAge.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult d= MessageBox.Show(txtbdate.Text,"welcome",MessageBoxButtons.YesNoCancel);
            if (d == DialogResult.Yes)
            {
                this.Text = "yes";
            }
            else if (d == DialogResult.No)
            {
                this.Text = "no";
            }
            else if(d == DialogResult.Cancel)
            {
                this.Text= "Cancel";
            }
        }

        private void txtbdate_TextChanged(object sender, EventArgs e)
        {

        }
        //public void myfun(object sender , EventArgs e)
        //{
        //    this.Text = "clicked";
        //}
    }
}
