using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculette_simplifiee
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Int32 resultat;
            if ((Int32.TryParse(textBox1.Text, out resultat)) && ((Int32.TryParse(textBox1.Text, out resultat))))
            {
                label4.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text));
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Int32 resultat;
            if ((Int32.TryParse(textBox1.Text, out resultat)) && ((Int32.TryParse(textBox1.Text, out resultat))))
            {
                label4.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text));
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Int32 resultat;
            if ((Int32.TryParse(textBox1.Text, out resultat)) && ((Int32.TryParse(textBox1.Text, out resultat))))
            {
                label4.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text));
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Int32 resultat;
            if ((Int32.TryParse(textBox1.Text, out resultat)) && ((Int32.TryParse(textBox1.Text, out resultat))))
            {
                label4.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text));
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label4.Text = "";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
