﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Iwashi : Fish
    {
        public Iwashi(int left) : base(left)
        {
            speed = 200.0;
            isMovingAtDay = true;
            isEatingAtDay = true;
            isMovingAtNight = true;
            isEatingAtNight = false;
        }
    }
}
