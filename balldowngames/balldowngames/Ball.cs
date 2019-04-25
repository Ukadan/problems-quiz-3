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
    class Ball
    {
        
        
            public Graphics g;
            public Point location;
            public int color;
            public SolidBrush brush;
            public Pen pen;
            public string[] colors = { "red", "blue", "yellow", "brown", "green" };
            public int w = 55, h = 55;
            public Ball(Graphics g, Point l, int c)
            {
                this.g = g;
                location = l;
                color = c;

                brush = new SolidBrush(Color.FromName(colors[c]));
                pen = new Pen(Color.FromName(colors[c]), 1);
            }

            public void addBorder()
            {
                pen = new Pen(Color.DarkBlue, 4);
            }

            public void removeBorder()
            {
                pen = new Pen(Color.FromName(colors[color]), 1);
            }

            public void Move()
            {
                location = new Point(location.X, location.Y + 20);
            }

            public bool isIn(Point l)
            {
                if (l.X > location.X && l.X < location.X + w &&
                    l.Y > location.Y && l.Y < location.Y + h)
                    return true;
                return false;
            }

            public void Draw()
            {
                g.FillEllipse(brush, location.X, location.Y, w, h);
                g.DrawEllipse(pen, location.X, location.Y, w, h);
            }
        }
    }

