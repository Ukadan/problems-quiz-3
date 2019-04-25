using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace balldowngames
{
    public partial class Form1 : Form
    {
        List<Ball> list;
        Graphics g;
        Random r;
        int cnt, score = 0, outBalls = 0;
        Ball prev, cur;
        public Form1()
        {
            //this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            //Ball bl = new Ball();
            InitializeComponent();
            g = CreateGraphics();
            r = new Random();
            cnt = 0;
            prev = cur = null;

            list = new List<Ball>();

            timer2.Interval = 300;

            Width = 520;
            Height = 520;
        }

     
        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            timer2.Start();
            button1.Visible = false;
        }

        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            Point clickedPoint = e.Location;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].isIn(clickedPoint))
                {
                    if (prev == list[i])
                    {
                        list[i].removeBorder();
                        prev = null;
                        break;
                    }
                    else if (prev == null)
                    {
                        list[i].addBorder();
                        prev = list[i];
                        break;
                    }
                    else
                    {
                        cur = list[i];
                        break;
                    }
                }
            }
            if (prev != null && cur != null)
            {
                if (prev.color == cur.color)
                {
                    list.Remove(prev);
                    list.Remove(cur);
                    score++;
                    label1.Text = $"Score: {score}";
                    if (score == 3)
                    {
                        timer2.Enabled = false;
                        MessageBox.Show($"Your score: {score}\nLevel 2");
                        timer2.Interval = 150;
                        timer2.Start();
                    }
                }
                else
                {
                    list[list.IndexOf(prev)].removeBorder();
                }
                prev = cur = null;

            }
        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            foreach (Ball b in list)
                b.Draw();
        }

        private void Timer2_Tick_1(object sender, EventArgs e)
        {
            foreach (Ball b in list)
                b.Move();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].location.Y > Height - 50)
                {
                    list.Remove(list[i]);
                    outBalls++;
                    label2.Text = $"Out: {outBalls}";
                    if (outBalls == 20)
                    {
                        timer2.Enabled = false;
                        MessageBox.Show("Game Over!!!");
                    }
                }

            }

            int color = r.Next(5);
            if (cnt % 3 == 0)
                list.Add(new Ball(g, new Point(r.Next(80, Width - 80), 0), color));


            cnt++;

            Refresh();
        }

        

        

        
    }
}
