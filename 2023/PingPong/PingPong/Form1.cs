using System.Drawing.Design;
using System.Runtime.CompilerServices;
using Timer = System.Windows.Forms.Timer;

namespace PingPong
{
    public partial class Form1 : Form
    {
        Ball ball;
        Player p1, p2;
        Timer timer;
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(900, 600);
            this.KeyPreview = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();
            ball = new Ball(Color.Black, this);
            p1 = new Player(new Point(50, this.Height/2 - this.Height/10), Color.Blue, 25,this);
            p2 = new Player(new Point(this.Width - 50 - p1.width, this.Height/2 - p1.height/2),
                Color.Red, 25,this);
            this.Paint += Form1_Paint;
            timer.Enabled = true;
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            this.PreviewKeyDown += Form1_PreviewKeyDown;            
            p1.MovePlayer(this);
            label1.Text = p1.direction.ToString();
        }

        private void Form1_PreviewKeyDown(object? sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    p1.direction = Direction.UP;
                    break;
                case Keys.S:
                    p1.direction = Direction.DOWN;
                    break;
                case Keys.Up:
                    p2.direction = Direction.UP;
                    break;
                case Keys.Down:
                    p2.direction = Direction.DOWN;
                    break;
                default:
                    break;
            }
        }

        private void Form1_Paint(object? sender, PaintEventArgs e)
        {
            ball.CreateBall(this);
        }
    }
}