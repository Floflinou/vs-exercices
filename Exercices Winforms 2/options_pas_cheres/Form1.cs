using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace options_pas_cheres
{
    public partial class Form1 : Form
    {
        int prix = 2000;

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Convert.ToString(prix) + " €";
            checkBox2.CheckedChanged += new EventHandler(CheckBox1_CheckedChanged);
            checkBox3.CheckedChanged += new EventHandler(CheckBox1_CheckedChanged);
            checkBox4.CheckedChanged += new EventHandler(CheckBox1_CheckedChanged);
            checkBox5.CheckedChanged += new EventHandler(CheckBox1_CheckedChanged);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            foreach (CheckBox maCase in groupBox1.Controls)
            {
                maCase.Checked = true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            foreach (CheckBox maCase in groupBox1.Controls)
            {
                maCase.Checked = false;
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

            CheckBox maCheckbox = (CheckBox)sender;

            if (maCheckbox.Checked == true)
            {
                prix = prix + Convert.ToInt32(maCheckbox.Tag);
                
            }
            else
            {
                prix = prix - Convert.ToInt32(maCheckbox.Tag);
            }

            textBox1.Text = Convert.ToString(prix) + " €";
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox2.Checked == true)
            //{
            //    prix = prix + Convert.ToInt32(checkBox2.Tag);
            //    textBox1.Text = Convert.ToString(prix) + " €";
            //}

            //if (checkBox2.Checked == false)
            //{
            //    prix = prix - Convert.ToInt32(checkBox2.Tag);
            //    textBox1.Text = Convert.ToString(prix) + " €";
            //}
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox4.Checked == true)
            //{
            //    prix = prix + Convert.ToInt32(checkBox4.Tag);
            //    textBox1.Text = Convert.ToString(prix) + " €";
            //}

            //if (checkBox4.Checked == false)
            //{
            //    prix = prix - Convert.ToInt32(checkBox4.Tag);
            //    textBox1.Text = Convert.ToString(prix) + " €";
            //}
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox3.Checked == true)
            //{
            //    prix = prix + Convert.ToInt32(checkBox3.Tag);
            //    textBox1.Text = Convert.ToString(prix) + " €";
            //}

            //if (checkBox3.Checked == false)
            //{
            //    prix = prix - Convert.ToInt32(checkBox3.Tag);
            //    textBox1.Text = Convert.ToString(prix) + " €";
            //}
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox5.Checked == true)
            //{
            //    prix = prix + Convert.ToInt32(checkBox5.Tag);
            //    textBox1.Text = Convert.ToString(prix) + " €";
            //}

            //if (checkBox5.Checked == false)
            //{
            //    prix = prix - Convert.ToInt32(checkBox5.Tag);
            //    textBox1.Text = Convert.ToString(prix) + " €";
            //}
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
