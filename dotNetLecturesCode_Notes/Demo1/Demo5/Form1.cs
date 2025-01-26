using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics graphics=this.CreateGraphics();
            if(e.Button == MouseButtons.Left )
                graphics.FillEllipse(Brushes.Red, e.X, e.Y,10,10);
            else if(e.Button == MouseButtons.Right )
            {
                SolidBrush solidBrush=new SolidBrush(this.BackColor);
                graphics.FillEllipse(solidBrush, e.X, e.Y, 10, 10);
            }
                
        }
    }
}
