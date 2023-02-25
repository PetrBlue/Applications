namespace PetrKejklicek_ElipsyDU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //declare the variables
        public static int vyska = 50;
        public static int sirka = 75;
        public static int poziceX = 725/2;
        public static int poziceY = 350;
        //make lists for the colors
        public static List<int> barva1 = new List<int>();
        public static List<int> barva2 = new List<int>();
        public static List<int> barva3 = new List<int>();
        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            //nothing lol
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //first part of rgb, the red part
            barva1.Add(rnd.Next(0, 256));
            for (int i = 0; i < barva1.Count; i++)
            {
                //make sure its not a copy of any previous colors
                int temp = barva1.Count-1;
                if (barva1[i] == barva1[temp])
                {
                    barva1[i] = rnd.Next(0, 256);
                }
            }
            //second part of rgb, the green part
            barva2.Add(rnd.Next(0, 256));
            for (int i = 0; i < barva2.Count; i++)
            {
                //make sure its not a copy of any previous colors
                int temp = barva2.Count-1;
                if (barva2[i] == barva2[temp])
                {
                    barva2[i] = rnd.Next(0, 256);
                }
            }
            //third part of rgb, the blue part
            barva3.Add(rnd.Next(0, 256));
            for (int i = 0; i < barva3.Count; i++)
            {
                //make sure its not a copy of any previous colors
                int temp = barva1.Count-1;
                if (barva3[i] == barva3[temp])
                {
                    barva3[i] = rnd.Next(0, 256);
                }
            }

            // spawn object
            Graphics grap = this.CreateGraphics();
            Pen pen = new Pen(Color.FromArgb(barva1[barva1.Count-1], barva2[barva2.Count-1], barva3[barva3.Count-1]), 5);
            grap.DrawEllipse(pen, poziceX, poziceY, sirka, vyska);
            //add height, width and change its position so its in the middle
            vyska += 50;
            sirka += 50;
            poziceX -= 25;
            poziceY -= 25;
        }
    }
}
//All comments made by PK/blue