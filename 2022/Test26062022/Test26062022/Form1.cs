namespace Test26062022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 5% == 20px, 100% == 400px
        public char movementPlayerOne = 'S';
        public char movementPlayerTwo = 'S';
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            button1.Visible = false;
            label1.Visible = false;
        }



        /*private void panel_ally_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            label1.Visible = true;
            switch (e.KeyCode)
            {
                case Keys.A:
                    panel_ally.Location = new Point(panel_enemy.Location.X - 20, panel_enemy.Location.Y);
                    return;
                case Keys.S:
                    panel_ally.Location = new Point(panel_enemy.Location.X, panel_enemy.Location.Y + 20);
                    return;
                case Keys.W:
                    panel_ally.Location = new Point(panel_enemy.Location.X, panel_enemy.Location.Y - 20);
                    return;
                case Keys.D:
                    panel_ally.Location = new Point(panel_enemy.Location.X + 20, panel_enemy.Location.Y);
                    return;
            }
            /*switch (e.KeyCode)
            {
                case Keys.A:
                    movementPlayerOne = 'A';
                    return;
                case Keys.S:
                    movementPlayerOne = 'S';
                    return;
                case Keys.W:
                    movementPlayerOne = 'W';
                    return;
                case Keys.D:
                    movementPlayerOne = 'D';
                    return;
            }
        }*/

       /*private void panel_enemy_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            label1.Visible = true;
            switch (e.KeyCode)
            {
                case Keys.Left:
                    panel_enemy.Location = new Point(panel_enemy.Location.X - 20, panel_enemy.Location.Y);
                    return;
                case Keys.Down:
                    panel_enemy.Location = new Point(panel_enemy.Location.X, panel_enemy.Location.Y + 20);
                    return;
                case Keys.Up:
                    panel_enemy.Location = new Point(panel_enemy.Location.X, panel_enemy.Location.Y - 20);
                    return;
                case Keys.Right:
                    panel_enemy.Location = new Point(panel_enemy.Location.X + 20, panel_enemy.Location.Y);
                    return;
            }
            /*switch (e.KeyCode)
            {
                case Keys.Left:
                    movementPlayerTwo = 'A';
                    return;
                case Keys.Down:
                    movementPlayerTwo = 'S';
                    return;
                case Keys.Up:
                    movementPlayerTwo = 'W';
                    return;
                case Keys.Right:
                    movementPlayerTwo = 'D';
                    return;
            }
        }*/

        //fucking piece of shit cant call a function by key press
        private void panel_ally_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            label1.Visible = true;
            label1.Text = "wtf";
            switch (e.KeyCode)
            {
                case Keys.A:
                    movementPlayerOne = 'A';
                    return;
                case Keys.S:
                    movementPlayerOne = 'S';
                    return;
                case Keys.W:
                    movementPlayerOne = 'W';
                    return;
                case Keys.D:
                    movementPlayerOne = 'D';
                    return;
                default:
                    label2.Text = "f off";
                    return;
            }
        }

        private void panel_enemy_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = movementPlayerOne + " " + movementPlayerTwo;
            switch (movementPlayerOne)
            {
                case 'A':
                    panel_ally.Location = new Point(panel_ally.Location.X - 20, panel_ally.Location.Y);
                    return;
                case 'S':
                    panel_ally.Location = new Point(panel_ally.Location.X, panel_ally.Location.Y + 20);
                    return;
                case 'W':
                    panel_ally.Location = new Point(panel_ally.Location.X, panel_ally.Location.Y - 20);
                    return;
                case 'D':
                    panel_ally.Location = new Point(panel_ally.Location.X + 20, panel_ally.Location.Y);
                    return;
                default:
                    //TODO - make some sort of an "you broke it, restart the exe file" text
                    break;
            }
            if (panel_ally.Location == panel_enemy.Location)
            {
                MessageBox.Show("Game over.");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "c";
            switch (movementPlayerTwo)
            {
                case 'A':
                    panel_enemy.Location = new Point(panel_enemy.Location.X - 20, panel_enemy.Location.Y);
                    return;
                case 'S':
                    panel_enemy.Location = new Point(panel_enemy.Location.X, panel_enemy.Location.Y + 20);
                    return;
                case 'W':
                    panel_enemy.Location = new Point(panel_enemy.Location.X, panel_enemy.Location.Y - 20);
                    return;
                case 'D':
                    panel_enemy.Location = new Point(panel_enemy.Location.X + 20, panel_enemy.Location.Y);
                    return;
                default:
                    //TODO - make some sort of an "you broke it, restart the exe file" text
                    break;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        /*private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            label1.Visible = true;
            switch (e.KeyCode)
            {
                case Keys.A:
                    label1.Visible = true;
                    panel_ally.Location = new Point(panel_ally.Location.X - 20, panel_ally.Location.Y);
                    return;
                case Keys.S:
                    panel_ally.Location = new Point(panel_ally.Location.X, panel_ally.Location.Y + 20);
                    return;
                case Keys.W:
                    panel_ally.Location = new Point(panel_ally.Location.X, panel_ally.Location.Y - 20);
                    return;
                case Keys.D:
                    panel_ally.Location = new Point(panel_ally.Location.X + 20, panel_ally.Location.Y);
                    return;
                case Keys.Left:
                    panel_enemy.Location = new Point(panel_enemy.Location.X - 20, panel_enemy.Location.Y);
                    return;
                case Keys.Down:
                    panel_enemy.Location = new Point(panel_enemy.Location.X, panel_enemy.Location.Y + 20);
                    return;
                case Keys.Up:
                    panel_enemy.Location = new Point(panel_enemy.Location.X, panel_enemy.Location.Y - 20);
                    return;
                case Keys.Right:
                    panel_enemy.Location = new Point(panel_enemy.Location.X + 20, panel_enemy.Location.Y);
                    return;
            }
        }*/
    }
}