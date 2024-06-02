namespace Tic_tac_toe
{
    public partial class Form1 : Form
    {
        Controller controller;
        public Form1()
        {
            InitializeComponent();
            Controller controller = new Controller();
        }


        private void tictacbutton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Text = "O";
            btn.Enabled = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            
            controller.randomPlayer();

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
    }
}
