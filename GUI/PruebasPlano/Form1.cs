using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PruebasPlano
{
    
    public partial class Form1 : Form
    {
        private const int Meter = 30;
        private Graphics graphic;

        public Form1()
        {
            InitializeComponent();
            this.graphic = this.panel.CreateGraphics();
            //this.CreateGrilla(0, 0);
        }

        private void DrawLine(Pen pen,Point x,Point y)
        {
            this.graphic.DrawLine(pen, x.X, x.Y, y.X, y.Y);
        }

        private void CreateGrilla(int x, int y)
        {
            Point X = new Point(0, 0);
            Point Y = new Point(100, 0);
            Pen pen = new Pen(Color.Black, 2);
            this.DrawLine(pen, X, Y);
            this.panel.Refresh();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 1);
            this.graphic.DrawLine(pen, 0, 0, 1200, 0);
            this.graphic.DrawLine(pen, 1200, 0, 1200, 1200);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
