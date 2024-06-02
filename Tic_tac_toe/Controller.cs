using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_tac_toe
{
    internal class Controller
    {

        int playerId;

        public Controller() { }

        public int randomPlayer() 
        {
            Random rnd = new Random();
            playerId = rnd.Next(2);

            if (playerId == 0)
            {
                System.Windows.Forms.MessageBox.Show("Player: O start the game !");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Player: X start the game !");
            }
            return playerId;
        }













    }
}
