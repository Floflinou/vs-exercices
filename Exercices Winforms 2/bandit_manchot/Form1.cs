using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bandit_manchot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Random Rnd = new Random();

            textBox1.Text = Convert.ToString(Rnd.Next(0,9));
            textBox2.Text = Convert.ToString(Rnd.Next(0,9));
            textBox3.Text = Convert.ToString(Rnd.Next(0,9));

            if (textBox1.Text == "7" || textBox2.Text == "7" || textBox3.Text == "7")
            {
                pictureBox1.Visible = true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
