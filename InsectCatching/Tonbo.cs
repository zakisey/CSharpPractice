using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsectCatching
{
    class Tonbo : Insect
    {
        public Tonbo(Form form) : base(form)
        {
        }

        public override void Move()
        {
            int dx = xdir * xspeed;
            int dy = ydir * yspeed;
            picture.Left += dx;
            picture.Top += dy;
            if (picture.Right > rect.Width)
            {
                xdir = -1;
            }
            if (picture.Left < 0)
            {
                xdir = 1;
            }
            if (picture.Top < 0)
            {
                ydir = 1;
            }
            if (picture.Bottom > rect.Height)
            {
                ydir = -1;
            }
        }

        public override void Init()
        {
            Console.WriteLine(rect);
            xdir = 1;
            ydir = 1;
            Random rand = new Random();
            xspeed = xdir * rand.Next(30);
            yspeed = ydir * rand.Next(30);
            Console.WriteLine(xspeed);
            Console.WriteLine(yspeed);
            picture = new PictureBox();
            picture.Left = -30;
            picture.Top = 50;
            picture.Width = 50;
            picture.Height = 50;
            picture.BackColor = Color.Black;
        }
    }
}
