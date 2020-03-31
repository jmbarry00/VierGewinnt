using System;
using System.Collections.Generic;
using System.Text;

namespace VierGewinnt
{
    class Spielfeld
    {
        int SpaltenX;
        int ZeilenY;
        
        public Spielfeld(int x, int y)
        {
            SpaltenX = x;
            ZeilenY = y;
            int[,] feld = new int[SpaltenX, ZeilenY];
            Spieler player = new Spieler("");
            player.player1 = true;

        }
    }
}
