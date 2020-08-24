namespace JeuPendu
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
            this.TBLettre = new System.Windows.Forms.TextBox();
            this.buttonLettre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBJoueur1 = new System.Windows.Forms.TextBox();
            this.TBJoueur2 = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonMot = new System.Windows.Forms.Button();
            this.TBMot = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TBLettre
            // 
            this.TBLettre.Location = new System.Drawing.Point(163, 80);
            this.TBLettre.Name = "TBLettre";
            this.TBLettre.Size = new System.Drawing.Size(100, 20);
            this.TBLettre.TabIndex = 0;
            // 
            // buttonLettre
            // 
            this.buttonLettre.Location = new System.Drawing.Point(175, 106);
            this.buttonLettre.Name = "buttonLettre";
            this.buttonLettre.Size = new System.Drawing.Size(75, 23);
            this.buttonLettre.TabIndex = 1;
            this.buttonLettre.Text = "Essai Lettre";
            this.buttonLettre.UseVisualStyleBackColor = true;
            this.buttonLettre.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Joueur 1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Joueur 2 :";
            // 
            // TBJoueur1
            // 
            this.TBJoueur1.Location = new System.Drawing.Point(72, 18);
            this.TBJoueur1.Name = "TBJoueur1";
            this.TBJoueur1.Size = new System.Drawing.Size(100, 20);
            this.TBJoueur1.TabIndex = 4;
            // 
            // TBJoueur2
            // 
            this.TBJoueur2.Location = new System.Drawing.Point(256, 19);
            this.TBJoueur2.Name = "TBJoueur2";
            this.TBJoueur2.Size = new System.Drawing.Size(100, 20);
            this.TBJoueur2.TabIndex = 5;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(400, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(145, 41);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "START GAME";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonMot
            // 
            this.buttonMot.Location = new System.Drawing.Point(175, 193);
            this.buttonMot.Name = "buttonMot";
            this.buttonMot.Size = new System.Drawing.Size(75, 23);
            this.buttonMot.TabIndex = 7;
            this.buttonMot.Text = "Essai Mot";
            this.buttonMot.UseVisualStyleBackColor = true;
            this.buttonMot.Click += new System.EventHandler(this.buttonMot_Click);
            // 
            // TBMot
            // 
            this.TBMot.Location = new System.Drawing.Point(163, 167);
            this.TBMot.Name = "TBMot";
            this.TBMot.Size = new System.Drawing.Size(100, 20);
            this.TBMot.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBMot);
            this.Controls.Add(this.buttonMot);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.TBJoueur2);
            this.Controls.Add(this.TBJoueur1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLettre);
            this.Controls.Add(this.TBLettre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBLettre;
        private System.Windows.Forms.Button buttonLettre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBJoueur1;
        private System.Windows.Forms.TextBox TBJoueur2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonMot;
        private System.Windows.Forms.TextBox TBMot;
    }
}

