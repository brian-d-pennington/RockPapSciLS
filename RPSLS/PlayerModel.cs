using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class PlayerModel
    {
        public string playerName;
        public int playerPoints;

        public PlayerModel()
        {
            playerName = "no name yet";
            playerPoints = 0;
        }

    }
}
