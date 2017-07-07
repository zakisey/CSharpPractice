using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsectCatching
{
    class Kabuto : Insect
    {
        const int sizeSmaller = 67;
        const int sizeBigger = 75;

        public Kabuto(Form form) : base(form)
        {
        }

        public override void Move()
        {
            if (picture.Right > rect.Width)
            {
                picture.Left = rect.Width - picture.Width;
                xdir = 0;
                ydir = -1;
                picture.BackgroundImage = Properties.Resources.beetle_up;
                ChangeSize(sizeSmaller, sizeBigger);
            }
            if (picture.Left < 0)
            {
                picture.Left = 0;
                xdir = 0;
                ydir = 1;
                picture.BackgroundImage = Properties.Resources.beetle_down;
                ChangeSize(sizeSmaller, sizeBigger);
            }
            if (picture.Top < 0)
            {
                picture.Top = 0;
                xdir = -1;
                ydir = 0;
                picture.BackgroundImage = Properties.Resources.beetle_upsidedown;
                ChangeSize(sizeBigger, sizeSmaller);
            }
            if (picture.Bottom > rect.Height)
            {
                picture.Top = rect.Height - picture.Height;
                xdir = 1;
                ydir = 0;
                picture.BackgroundImage = Properties.Resources.beetle_right;
                ChangeSize(sizeBigger, sizeSmaller);
            }
            int dx = xdir * xspeed;
            int dy = ydir * yspeed;
            picture.Left += dx;
            picture.Top += dy;
        }

        private void ChangeSize(int width, int height)
        {
            picture.Width = width;
            picture.Height = height;
        }

        public override void Init()
        {
            xdir = 0;
            ydir = -1;
            Random rand = new Random();
            xspeed = rand.Next(30);
            yspeed = rand.Next(30);
            picture = new PictureBox();
            picture.BackgroundImage = Properties.Resources.beetle_up;
            ChangeSize(sizeSmaller, sizeBigger);
            picture.Left = rect.Right - picture.Width;
            picture.Top = rect.Height - picture.Height;
        }


    }
}
