using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LyonPalme.Forms
{
    public partial class FTestConnexion : Form
    {
        
        public FTestConnexion()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            //init des identifiant
            string log = "admin";
            string mdp = "password";
            //remplissage des variable avec le contenu des champs
            string login = this.textBox1.Text;
            string password = this.textBox2.Text;
            //verifications des identifiants rentré dans les champs
            if (login == log && mdp == password)
            {
                //si il sont bon on est redirigé sur la page materiel
                FTestMateriel fTestMateriel = new FTestMateriel();
                fTestMateriel.Show();
                this.Hide();
            }
            else
            {
                //sinon un message d'erreur s affiche
                MessageBox.Show("Échec de la connexion");
            }
        }

    }
}
