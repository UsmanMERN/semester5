using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.FillRectangle(Brushes.Gray, 90, 50, 40, 150);

            DrawTrafficLight(g, Color.Red, 100, 60);

            DrawTrafficLight(g, Color.Yellow, 100, 100);

            DrawTrafficLight(g, Color.Green, 100, 140);
        }
        private void DrawTrafficLight(Graphics g, Color color, int x, int y)
        {
            SolidBrush myBrush = new SolidBrush(color);
            g.FillEllipse(myBrush, x, y, 20, 20);

            g.DrawEllipse(Pens.Black, x, y, 20, 20);
        }
    }
}
