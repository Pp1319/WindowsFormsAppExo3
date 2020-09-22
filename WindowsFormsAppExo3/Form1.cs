using System;
using System.Windows.Forms;

namespace WindowsFormsAppExo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {


            InitializeComponent();

        }
        private void SaisieTexte(object sender, EventArgs e)
        {

            if (this.textBox1.Text != string.Empty)
            {
                this.label2.Text = (radioButtonMaj.Checked) ? this.textBox1.Text.ToUpper() :
                    this.textBox1.Text.ToLower();
                this.checkBoxCouleur.Checked = false;
                this.checkBoxCarac.Checked = false;
                this.checkBoxCasse.Checked = false;
                this.Choix.Enabled = true;
                this.Fond.Visible = false;
                this.Caractere.Visible = false;
                this.Casse.Visible = false;
                this.label2.Visible = true;

            }
            else
            {
                Choix.Enabled = false;
                this.label2.Visible = false;
            }

        }

        private void EnabledGroupBox1(object sender, EventArgs e)
        {



        }







        private void ChangeFond(object sender, EventArgs e)
        {
            RadioButton bouton = sender as RadioButton;
            if (bouton != null && bouton.Checked)
            {

            }
        }

        

    private void CheckBoxChanged(object sender, EventArgs e)
    {

    }
}
}
