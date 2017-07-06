using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsectCatching
{
    abstract class Insect
    {
        protected PictureBox picture;
        protected Rectangle rect;
        protected int xdir;
        protected int ydir;
        protected int xspeed;
        protected int yspeed;
        public abstract void Move();
        public abstract void Init();

        public Insect(Form form)
        {
            rect = form.Bounds;
            Init();
            AddToForm(form);
        }

        private void AddToForm(Form form)
        {
            form.Controls.Add(picture);
        }
    }
}
