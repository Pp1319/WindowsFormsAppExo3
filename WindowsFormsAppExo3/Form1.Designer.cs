namespace WindowsFormsAppExo3
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Choix = new System.Windows.Forms.GroupBox();
            this.checkBoxCasse = new System.Windows.Forms.CheckBox();
            this.checkBoxCarac = new System.Windows.Forms.CheckBox();
            this.checkBoxCouleur = new System.Windows.Forms.CheckBox();
            this.Fond = new System.Windows.Forms.GroupBox();
            this.radioButtonbleu = new System.Windows.Forms.RadioButton();
            this.radioButtonVert = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Caractere = new System.Windows.Forms.GroupBox();
            this.radioButtonNoir = new System.Windows.Forms.RadioButton();
            this.radioButtonBlanc = new System.Windows.Forms.RadioButton();
            this.radioButtonRouge = new System.Windows.Forms.RadioButton();
            this.Casse = new System.Windows.Forms.GroupBox();
            this.radioButtonMaj = new System.Windows.Forms.RadioButton();
            this.radioButtonMin = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Choix.SuspendLayout();
            this.Fond.SuspendLayout();
            this.Caractere.SuspendLayout();
            this.Casse.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tapez votre texte";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(321, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.SaisieTexte);
            // 
            // Choix
            // 
            this.Choix.Controls.Add(this.checkBoxCasse);
            this.Choix.Controls.Add(this.checkBoxCarac);
            this.Choix.Controls.Add(this.checkBoxCouleur);
            this.Choix.Enabled = false;
            this.Choix.Location = new System.Drawing.Point(517, 40);
            this.Choix.Name = "Choix";
            this.Choix.Size = new System.Drawing.Size(260, 141);
            this.Choix.TabIndex = 2;
            this.Choix.TabStop = false;
            this.Choix.Text = "Choix";
            this.Choix.EnabledChanged += new System.EventHandler(this.EnabledGroupBox1);
            // 
            // checkBoxCasse
            // 
            this.checkBoxCasse.AutoSize = true;
            this.checkBoxCasse.Location = new System.Drawing.Point(26, 104);
            this.checkBoxCasse.Name = "checkBoxCasse";
            this.checkBoxCasse.Size = new System.Drawing.Size(55, 17);
            this.checkBoxCasse.TabIndex = 2;
            this.checkBoxCasse.Text = "Casse";
            this.checkBoxCasse.UseVisualStyleBackColor = true;
            this.checkBoxCasse.CheckedChanged += new System.EventHandler(this.CheckBoxChanged);
            // 
            // checkBoxCarac
            // 
            this.checkBoxCarac.AutoSize = true;
            this.checkBoxCarac.Location = new System.Drawing.Point(26, 66);
            this.checkBoxCarac.Name = "checkBoxCarac";
            this.checkBoxCarac.Size = new System.Drawing.Size(135, 17);
            this.checkBoxCarac.TabIndex = 1;
            this.checkBoxCarac.Text = "Couleur des caractères";
            this.checkBoxCarac.UseVisualStyleBackColor = true;
            this.checkBoxCarac.CheckedChanged += new System.EventHandler(this.CheckBoxChanged);
            // 
            // checkBoxCouleur
            // 
            this.checkBoxCouleur.AutoSize = true;
            this.checkBoxCouleur.Location = new System.Drawing.Point(26, 31);
            this.checkBoxCouleur.Name = "checkBoxCouleur";
            this.checkBoxCouleur.Size = new System.Drawing.Size(101, 17);
            this.checkBoxCouleur.TabIndex = 0;
            this.checkBoxCouleur.Text = "Couleur du fond";
            this.checkBoxCouleur.UseVisualStyleBackColor = true;
            this.checkBoxCouleur.TextChanged += new System.EventHandler(this.SaisieTexte);
            // 
            // Fond
            // 
            this.Fond.Controls.Add(this.radioButtonbleu);
            this.Fond.Controls.Add(this.radioButtonVert);
            this.Fond.Controls.Add(this.radioButton1);
            this.Fond.Location = new System.Drawing.Point(66, 296);
            this.Fond.Name = "Fond";
            this.Fond.Size = new System.Drawing.Size(116, 141);
            this.Fond.TabIndex = 4;
            this.Fond.TabStop = false;
            this.Fond.Text = "Fond";
            // 
            // radioButtonbleu
            // 
            this.radioButtonbleu.AutoSize = true;
            this.radioButtonbleu.Location = new System.Drawing.Point(6, 101);
            this.radioButtonbleu.Name = "radioButtonbleu";
            this.radioButtonbleu.Size = new System.Drawing.Size(46, 17);
            this.radioButtonbleu.TabIndex = 2;
            this.radioButtonbleu.Text = "Bleu";
            this.radioButtonbleu.UseVisualStyleBackColor = true;
            this.radioButtonbleu.CheckedChanged += new System.EventHandler(this.ChangeFond);
            // 
            // radioButtonVert
            // 
            this.radioButtonVert.AutoSize = true;
            this.radioButtonVert.Location = new System.Drawing.Point(6, 63);
            this.radioButtonVert.Name = "radioButtonVert";
            this.radioButtonVert.Size = new System.Drawing.Size(44, 17);
            this.radioButtonVert.TabIndex = 1;
            this.radioButtonVert.Text = "Vert";
            this.radioButtonVert.UseVisualStyleBackColor = true;
            this.radioButtonVert.CheckedChanged += new System.EventHandler(this.ChangeFond);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Rouge";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.ChangeFond);
            // 
            // Caractere
            // 
            this.Caractere.Controls.Add(this.radioButtonNoir);
            this.Caractere.Controls.Add(this.radioButtonBlanc);
            this.Caractere.Controls.Add(this.radioButtonRouge);
            this.Caractere.Location = new System.Drawing.Point(232, 297);
            this.Caractere.Name = "Caractere";
            this.Caractere.Size = new System.Drawing.Size(116, 141);
            this.Caractere.TabIndex = 5;
            this.Caractere.TabStop = false;
            this.Caractere.Text = "Caractères";
            // 
            // radioButtonNoir
            // 
            this.radioButtonNoir.AutoSize = true;
            this.radioButtonNoir.Location = new System.Drawing.Point(6, 100);
            this.radioButtonNoir.Name = "radioButtonNoir";
            this.radioButtonNoir.Size = new System.Drawing.Size(44, 17);
            this.radioButtonNoir.TabIndex = 3;
            this.radioButtonNoir.TabStop = true;
            this.radioButtonNoir.Text = "Noir";
            this.radioButtonNoir.UseVisualStyleBackColor = true;
            // 
            // radioButtonBlanc
            // 
            this.radioButtonBlanc.AutoSize = true;
            this.radioButtonBlanc.Location = new System.Drawing.Point(6, 62);
            this.radioButtonBlanc.Name = "radioButtonBlanc";
            this.radioButtonBlanc.Size = new System.Drawing.Size(52, 17);
            this.radioButtonBlanc.TabIndex = 2;
            this.radioButtonBlanc.TabStop = true;
            this.radioButtonBlanc.Text = "Blanc";
            this.radioButtonBlanc.UseVisualStyleBackColor = true;
            // 
            // radioButtonRouge
            // 
            this.radioButtonRouge.AutoSize = true;
            this.radioButtonRouge.Location = new System.Drawing.Point(6, 29);
            this.radioButtonRouge.Name = "radioButtonRouge";
            this.radioButtonRouge.Size = new System.Drawing.Size(57, 17);
            this.radioButtonRouge.TabIndex = 1;
            this.radioButtonRouge.TabStop = true;
            this.radioButtonRouge.Text = "Rouge";
            this.radioButtonRouge.UseVisualStyleBackColor = true;
            // 
            // Casse
            // 
            this.Casse.Controls.Add(this.radioButtonMaj);
            this.Casse.Controls.Add(this.radioButtonMin);
            this.Casse.Location = new System.Drawing.Point(415, 370);
            this.Casse.Name = "Casse";
            this.Casse.Size = new System.Drawing.Size(136, 68);
            this.Casse.TabIndex = 5;
            this.Casse.TabStop = false;
            this.Casse.Text = "Casse";
            // 
            // radioButtonMaj
            // 
            this.radioButtonMaj.AutoSize = true;
            this.radioButtonMaj.Location = new System.Drawing.Point(6, 45);
            this.radioButtonMaj.Name = "radioButtonMaj";
            this.radioButtonMaj.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMaj.TabIndex = 2;
            this.radioButtonMaj.TabStop = true;
            this.radioButtonMaj.Text = "Majuscule";
            this.radioButtonMaj.UseVisualStyleBackColor = true;
            // 
            // radioButtonMin
            // 
            this.radioButtonMin.AutoSize = true;
            this.radioButtonMin.Location = new System.Drawing.Point(6, 19);
            this.radioButtonMin.Name = "radioButtonMin";
            this.radioButtonMin.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMin.TabIndex = 1;
            this.radioButtonMin.TabStop = true;
            this.radioButtonMin.Text = "Minuscule";
            this.radioButtonMin.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Casse);
            this.Controls.Add(this.Caractere);
            this.Controls.Add(this.Fond);
            this.Controls.Add(this.Choix);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CheckBox et RadioButton";
            this.Choix.ResumeLayout(false);
            this.Choix.PerformLayout();
            this.Fond.ResumeLayout(false);
            this.Fond.PerformLayout();
            this.Caractere.ResumeLayout(false);
            this.Caractere.PerformLayout();
            this.Casse.ResumeLayout(false);
            this.Casse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxCasse;
        private System.Windows.Forms.CheckBox checkBoxCarac;
        private System.Windows.Forms.CheckBox checkBoxCouleur;
        private System.Windows.Forms.GroupBox Fond;
        private System.Windows.Forms.GroupBox Caractere;
        private System.Windows.Forms.GroupBox Casse;
        private System.Windows.Forms.GroupBox Choix;
        private System.Windows.Forms.RadioButton radioButtonbleu;
        private System.Windows.Forms.RadioButton radioButtonVert;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButtonNoir;
        private System.Windows.Forms.RadioButton radioButtonBlanc;
        private System.Windows.Forms.RadioButton radioButtonRouge;
        private System.Windows.Forms.RadioButton radioButtonMaj;
        private System.Windows.Forms.RadioButton radioButtonMin;
        private System.Windows.Forms.Label label2;
    }
}

