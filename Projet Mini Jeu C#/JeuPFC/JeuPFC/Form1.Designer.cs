namespace JeuPFC
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
            this.buttonPlay = new System.Windows.Forms.Button();
            this.TBPseudo = new System.Windows.Forms.TextBox();
            this.radioPierre = new System.Windows.Forms.RadioButton();
            this.radioFeuille = new System.Windows.Forms.RadioButton();
            this.radioCiseaux = new System.Windows.Forms.RadioButton();
            this.labelJoueur = new System.Windows.Forms.Label();
            this.labelBot = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pseudo :";
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(116, 119);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.Text = "Jouer";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // TBPseudo
            // 
            this.TBPseudo.Location = new System.Drawing.Point(102, 33);
            this.TBPseudo.Name = "TBPseudo";
            this.TBPseudo.Size = new System.Drawing.Size(100, 20);
            this.TBPseudo.TabIndex = 2;
            // 
            // radioPierre
            // 
            this.radioPierre.AutoSize = true;
            this.radioPierre.Location = new System.Drawing.Point(48, 84);
            this.radioPierre.Name = "radioPierre";
            this.radioPierre.Size = new System.Drawing.Size(52, 17);
            this.radioPierre.TabIndex = 3;
            this.radioPierre.TabStop = true;
            this.radioPierre.Text = "Pierre";
            this.radioPierre.UseVisualStyleBackColor = true;
            // 
            // radioFeuille
            // 
            this.radioFeuille.AutoSize = true;
            this.radioFeuille.Location = new System.Drawing.Point(116, 84);
            this.radioFeuille.Name = "radioFeuille";
            this.radioFeuille.Size = new System.Drawing.Size(55, 17);
            this.radioFeuille.TabIndex = 4;
            this.radioFeuille.TabStop = true;
            this.radioFeuille.Text = "Feuille";
            this.radioFeuille.UseVisualStyleBackColor = true;
            // 
            // radioCiseaux
            // 
            this.radioCiseaux.AutoSize = true;
            this.radioCiseaux.Location = new System.Drawing.Point(188, 84);
            this.radioCiseaux.Name = "radioCiseaux";
            this.radioCiseaux.Size = new System.Drawing.Size(62, 17);
            this.radioCiseaux.TabIndex = 5;
            this.radioCiseaux.TabStop = true;
            this.radioCiseaux.Text = "Ciseaux";
            this.radioCiseaux.UseVisualStyleBackColor = true;
            // 
            // labelJoueur
            // 
            this.labelJoueur.AutoSize = true;
            this.labelJoueur.Location = new System.Drawing.Point(75, 179);
            this.labelJoueur.Name = "labelJoueur";
            this.labelJoueur.Size = new System.Drawing.Size(25, 13);
            this.labelJoueur.TabIndex = 6;
            this.labelJoueur.Text = "......";
            // 
            // labelBot
            // 
            this.labelBot.AutoSize = true;
            this.labelBot.Location = new System.Drawing.Point(200, 179);
            this.labelBot.Name = "labelBot";
            this.labelBot.Size = new System.Drawing.Size(25, 13);
            this.labelBot.TabIndex = 7;
            this.labelBot.Text = "......";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "VS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelBot);
            this.Controls.Add(this.labelJoueur);
            this.Controls.Add(this.radioCiseaux);
            this.Controls.Add(this.radioFeuille);
            this.Controls.Add(this.radioPierre);
            this.Controls.Add(this.TBPseudo);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.TextBox TBPseudo;
        private System.Windows.Forms.RadioButton radioPierre;
        private System.Windows.Forms.RadioButton radioFeuille;
        private System.Windows.Forms.RadioButton radioCiseaux;
        private System.Windows.Forms.Label labelJoueur;
        private System.Windows.Forms.Label labelBot;
        private System.Windows.Forms.Label label2;
    }
}

