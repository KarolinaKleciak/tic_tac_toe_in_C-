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

            this.checkWin();
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

        private void checkWin()
        {
            if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (button4.Text != ""))
            {
                this.makeWinButtoms(button4, button5, button6);
            }
            else if ((button8.Text == button7.Text) && (button7.Text == button9.Text) && (button8.Text != ""))
            {
                this.makeWinButtoms(button8, button7, button9);
            }
            else if ((button10.Text == button11.Text) && (button11.Text == button12.Text) && (button10.Text != ""))
            {
                this.makeWinButtoms(button10, button11, button12);
            }
            else if ((button4.Text == button8.Text) && (button8.Text == button10.Text) && (button4.Text != ""))
            {
                this.makeWinButtoms(button4, button8, button10);
            }
            else if ((button5.Text == button7.Text) && (button7.Text == button11.Text) && (button5.Text != ""))
            {
                this.makeWinButtoms(button5, button7, button11);
            }
            else if ((button6.Text == button9.Text) && ( button9.Text == button12.Text) && (button6.Text != ""))
            {
                this.makeWinButtoms(button6, button9, button12);
            }
            else if ((button4.Text == button7.Text) && (button7.Text == button12.Text) && (button4.Text != ""))
            {
                this.makeWinButtoms(button4, button7, button12);
            }
            else if ((button6.Text == button7.Text) && (button7.Text == button10.Text) && (button6.Text != ""))
            {
                this.makeWinButtoms(button6, button7, button10);
            }
        }

        public void makeWinButtoms(Button button1, Button button2, Button button3)
        {
            button1.BackColor = Color.LimeGreen;
            button2.BackColor = Color.LimeGreen;
            button3.BackColor = Color.LimeGreen;
        }
    }
}
