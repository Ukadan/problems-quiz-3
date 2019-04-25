using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bigStar
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            Draw();
            timer1.Start();
            
        }
        void Draw()
        {
            Bitmap bmp = new Bitmap(picture.Width, picture.Height);
            Graphics graph = Graphics.FromImage(bmp);
            graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            picture.Image = bmp;
            SolidBrush pen = new SolidBrush(Color.DarkGreen);
            graph.FillPolygon(pen,points);
            graph.FillPolygon(pen, points1);

            

        }
        readonly Point[] points = new Point[]
        {
            new Point(180+b, 300+a),  //A
            new Point(165+b, 320+a),  //B
            new Point(195+b, 320+a)   //C
        };

        readonly Point[] points1 = new Point[]
        {
            new Point(180+b, 330+a),  //A
            new Point(165+b, 310+a),  //B
            new Point(195+b, 310+a)   //C
        };
        readonly Point[] point = new Point[]
            {
                //new Point(280, 200),
                //new Point(290, 220),
                //new Point(310, 230),
                //new Point(295, )
                //new Point(265, 223),  
                //new Point(295, 223),   
                  
            };
        private static int b = 0;
        private static int a = 0;

        private void Start_Click(object sender, EventArgs e)
        {

        }

        private void Picture_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            a += 20;
            b += 15;
            Refresh();

        }

        private void Stop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
