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
        }
        int x = 0;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.FillEllipse(Brushes.Red, x, 50,50,50);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled=!timer1.Enabled;
            if (timer1.Enabled)
                button1.Text = "Stop";
            else
                button1.Text = "Start";
        }
        bool flag = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag == true)
                x += 5;
            if (flag == false)
                x -= 5;
            if(flag==true && x>this.ClientSize.Width-50)
                flag = false;
            if(flag == false&& x<0)
                flag = true;
            this.Invalidate();
            this.Text=x.ToString();
        }
    }
}
