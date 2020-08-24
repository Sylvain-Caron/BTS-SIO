namespace Jeu_Mystère
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
            this.buttonDebuter = new System.Windows.Forms.Button();
            this.buttonNombreTest = new System.Windows.Forms.Button();
            this.buttonSauv = new System.Windows.Forms.Button();
            this.listBoxScores = new System.Windows.Forms.ListBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.textBoxPseudo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDebuter
            // 
            this.buttonDebuter.Location = new System.Drawing.Point(35, 28);
            this.buttonDebuter.Name = "buttonDebuter";
            this.buttonDebuter.Size = new System.Drawing.Size(75, 23);
            this.buttonDebuter.TabIndex = 0;
            this.buttonDebuter.Text = "Start";
            this.buttonDebuter.UseVisualStyleBackColor = true;
            this.buttonDebuter.Click += new System.EventHandler(this.buttonDebuter_Click);
            // 
            // buttonNombreTest
            // 
            this.buttonNombreTest.Location = new System.Drawing.Point(35, 72);
            this.buttonNombreTest.Name = "buttonNombreTest";
            this.buttonNombreTest.Size = new System.Drawing.Size(75, 23);
            this.buttonNombreTest.TabIndex = 1;
            this.buttonNombreTest.Text = "Tester";
            this.buttonNombreTest.UseVisualStyleBackColor = true;
            this.buttonNombreTest.Click += new System.EventHandler(this.buttonNombreTest_Click);
            // 
            // buttonSauv
            // 
            this.buttonSauv.Location = new System.Drawing.Point(647, 27);
            this.buttonSauv.Name = "buttonSauv";
            this.buttonSauv.Size = new System.Drawing.Size(75, 23);
            this.buttonSauv.TabIndex = 2;
            this.buttonSauv.Text = "Sauvegarde";
            this.buttonSauv.UseVisualStyleBackColor = true;
            // 
            // listBoxScores
            // 
            this.listBoxScores.FormattingEnabled = true;
            this.listBoxScores.Location = new System.Drawing.Point(193, 27);
            this.listBoxScores.Name = "listBoxScores";
            this.listBoxScores.Size = new System.Drawing.Size(120, 95);
            this.listBoxScores.TabIndex = 3;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(370, 27);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown.TabIndex = 4;
            // 
            // textBoxPseudo
            // 
            this.textBoxPseudo.Location = new System.Drawing.Point(24, 126);
            this.textBoxPseudo.Name = "textBoxPseudo";
            this.textBoxPseudo.Size = new System.Drawing.Size(100, 20);
            this.textBoxPseudo.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPseudo);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.listBoxScores);
            this.Controls.Add(this.buttonSauv);
            this.Controls.Add(this.buttonNombreTest);
            this.Controls.Add(this.buttonDebuter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDebuter;
        private System.Windows.Forms.Button buttonNombreTest;
        private System.Windows.Forms.Button buttonSauv;
        private System.Windows.Forms.ListBox listBoxScores;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.TextBox textBoxPseudo;
    }
}

