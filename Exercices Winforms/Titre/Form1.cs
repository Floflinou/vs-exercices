using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Titre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Click += new EventHandler(Button1_Click);
            button3.Click += new EventHandler(Button1_Click);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button monBouton = sender as Button;
            this.Text = monBouton.Text;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Text = "L'empire contre-attaque";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Text = "Le retour du Jedi";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
