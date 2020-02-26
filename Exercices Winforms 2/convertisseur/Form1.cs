using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace convertisseur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Int32 resultat;
            if (Int32.TryParse(textBox1.Text, out resultat))
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) / 6.55);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Int32 resultat;
            if (Int32.TryParse(textBox2.Text, out resultat))
            {
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox2.Text) * 6.55);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                DialogResult Vrep;

                Vrep = MessageBox.Show("Les données de la zone francs vont être changées, continuer ?", "Attention",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (Vrep == DialogResult.Yes)
                {
                    textBox1.Text = "";
                }

                else
                {
                    return;
                }
            }
        }

        private void TextBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.TextLength > 0)
            {
                DialogResult Vrep;

                Vrep = MessageBox.Show("Les données de la zone euros vont être changées, continuer ?", "Attention",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (Vrep == DialogResult.Yes)
                {
                    textBox2.Text = "";
                }

                else
                {
                    return;
                }
            }
        }
    }
}
