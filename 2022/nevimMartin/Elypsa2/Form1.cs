using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elypsa2
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int vodorovne = 243;
        int vertikalne = 300;
        int sirka = 100;
        int vyska = 50;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics dc = this.CreateGraphics();
            Pen pen = new Pen(GetRandomColor(), 2);
            dc.DrawEllipse(pen, vodorovne, vertikalne, sirka, vyska);
            change();
        }
        private void change()
        {
            vodorovne -= 50;
            vertikalne -= 25;
            sirka += 50 * 2;
            vyska += 50;
        }
        private Color GetRandomColor()
        {
            return Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.GrayText;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.ActiveCaption;
        }
    }
}
