using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ballup
{
    public partial class Form1 : Form
    {
        private int bw = 30;
        private int bh = 30;
        private int bpx = 0, bpx1 = 60, bpx2 = 120, bpx3 = 180;
        private int bpy = 0, bpy1 = 60, bpy2 = 120, bpy3 = 180;
        private int mStepx = 4;
        private int mStepy = 4, mStepy1 = 4, mStepy2 = 4, mStepy3 = 4;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.Clear(this.BackColor);
            SolidBrush pen = new SolidBrush(Color.Indigo);
            Pen pen1 = new Pen(Color.Indigo);
            e.Graphics.FillEllipse(pen, bpx, bpy, bw, bh);
            e.Graphics.DrawEllipse(pen1, bpx, bpy, bw, bh);

            e.Graphics.FillEllipse(pen, bpx1, bpy1, bw, bh);
            e.Graphics.DrawEllipse(pen1, bpx1, bpy1, bw, bh);

            e.Graphics.FillEllipse(pen, bpx2, bpy2, bw, bh);
            e.Graphics.DrawEllipse(pen1, bpx2, bpy2, bw, bh);

            e.Graphics.FillEllipse(pen, bpx3, bpy3, bw, bh);
            e.Graphics.DrawEllipse(pen1, bpx3, bpy3, bw, bh);

            e.Graphics.FillEllipse(pen, bpx, bpy, bw, bh);
            e.Graphics.DrawEllipse(pen1, bpx, bpy, bw, bh);

            e.Graphics.FillEllipse(pen, bpx, bpy, bw, bh);
            e.Graphics.DrawEllipse(pen1, bpx, bpy, bw, bh);

            e.Graphics.FillEllipse(pen, bpx, bpy, bw, bh);
            e.Graphics.DrawEllipse(pen1, bpx, bpy, bw, bh);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int a = this.ClientSize.Height;
            textBox1.Text = a.ToString();
            bpy += mStepy;
            bpy1 += mStepy1;
            bpy2 += mStepy2;
            bpy3 += mStepy3;

            
            if (bpy < 0 || bpy + bh > this.ClientSize.Height)
            {
                mStepy = -mStepy;
            }

            if (bpy1 < 0 || bpy1 + bh > this.ClientSize.Height)
            {
                mStepy1 = -mStepy1;
            }

            if (bpy2 < 0 || bpy2 + bh > this.ClientSize.Height)
            {
                mStepy2 = -mStepy2;
            }

            if (bpy3 < 0 || bpy3 + bh > this.ClientSize.Height)
            {
                mStepy3 = -mStepy3;
            }


            this.Refresh();
        }
    }
}
