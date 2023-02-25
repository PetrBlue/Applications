namespace ZacatkyForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void ZkontrolujPohlavi()
        {
            if (radioButton1.Checked)
            {
                label1.Text = "Jsi muž";
            }
            else
            {
                label1.Text = "Jsi žena";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Bruh";
            ZkontrolujPohlavi();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            this.BackColor = Color.FromArgb(0, 0, rnd.Next(256));
            PohybKostkou();
            pictureBox1.Focus();
        }
        private void PohybKostkou()
        {
            if(pictureBox1.Location.X > this.Width)
            {
                pictureBox1.Location = new Point(-pictureBox1.Width, pictureBox1.Location.Y);
            }
            else
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y);
            }
            
        }
        private void pictureBox1_previewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
        public static int counter = 0;
        private void pictureBox1_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 10);
            }
            else if (e.KeyCode == Keys.S)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 10);
            }
            else if (e.KeyCode == Keys.A)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y);
            }
            else if (e.KeyCode == Keys.D)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);
            }
            else if (e.KeyCode == Keys.Space)
            {
                counter++;
                label2.Text = "Times clicked: " + counter;
            }
        }
    }
}