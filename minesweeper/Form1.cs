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
        Random rng = new Random();
        Graphics g;
        Pen p;
        Size size = new Size();
        grid gr;
        public Form1()
        {
            InitializeComponent();
            g = pnlCanvas.CreateGraphics();
            p = new Pen(Color.DarkOliveGreen);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            generateField();
        }
        private void generateField()
        {
            size.Width = (int)numWidth.Value;
            size.Height = (int)numHeight.Value;
            gr = new grid(size.Width, size.Height);
            functionality.spreadMines(gr, rng, gr.allBombs);
            visuals.drawField(g, p, size, pnlCanvas.Size, gr);
        }
        private void pnlCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (gr != null)
            {
                if (functionality.dig(e.Location, gr, pnlCanvas.Size)) 
                    if (MessageBox.Show("BOOM!", "XXX", MessageBoxButtons.RetryCancel) == DialogResult.Retry) generateField();
                    else Application.Exit();
                if (functionality.winConCheck(gr)) 
                    if (MessageBox.Show("YIPPIE!", "XXX", MessageBoxButtons.RetryCancel) == DialogResult.Retry) generateField();
                    else Application.Exit();
                visuals.drawField(g, p, size, pnlCanvas.Size, gr);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            g = pnlCanvas.CreateGraphics();
            if (gr != null) visuals.drawField(g, p, size, pnlCanvas.Size, gr);
        }

        private void Form1_Validated(object sender, EventArgs e)
        {
            g = pnlCanvas.CreateGraphics();
            if (gr != null) visuals.drawField(g, p, size, pnlCanvas.Size, gr);
        }
    }
}
