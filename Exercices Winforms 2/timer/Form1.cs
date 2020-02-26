using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = Convert.ToString(DateTime.Now);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                MessageBox.Show("Bienvenue !", "Mot de passe chronométré");
                Close();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Le délai est écoulé...", "Mot de passe chronométré");
            Close();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(DateTime.Now);
        }
    }
}
