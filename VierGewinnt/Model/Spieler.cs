using System;
using System.Collections.Generic;
using System.Text;

namespace VierGewinnt
{
    class Spieler
    {
        public bool player1 = false;
        public bool player2 = false;
        public string Name;

        public Spieler(string name)
        {
            Name = name;
        }

        public string getNameP1()
        {
            return "Spieler1";
        }

        public string getNameP2()
        {
            return "Spieler2";
        }

        public void setSpielsteinPos(Spielstein spielstein)
        {
            spielstein.posX = 4;
        }
        
        public void switchPlayer()
        {
            if(player1 == true)
            {
                player1 = false;
                player2 = true;
            } else
            {
                player1 = true;
                player2 = false;
            }
        }

    }
}