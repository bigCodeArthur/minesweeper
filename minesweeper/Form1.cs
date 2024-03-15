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
        Size size = new Size();
        grid gr;
        public Form1()
        {
            InitializeComponent();
            g = pnlCanvas.CreateGraphics();
            p = new Pen(Color.Red);
        }

        private void pnlCanvas_Click(object sender, EventArgs e)
        {
            g.Clear(SystemColors.ButtonShadow);
            visuals.drawField(g, p, size, pnlCanvas.Size, gr);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            g.Clear(SystemColors.ButtonShadow);
            size.Width = (int)numWidth.Value;
            size.Height = (int)numHeight.Value;
            gr = new grid((int)numWidth.Value, (int)numHeight.Value);
            visuals.drawField(g, p, size, pnlCanvas.Size, gr);
        }
    }
}
