namespace SpawnCubes
{
    public partial class Form1 : Form
    {
        List<PictureBox> pictureBoxes = new List<PictureBox>();
        int body = 0;
        int multiplier = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Body: " + body;
            label2.Text = "Poèet objektù: " + pictureBoxes.Count;
            SpawnCube();
        }
        private void SpawnCube()
        {
            Random rnd = new Random();
            PictureBox pictureBox = new PictureBox();
            pictureBox.Height = rnd.Next(25, 125);
            pictureBox.Width = rnd.Next(25, 125);
            pictureBox.BackColor = Color.FromArgb(rnd.Next(0,255), rnd.Next(0, 255), rnd.Next(0, 255));
            int x = rnd.Next(0, this.ClientSize.Width - pictureBox.Width);
            int y = rnd.Next(0, this.ClientSize.Height - pictureBox.Height);
            pictureBox.Location = new Point(x, y);
            pictureBoxes.Add(pictureBox);
            pictureBox.Click += PictureBox_Click;
            this.Controls.Add(pictureBox);
            pictureBox.BringToFront();
            label1.Text = "Body: " + body;
            label2.Text = "Poèet objektù: " + pictureBoxes.Count;
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox tmPic = sender as PictureBox;
            pictureBoxes.Remove(tmPic);
            this.Controls.Remove(tmPic);
            label1.Text = "Body: " + body;
            label2.Text = "Poèet objektù: " + pictureBoxes.Count;
            body += multiplier;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(body >= 10)
            {
                body -= 10;
                multiplier++;
                label1.Text = "Body: " + body;
                label2.Text = "Poèet objektù: " + pictureBoxes.Count;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Body: " + body;
            label2.Text = "Poèet objektù: " + pictureBoxes.Count;
        }
    }
}