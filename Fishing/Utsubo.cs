using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Utsubo : Fish
    {
        public Utsubo(int _left) : base (_left)
        {
            speed = 100.0;
            isMovingAtDay = true;
            isEatingAtDay = true;
            isMovingAtNight = false;
            isEatingAtNight = false;
        }
    }
}
