﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Janken
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManager gm = new GameManager();
            gm.AskMembers();

            while (true)
            {
                while (true)
                {
                    gm.AskPlayerHands();
                    gm.SetComputerHands();
                    if(!gm.ShowResult())
                    {
                        break;
                    }
                }
                if(gm.AskQuit())
                {
                    break;
                }
            }
        }
    }
}