using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Fish
    {
        private System.Windows.Forms.PictureBox picture;
        protected double speed;
        private List<int> baitKeys;
        private bool isActiveAtDay;
        private bool isActiveAtNight;

        public Fish(int x, int y, int width, int height)
        {
            isActiveAtDay = true;
            isActiveAtNight = true;
            picture = new System.Windows.Forms.PictureBox();
            picture.SetBounds(x, y, width, height);
            picture.BackColor = System.Drawing.Color.Black;
        }

        public void AddToForm(System.Windows.Forms.Form form)
        {
            form.Controls.Add(picture);
        }

        public void Move(double timeSpan)
        {
            picture.Left += (int)(timeSpan * speed);
        }

        public void TryBite(bool isAtDay, int baitPosX)
        {

        }
    }
}
