using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace minesweeper
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen p;
        Point size = new Point();
        public Form1()
        {
            InitializeComponent();
            g = pnlCanvas.CreateGraphics();
            p = new Pen(Color.Red);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pnlCanvas_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            size.X = (int)numWidth.Value;
            size.Y = (int)numHeight.Value;
        }
    }
}
