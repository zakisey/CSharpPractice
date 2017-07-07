using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsectCatching
{
    class Butterfly : Insect
    {
        public Butterfly(Form form): base(form)
        {
        }

        public override void Move()
        {
            if (picture.Right > rect.Width)
            {
                xdir = -1;
                picture.BackgroundImage = Properties.Resources.butterfly_left;
            }
            if (picture.Left < 0)
            {
                xdir = 1;
                picture.BackgroundImage = Properties.Resources.butterfly_right;
            }
            if (picture.Top < 0)
            {
                ydir = 1;
            }
            if (picture.Bottom > rect.Height)
            {
                ydir = -1;
            }

            Random rand = new Random();
            xspeed = rand.Next(30);
            yspeed = rand.Next(30);
            int dx = xspeed * xdir;
            int dy = yspeed * ydir;
            picture.Left += dx;
            picture.Top += dy;
        }

        public override void Init()
        {
            xdir = 1;
            ydir = -1;
            picture = new PictureBox();
            picture.BackgroundImage = Properties.Resources.butterfly_right;
            picture.Width = 75;
            picture.Height = 71;
            picture.Left = 0;
            picture.Top = rect.Height - picture.Height;
        }
    }
}
