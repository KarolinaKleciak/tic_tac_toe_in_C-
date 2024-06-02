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
            this.playerButton.Text = this.controller.getPlayerSign();
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
            this.playerButton.Text = controller.getPlayerSign();

            ticTacToeButton1.Text = "";
            ticTacToeButton2.Text = "";
            ticTacToeButton3.Text = "";
            ticTacToeButton4.Text = "";
            ticTacToeButton5.Text = "";
            ticTacToeButton6.Text = "";
            ticTacToeButton7.Text = "";
            ticTacToeButton8.Text = "";
            ticTacToeButton9.Text = "";
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Game reset. Start player: " + this.controller.getInitialPlayerSign());

            this.controller.playerId = this.controller.initialPlayerId;
            this.enableAllButtons();
            this.switchColorButtons();
            this.playerButton.Text = controller.getPlayerSign();

            ticTacToeButton1.Text = "";
            ticTacToeButton2.Text = "";
            ticTacToeButton3.Text = "";
            ticTacToeButton4.Text = "";
            ticTacToeButton5.Text = "";
            ticTacToeButton6.Text = "";
            ticTacToeButton7.Text = "";
            ticTacToeButton8.Text = "";
            ticTacToeButton9.Text = "";
        }
        private void enableAllButtons()
        {
            ticTacToeButton1.Enabled = true;
            ticTacToeButton2.Enabled = true;
            ticTacToeButton3.Enabled = true;
            ticTacToeButton4.Enabled = true;
            ticTacToeButton5.Enabled = true;
            ticTacToeButton6.Enabled = true;
            ticTacToeButton7.Enabled = true;
            ticTacToeButton8.Enabled = true;
            ticTacToeButton9.Enabled = true;
        }
        private void disableAllButtons()
        {
            ticTacToeButton1.Enabled = false;
            ticTacToeButton2.Enabled = false;
            ticTacToeButton3.Enabled = false;
            ticTacToeButton4.Enabled = false;
            ticTacToeButton5.Enabled = false;
            ticTacToeButton6.Enabled = false;
            ticTacToeButton7.Enabled = false;
            ticTacToeButton8.Enabled = false;
            ticTacToeButton9.Enabled = false;
        }
        private void switchColorButtons()
        {
            ticTacToeButton1.BackColor = Color.WhiteSmoke;
            ticTacToeButton2.BackColor = Color.WhiteSmoke;
            ticTacToeButton3.BackColor = Color.WhiteSmoke;
            ticTacToeButton4.BackColor = Color.WhiteSmoke;
            ticTacToeButton5.BackColor = Color.WhiteSmoke;
            ticTacToeButton6.BackColor = Color.WhiteSmoke;
            ticTacToeButton7.BackColor = Color.WhiteSmoke;
            ticTacToeButton8.BackColor = Color.WhiteSmoke;
            ticTacToeButton9.BackColor = Color.WhiteSmoke;
        }
        private bool checkWin()
        {
            if ((ticTacToeButton1.Text == ticTacToeButton2.Text) && (ticTacToeButton2.Text == ticTacToeButton3.Text) && (ticTacToeButton1.Text != ""))
            {
                this.makeWinButtons(ticTacToeButton1, ticTacToeButton2, ticTacToeButton3);
                if (((ticTacToeButton1.Text == "X") && (ticTacToeButton2.Text == "X") && (ticTacToeButton3.Text == "X")) || ((ticTacToeButton1.Text == "O") && (ticTacToeButton2.Text == "O") && (ticTacToeButton3.Text == "O")))
                {
                    this.winnerMessageBox();
                    this.disableAllButtons();
                    return true;
                }
            }
            else if ((ticTacToeButton5.Text == ticTacToeButton4.Text) && (ticTacToeButton4.Text == ticTacToeButton6.Text) && (ticTacToeButton5.Text != ""))
            {
                this.makeWinButtons(ticTacToeButton5, ticTacToeButton4, ticTacToeButton6);
                if (((ticTacToeButton5.Text == "X") && (ticTacToeButton4.Text == "X") && (ticTacToeButton6.Text == "X")) || ((ticTacToeButton5.Text == "O") && (ticTacToeButton4.Text == "O") && (ticTacToeButton6.Text == "O")))
                {
                    this.winnerMessageBox();
                    this.disableAllButtons();
                    return true;
                }
            }
            else if ((ticTacToeButton7.Text == ticTacToeButton8.Text) && (ticTacToeButton8.Text == ticTacToeButton9.Text) && (ticTacToeButton7.Text != ""))
            {
                this.makeWinButtons(ticTacToeButton7, ticTacToeButton8, ticTacToeButton9);
                if (((ticTacToeButton7.Text == "X") && (ticTacToeButton8.Text == "X") && (ticTacToeButton9.Text == "X")) || ((ticTacToeButton7.Text == "O") && (ticTacToeButton8.Text == "O") && (ticTacToeButton9.Text == "O")))
                {
                    this.winnerMessageBox();
                    this.disableAllButtons();
                    return true;
                }
            }
            else if ((ticTacToeButton1.Text == ticTacToeButton5.Text) && (ticTacToeButton5.Text == ticTacToeButton7.Text) && (ticTacToeButton1.Text != ""))
            {
                this.makeWinButtons(ticTacToeButton1, ticTacToeButton5, ticTacToeButton7);
                if (((ticTacToeButton1.Text == "X") && (ticTacToeButton5.Text == "X") && (ticTacToeButton7.Text == "X")) || ((ticTacToeButton1.Text == "O") && (ticTacToeButton5.Text == "O") && (ticTacToeButton7.Text == "O")))
                {
                    this.winnerMessageBox();
                    this.disableAllButtons();
                    return true;
                }
            }
            else if ((ticTacToeButton2.Text == ticTacToeButton4.Text) && (ticTacToeButton4.Text == ticTacToeButton8.Text) && (ticTacToeButton2.Text != ""))
            {
                this.makeWinButtons(ticTacToeButton2, ticTacToeButton4, ticTacToeButton8);
                if (((ticTacToeButton2.Text == "X") && (ticTacToeButton4.Text == "X") && (ticTacToeButton8.Text == "X")) || ((ticTacToeButton2.Text == "O") && (ticTacToeButton4.Text == "O") && (ticTacToeButton8.Text == "O")))
                {
                    this.winnerMessageBox();
                    this.disableAllButtons();
                    return true;
                }
            }
            else if ((ticTacToeButton3.Text == ticTacToeButton6.Text) && (ticTacToeButton6.Text == ticTacToeButton9.Text) && (ticTacToeButton3.Text != ""))
            {
                this.makeWinButtons(ticTacToeButton3, ticTacToeButton6, ticTacToeButton9);
                if (((ticTacToeButton3.Text == "X") && (ticTacToeButton6.Text == "X") && (ticTacToeButton9.Text == "X")) || ((ticTacToeButton3.Text == "O") && (ticTacToeButton6.Text == "O") && (ticTacToeButton9.Text == "O")))
                {
                    this.winnerMessageBox();
                    this.disableAllButtons();
                    return true;
                }
            }
            else if ((ticTacToeButton1.Text == ticTacToeButton4.Text) && (ticTacToeButton4.Text == ticTacToeButton9.Text) && (ticTacToeButton1.Text != ""))
            {
                this.makeWinButtons(ticTacToeButton1, ticTacToeButton4, ticTacToeButton9);
                if (((ticTacToeButton1.Text == "X") && (ticTacToeButton4.Text == "X") && (ticTacToeButton9.Text == "X")) || ((ticTacToeButton1.Text == "O") && (ticTacToeButton4.Text == "O") && (ticTacToeButton9.Text == "O")))
                {
                    this.winnerMessageBox();
                    this.disableAllButtons();
                    return true;
                }
            }
            else if ((ticTacToeButton3.Text == ticTacToeButton4.Text) && (ticTacToeButton4.Text == ticTacToeButton7.Text) && (ticTacToeButton3.Text != ""))
            {
                this.makeWinButtons(ticTacToeButton3, ticTacToeButton4, ticTacToeButton7);
                if (((ticTacToeButton3.Text == "X") && (ticTacToeButton4.Text == "X") && (ticTacToeButton7.Text == "X")) || ((ticTacToeButton3.Text == "O") && (ticTacToeButton4.Text == "O") && (ticTacToeButton7.Text == "O")))
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
            ticTacToeButton1.BackColor = Color.DarkRed;
            ticTacToeButton2.BackColor = Color.DarkRed;
            ticTacToeButton3.BackColor = Color.DarkRed;
            ticTacToeButton4.BackColor = Color.DarkRed;
            ticTacToeButton5.BackColor = Color.DarkRed;
            ticTacToeButton6.BackColor = Color.DarkRed;
            ticTacToeButton7.BackColor = Color.DarkRed;
            ticTacToeButton8.BackColor = Color.DarkRed;
            ticTacToeButton9.BackColor = Color.DarkRed;
        }
        private void winnerMessageBox()
        {
            System.Windows.Forms.MessageBox.Show("The winner is: " + this.controller.getPlayerSign() + " ! ");
        }
        private void drawMessageBox()
        {
            System.Windows.Forms.MessageBox.Show("Draw !");
        }
        private void checkDeaw()
        {
            if ((ticTacToeButton1.Text != "") && (ticTacToeButton2.Text != "") && (ticTacToeButton3.Text != "") && (ticTacToeButton3.Text != "") && (ticTacToeButton4.Text != "") && (ticTacToeButton5.Text != "") && (ticTacToeButton6.Text != "") && (ticTacToeButton7.Text != "") && (ticTacToeButton8.Text != "") && (ticTacToeButton9.Text != ""))
            {
                this.makeDrawButtons();
                this.drawMessageBox();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void playerButton_Click(object sender, EventArgs e)
        {

        }
    }
}
