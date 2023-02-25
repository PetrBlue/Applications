using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulacka
{
    public partial class Kalkulacka : Form
    {
        public Kalkulacka()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_onclick(object sender, EventArgs e)
        {
            if (Tabulka.Text == "0")
            {
                Tabulka.Clear();
            }
            Button tabulka = (Button)sender;
            Tabulka.Text = Tabulka.Text + tabulka.Text;
        }
        private void button_operation(object sender, EventArgs e)
        { 
        
        }    
    }
}
