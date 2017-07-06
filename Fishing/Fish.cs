using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Fish
    {
        public int left;
        protected double speed;
        protected bool isMovingAtDay;
        protected bool isMovingAtNight;
        protected bool isEatingAtDay;
        protected bool isEatingAtNight;

        public Fish(int _left)
        {
            left = _left;
        }

        public void Move(bool isAtDay, double timeSpan)
        {
            if ((isAtDay && isMovingAtDay) || (!isAtDay && isMovingAtNight))
            {
                left += (int)(timeSpan * speed);
            }
        }

        public bool TryBite(bool isAtDay, int offset)
        {
            if ((isAtDay && isEatingAtDay) || (!isAtDay && isEatingAtNight))
            {;
                if (offset >= 0 && offset <= 30)
                {
                    Respawn();
                    return true;
                }
            }
            return false;
        }

        public void Respawn()
        {
            left = -200;
        }
    }
}
