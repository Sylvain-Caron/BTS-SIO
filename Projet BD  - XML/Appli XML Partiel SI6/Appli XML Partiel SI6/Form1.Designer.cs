namespace Appli_XML_Partiel_SI6
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
            this.listAdmin = new System.Windows.Forms.ListBox();
            this.ButtonAffAdmin = new System.Windows.Forms.Button();
            this.buttonWindows = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listAdmin
            // 
            this.listAdmin.FormattingEnabled = true;
            this.listAdmin.Location = new System.Drawing.Point(26, 31);
            this.listAdmin.Name = "listAdmin";
            this.listAdmin.Size = new System.Drawing.Size(120, 95);
            this.listAdmin.TabIndex = 0;
            // 
            // ButtonAffAdmin
            // 
            this.ButtonAffAdmin.Location = new System.Drawing.Point(26, 132);
            this.ButtonAffAdmin.Name = "ButtonAffAdmin";
            this.ButtonAffAdmin.Size = new System.Drawing.Size(120, 23);
            this.ButtonAffAdmin.TabIndex = 1;
            this.ButtonAffAdmin.Text = "Affiche Admin";
            this.ButtonAffAdmin.UseVisualStyleBackColor = true;
            this.ButtonAffAdmin.Click += new System.EventHandler(this.ButtonAffAdmin_Click);
            // 
            // buttonWindows
            // 
            this.buttonWindows.Location = new System.Drawing.Point(191, 31);
            this.buttonWindows.Name = "buttonWindows";
            this.buttonWindows.Size = new System.Drawing.Size(75, 23);
            this.buttonWindows.TabIndex = 2;
            this.buttonWindows.Text = "Windows";
            this.buttonWindows.UseVisualStyleBackColor = true;
            this.buttonWindows.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(191, 77);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Ajouter";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(191, 123);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 4;
            this.buttonDel.Text = "Supprimer";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonWindows);
            this.Controls.Add(this.ButtonAffAdmin);
            this.Controls.Add(this.listAdmin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listAdmin;
        private System.Windows.Forms.Button ButtonAffAdmin;
        private System.Windows.Forms.Button buttonWindows;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
    }
}

