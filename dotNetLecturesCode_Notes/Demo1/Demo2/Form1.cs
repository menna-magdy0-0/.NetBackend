using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Khaled", "Name", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    this.Text = "yes";
            //}
            //else
            //{
            //    this.Text = "no";
            //}
            Form2 frm = new Form2();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.Text = frm.MyName;

            }
            else
            {
                this.Text = "Cancel";
            }

        }
    }
}
