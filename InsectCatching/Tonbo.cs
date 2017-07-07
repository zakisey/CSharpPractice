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
                picture.Left = rect.Width - picture.Width;
                xdir = -1;
                picture.BackgroundImage = Properties.Resources.dragonfly_left;
            }
            if (picture.Left < 0)
            {
                picture.Left = 0;
                xdir = 1;
                picture.BackgroundImage = Properties.Resources.dragonfly_right;
            }
            if (picture.Top < 0)
            {
                picture.Top = 0;
                ydir = 1;
            }
            if (picture.Bottom > rect.Height)
            {
                picture.Top = rect.Height - picture.Height;
                ydir = -1;
            }

        }

        public override void Init()
        {
            xdir = 1;
            ydir = 1;
            Random rand = new Random();
            xspeed = rand.Next(30);
            yspeed = rand.Next(30);

            picture = new PictureBox();
            picture.Width = 75;
            picture.Height = 69;
            picture.BackgroundImage = Properties.Resources.dragonfly_right;
            picture.Left = 0;
            picture.Top = 0;
        }
    }
}
