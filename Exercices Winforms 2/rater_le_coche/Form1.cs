using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rater_le_coche
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int bilan = 0;

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                bilan = bilan + 1;
            }
            else
            {
                bilan = bilan - 1;
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                bilan = bilan + 1;
            }
            else
            {
                bilan = bilan - 1;
            }
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                bilan = bilan + 1;
            }
            else
            {
                bilan = bilan - 1;
            }
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                bilan = bilan + 1;
            }
            else
            {
                bilan = bilan - 1;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vous avez cliqué " + Convert.ToString(bilan) + " fois", "Bilan");

            if (bilan < 4)
            {
                MessageBox.Show("Mais il reste " + Convert.ToString(4 - bilan) + " cases", "Cases manquantes");
            }
        }
    }
}
