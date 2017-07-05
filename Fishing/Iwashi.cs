using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Iwashi : Fish
    {
        public Iwashi(int x, int y, int width, int height) : base(x, y, width, height)
        {
            speed = 100.0;
            
        }
    }
}
