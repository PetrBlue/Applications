namespace DoudaMoveGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 700;
            this.Height = 700;
            new Player(this);
            new Ally(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Enemy enemy = new Enemy(this);
            enemy.GenerateEnemy(this, 10);

        }
    }
}