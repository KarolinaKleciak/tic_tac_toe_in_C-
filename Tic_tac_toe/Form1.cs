namespace Tic_tac_toe
{
    public partial class Form1 : Form
    {
        Controller controller;
        public Form1()
        {
            InitializeComponent();
            this.controller = new Controller();
        }
        private void tictacbutton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Text = this.controller.getPlayerSign();
            btn.Enabled = false;

            if (!this.checkWin())
            {
                this.checkDeaw();
            }

            this.controller.changePlayer();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            this.controller.randomPlayer();
            this.enableAllButtons();
            this.switchColorButtons();
          
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Game reset. Start player:  " + this.controller.getInitialPlayerSign());

            this.controller.playerId = this.controller.initialPlayerId;
            this.enableAllButtons();
            this.switchColorButtons();

            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
        }
        private void enableAllButtons()
        {
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
        }
        private void disableAllButtons()
        {
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
        }
        private void switchColorButtons()
        {
            button4.BackColor = Color.WhiteSmoke;
            button5.BackColor = Color.WhiteSmoke;
            button6.BackColor = Color.WhiteSmoke;
            button7.BackColor = Color.WhiteSmoke;
            button8.BackColor = Color.WhiteSmoke;
            button9.BackColor = Color.WhiteSmoke;
            button10.BackColor = Color.WhiteSmoke;
            button11.BackColor = Color.WhiteSmoke;
            button12.BackColor = Color.WhiteSmoke;
        }
        private bool checkWin()
        {
            if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (button4.Text != ""))
            {
                this.makeWinButtons(button4, button5, button6);
                if (((button4.Text == "X") && (button5.Text == "X") && (button6.Text == "X")) || ((button4.Text == "O") && (button5.Text == "O") && (button6.Text == "O")))
                {
                    this.winnerMessageBox();
                    this.disableAllButtons();
                    return true;
                }
            }
            else if ((button8.Text == button7.Text) && (button7.Text == button9.Text) && (button8.Text != ""))
            {
                this.makeWinButtons(button8, button7, button9);
                if (((button8.Text == "X") && (button7.Text == "X") && (button9.Text == "X")) || ((button8.Text == "O") && (button7.Text == "O") && (button9.Text == "O")))
                {
                    this.winnerMessageBox();
                    this.disableAllButtons();
                    return true;
                }
            }
            else if ((button10.Text == button11.Text) && (button11.Text == button12.Text) && (button10.Text != ""))
            {
                this.makeWinButtons(button10, button11, button12);
                if (((button10.Text == "X") && (button11.Text == "X") && (button12.Text == "X")) || ((button10.Text == "O") && (button11.Text == "O") && (button12.Text == "O")))
                {
                    this.winnerMessageBox();
                    this.disableAllButtons();
                    return true;
                }
            }
            else if ((button4.Text == button8.Text) && (button8.Text == button10.Text) && (button4.Text != ""))
            {
                this.makeWinButtons(button4, button8, button10);
                if (((button4.Text == "X") && (button8.Text == "X") && (button10.Text == "X")) || ((button4.Text == "O") && (button8.Text == "O") && (button10.Text == "O")))
                {
                    this.winnerMessageBox();
                    this.disableAllButtons();
                    return true;
                }
            }
            else if ((button5.Text == button7.Text) && (button7.Text == button11.Text) && (button5.Text != ""))
            {
                this.makeWinButtons(button5, button7, button11);
                if (((button5.Text == "X") && (button7.Text == "X") && (button11.Text == "X")) || ((button6.Text == "O") && (button7.Text == "O") && (button11.Text == "O")))
                {
                    this.winnerMessageBox();
                    this.disableAllButtons();
                    return true;
                }
            }
            else if ((button6.Text == button9.Text) && ( button9.Text == button12.Text) && (button6.Text != ""))
            {
                this.makeWinButtons(button6, button9, button12);
                if (((button6.Text == "X") && (button9.Text == "X") && (button12.Text == "X")) || ((button6.Text == "O") && (button9.Text == "O") && (button12.Text == "O")))
                {
                    this.winnerMessageBox();
                    this.disableAllButtons();
                    return true;
                }
            }
            else if ((button4.Text == button7.Text) && (button7.Text == button12.Text) && (button4.Text != ""))
            {
                this.makeWinButtons(button4, button7, button12);
                if (((button4.Text == "X") && (button7.Text == "X") && (button12.Text == "X")) || ((button4.Text == "O") && (button7.Text == "O") && (button12.Text == "O")))
                {
                    this.winnerMessageBox();
                    this.disableAllButtons();
                    return true;
                }
            }
            else if ((button6.Text == button7.Text) && (button7.Text == button10.Text) && (button6.Text != ""))
            {
                this.makeWinButtons(button6, button7, button10);
                if (((button6.Text == "X") && (button7.Text == "X") && (button10.Text == "X")) || ((button6.Text == "O") && (button7.Text == "O") && (button10.Text == "O")))
                {
                    this.winnerMessageBox();
                    this.disableAllButtons();
                    return true;
                }
            }
            return false;
        }
        private void makeWinButtons(Button button1, Button button2, Button button3)
        {
            button1.BackColor = Color.LimeGreen;
            button2.BackColor = Color.LimeGreen;
            button3.BackColor = Color.LimeGreen;
        }
        private void makeDrawButtons()
        {
            button4.BackColor = Color.DarkRed;
            button5.BackColor = Color.DarkRed;
            button6.BackColor = Color.DarkRed;
            button7.BackColor = Color.DarkRed;
            button8.BackColor = Color.DarkRed;
            button9.BackColor = Color.DarkRed;
            button10.BackColor = Color.DarkRed;
            button11.BackColor = Color.DarkRed;
            button12.BackColor = Color.DarkRed;
        }
        private void winnerMessageBox()
        {
            System.Windows.Forms.MessageBox.Show("The winner is:  " + this.controller.getInitialPlayerSign() + " ! ");
        }
        private void drawMessageBox()
        {
            System.Windows.Forms.MessageBox.Show("Draw !");
        }
        private void checkDeaw()
        {
            if ((button4.Text != "") && (button5.Text != "") && (button6.Text != "") && (button6.Text != "") && (button7.Text != "") && (button8.Text != "") && (button9.Text != "") && (button10.Text != "") && (button11.Text != "") && (button12.Text != ""))
            {
                this.makeDrawButtons();
                this.drawMessageBox();
            }
        }
    }
}
