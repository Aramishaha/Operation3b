using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operation3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void bt_ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                double resultat = double.Parse(tb_nombre1.Text) + double.Parse(tb_nombre2.Text);
                lb_operateur.Text = "+";
                tbresultat.Text = resultat.ToString();
            }
            catch (System.FormatException ex) { MessageBox.Show(ex.Message); }
        }

        private void bt_multiplier_Click(object sender, EventArgs e)
        {
            try
            {
                double resultat = double.Parse(tb_nombre1.Text) * double.Parse(tb_nombre2.Text);
                lb_operateur.Text = "*";
                tbresultat.Text = Convert.ToString(resultat);
            }
            catch (System.FormatException ex) { MessageBox.Show(ex.Message); }
        }


        private void bt_effacer_Click(object sender, EventArgs e)
        {
            tb_nombre1.Clear();
            tb_nombre2.Clear();
            tbresultat.Clear();
        }

        private void bt_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tb_nombre1_TextChanged(object sender, EventArgs e)
        {
            //On efface le nombre 2 et le resultat
            tb_nombre2.Clear();
            tbresultat.Clear();
        }
    }
}
