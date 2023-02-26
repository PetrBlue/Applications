namespace Obchudek2
{
    public partial class Form1 : Form
    {
        public List<Product> products = new List<Product>();
        public float celkovaCena;
        public Random rnd = new Random();
        ShoppingCart shoppingCart;
        public Form1()
        {
            InitializeComponent();
            App(this);
        }

        public void App(Form1 form)
        {
            shoppingCart = new ShoppingCart();
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

        private void button1_Click(object sender, EventArgs e)
        {
            AddItem(shoppingCart, productText.Text);
            listBox.Items.Add(productText.Text);
            productText.Text = "";
        }
        public void AddItem(ShoppingCart shoppingCart, string name)
        {
            shoppingCart.products.Add(new Product(name, rnd.Next(1, 11)));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox.Items.RemoveAt(listBox.SelectedIndex);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = shoppingCart.CalculateTotalPrice();
        }
    }
}