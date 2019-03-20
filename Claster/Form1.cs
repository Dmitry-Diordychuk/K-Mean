using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kmean
{
    public partial class Form1 : Form
    {
        Kmean graph = new Kmean();
        List<PictureBox> BluePoints = new List<PictureBox>(); //Или все в Controls?
        List<PictureBox> RedPoints = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox bluePoint = new PictureBox();
                PictureSettings(e, bluePoint, "img/BluePoint.png");
                Controls.Add(bluePoint);

                CPoint point = new CPoint(e.X, e.Y);
                graph.AddPoint(point);
            }
            else if (e.Button == MouseButtons.Right)
            {
                PictureBox redPoint = new PictureBox();
                PictureSettings(e, redPoint, "img/RedPoint.png");
                Controls.Add(redPoint);

                Claster claster = new Claster(e.X, e.Y);
                graph.AddClaster(claster);
            }
        }
        private static void PictureSettings(MouseEventArgs e, PictureBox bluePoint, string path)
        {
            bluePoint.Location = new Point(e.X - 10, e.Y - 10);
            bluePoint.SizeMode = PictureBoxSizeMode.StretchImage;
            bluePoint.Size = new Size(25, 25);
            var MyImage = new Bitmap(path);
            bluePoint.Image = (Image)MyImage;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //timer1.Start();
            Graphics graphics = CreateGraphics();
            Kmean.Partitioning(graph);
            foreach (var claster in graph.clasters)
            {
                foreach (var edge in claster.edges)
                {
                    graphics.DrawLine(Pens.Black, claster.Location.ToPoint(), edge.Item1.ToPoint());
                }
            }
            Kmean.FindCentroid(graph);
            Kmean.AllMoveToCentroid(graph);
        }
    }
}
