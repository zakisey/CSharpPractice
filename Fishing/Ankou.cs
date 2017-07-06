using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Ankou : Fish
    {
        public Ankou(int _left) : base(_left)
        {
            speed = 100.0;
            isMovingAtDay = true;
            isEatingAtDay = true;
            isMovingAtNight = true;
            isEatingAtNight = true;
        }
    }
}
