using System;
using System.Collections.Generic;
using System.Text;

namespace cardGameSix
{
    class Player
    {
        String name;
        PlayerHand playerHand = new PlayerHand();
       
        public PlayerHand GetHand()
        {
            return playerHand;
        }

       
    }
}
