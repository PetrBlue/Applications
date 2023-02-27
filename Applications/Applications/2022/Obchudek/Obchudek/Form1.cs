namespace Obchudek
{
    public partial class Form1 : Form
    {
        public List<Product> products = new List<Product>();
        public int celkovaCena;
        public void Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        public void CalculateTotalPrice()
        {
            celkovaCena = 0;
            foreach (Product product in products)
            {
                celkovaCena += product.price;
            }
        }
    }
}