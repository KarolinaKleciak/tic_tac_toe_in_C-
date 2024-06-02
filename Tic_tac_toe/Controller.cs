using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_tac_toe
{
    internal class Controller
    {

        public int playerId {  get; set; }
        public int initialPlayerId { get; set; }

        public Controller() { }

        public int randomPlayer() 
        {
            Random rnd = new Random();
            this.playerId = rnd.Next(2);
            this.showMessageBox(this.playerId);
            this.initialPlayerId = this.playerId;
            return this.playerId;
        }

        public void showMessageBox(int playerId)
        {
            if (playerId == 0)
            {
                System.Windows.Forms.MessageBox.Show("Player: O start the game !");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Player: X start the game !");
            }
        }

        public String getPlayerSign()
        {
            if (this.playerId == 0)
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }

        public void changePlayer()
        {
            if (this.playerId == 1) 
            { 
                this.playerId = 0; 
            }
            else
            {
                this.playerId = 1;
            }
        }


        public String getInitialPlayerSign()
        {
            if (this.initialPlayerId == 0)
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }













    }
}
