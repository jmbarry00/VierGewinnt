using System;
using System.Collections.Generic;
using System.Text;
using VierGewinnt.Model;

namespace VierGewinnt
{
    class Spielfeld
    {
        public int SpaltenX;
        public int ZeilenY;


        public Spielfeld(int x, int y)
        {
            SpaltenX = x;
            ZeilenY = y;
            int[,] feld = new int[SpaltenX, ZeilenY];
            Spieler player = new Spieler();
            player.player1 = true;

        }

        private void aufSiegPruefen()
        {

        }

        private bool feldIstBesetzt(int X, int Y)
        {
            return false;
        }
    }
}
