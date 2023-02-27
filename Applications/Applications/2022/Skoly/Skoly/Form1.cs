using System.Security.Policy;
using System.Windows.Forms;

namespace Skoly
{
    public partial class Form1 : Form
    {

        public static List<Skola> listSkol = new List<Skola>();
        //public int pocetZaku;
        //public List<String> listBarev = new List<String>();
        //public List<String> listWebovek = new List<String>();

        public static string[] poleNahodnychBarev = { "modra", "zluta", "cervena", "kokotska", "ahojky", "cerna", "oranzova", "bila", "purpurova", "fialova", "ruzova", "azurova", "svetle bezova", "svetle bila", "svetle cerna" };
        public static string[] poleNahodnychWebovek = {"www.skola.cz", "www.skola2.cz", "www.notavirus.cz", "www.skolaoktavova.com", "www.nahodna-webovka.netlify.app", "www.skolamaterska.cz", "www.cucurietka.sk"};

        public static Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RunApp(this);
        }
        public static void RunApp(Form1 form)
        {
            VygenerujSkoly(5);
            VypisSkoly(form);
        }
        public static void VygenerujSkoly(int pocet)
        {
            listSkol.Clear();
            for(int i = 0; i < pocet; i++)
            {
                int pocetZaku = VygenerujPocetZaku();
                string barva = VygenerujRandomBarvy();
                string webovka = VygenerujRandomWebovky();
                Skola skola = new Skola(pocetZaku, barva, webovka);
                listSkol.Add(skola);
            }
        }
        public static void VypisSkoly(Form1 form)
        {
            for(int i = 0; i < listSkol.Count; i++)
            {
                Label label = new Label();
                form.Controls.Add(label);
                label.Width = 2000;
                label.Top = i * 25;
                label.Text = $"Poèet žákù: {listSkol[i].zaci};  Barva školy: {listSkol[i].barvaSkoly};  Webovka: {listSkol[i].weboveStranky}";
            }
        }
        public static string VygenerujRandomBarvy()
        {
            return poleNahodnychBarev[rnd.Next(0, poleNahodnychBarev.Length)];
        }
        public static string VygenerujRandomWebovky()
        {
            return poleNahodnychWebovek[rnd.Next(0, poleNahodnychWebovek.Length)];
        }
        public static int VygenerujPocetZaku()
        {
            return rnd.Next(0,1000);
        }
    }
}