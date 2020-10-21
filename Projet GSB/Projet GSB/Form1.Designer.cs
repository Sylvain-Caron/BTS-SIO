namespace Projet_GSB
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
            this.btnConnexion = new System.Windows.Forms.Button();
            this.TBmatricule = new System.Windows.Forms.TextBox();
            this.TBmdp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioUser = new System.Windows.Forms.RadioButton();
            this.radioTech = new System.Windows.Forms.RadioButton();
            this.radioResp = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnConnexion
            // 
            this.btnConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnexion.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.Location = new System.Drawing.Point(359, 212);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(89, 23);
            this.btnConnexion.TabIndex = 0;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // TBmatricule
            // 
            this.TBmatricule.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBmatricule.Location = new System.Drawing.Point(306, 86);
            this.TBmatricule.Name = "TBmatricule";
            this.TBmatricule.Size = new System.Drawing.Size(184, 21);
            this.TBmatricule.TabIndex = 1;
            // 
            // TBmdp
            // 
            this.TBmdp.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBmdp.Location = new System.Drawing.Point(306, 140);
            this.TBmdp.Name = "TBmdp";
            this.TBmdp.Size = new System.Drawing.Size(184, 21);
            this.TBmdp.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Matricule :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mot de Passe :";
            // 
            // radioUser
            // 
            this.radioUser.AutoSize = true;
            this.radioUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioUser.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioUser.Location = new System.Drawing.Point(259, 178);
            this.radioUser.Name = "radioUser";
            this.radioUser.Size = new System.Drawing.Size(94, 17);
            this.radioUser.TabIndex = 5;
            this.radioUser.TabStop = true;
            this.radioUser.Text = "Utilisateur";
            this.radioUser.UseVisualStyleBackColor = true;
            // 
            // radioTech
            // 
            this.radioTech.AutoSize = true;
            this.radioTech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioTech.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTech.Location = new System.Drawing.Point(359, 178);
            this.radioTech.Name = "radioTech";
            this.radioTech.Size = new System.Drawing.Size(92, 17);
            this.radioTech.TabIndex = 6;
            this.radioTech.TabStop = true;
            this.radioTech.Text = "Technicien";
            this.radioTech.UseVisualStyleBackColor = true;
            // 
            // radioResp
            // 
            this.radioResp.AutoSize = true;
            this.radioResp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioResp.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioResp.Location = new System.Drawing.Point(452, 178);
            this.radioResp.Name = "radioResp";
            this.radioResp.Size = new System.Drawing.Size(98, 17);
            this.radioResp.TabIndex = 7;
            this.radioResp.TabStop = true;
            this.radioResp.Text = "Responsable";
            this.radioResp.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioResp);
            this.Controls.Add(this.radioTech);
            this.Controls.Add(this.radioUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBmdp);
            this.Controls.Add(this.TBmatricule);
            this.Controls.Add(this.btnConnexion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.TextBox TBmatricule;
        private System.Windows.Forms.TextBox TBmdp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioUser;
        private System.Windows.Forms.RadioButton radioTech;
        private System.Windows.Forms.RadioButton radioResp;
    }
}

