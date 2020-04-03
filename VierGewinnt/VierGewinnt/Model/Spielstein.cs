using System;
using System.Collections.Generic;
using System.Text;

namespace VierGewinnt.Model
{
    class Spielstein
    {
        public int posX;
        public int posY;

        public void steinSetzen(int posx, int posy)
        {
            posX = posx;
            posY = posy;
        }
    }
}
