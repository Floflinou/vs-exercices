using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace montant_commande
{
    public partial class Form1 : Form
    {
        int total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0 && textBox2.TextLength > 0)
            {
                if (checkBox1.Checked == true || checkBox2.Checked == true)
                {
                    textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text));
                    total = Convert.ToInt32(textBox3.Text);

                    if (checkBox1.Checked == true)
                    {
                        textBox5.Text = Convert.ToString(total * 1.05);
                    }
                    else if (checkBox2.Checked == true)
                    {
                        textBox5.Text = Convert.ToString(total * 1.20);
                    }

                    if (checkBox1.Checked == true && checkBox3.Checked == true)
                    {
                        textBox5.Text = Convert.ToString(Convert.ToDouble(total * 1.05 * 0.9));
                    }

                    if (checkBox2.Checked == true && checkBox3.Checked == true)
                    {
                        textBox5.Text = Convert.ToString(Convert.ToDouble(total * 1.20 * 0.9));
                    }

                    textBox4.Text = Convert.ToString((Convert.ToDouble(textBox5.Text) - Convert.ToDouble(total)));

                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            foreach (CheckBox maCase in groupBox1.Controls)
            {
                maCase.Checked = false;
            }

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
