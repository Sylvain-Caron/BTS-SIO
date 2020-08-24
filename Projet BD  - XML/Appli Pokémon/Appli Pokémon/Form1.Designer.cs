namespace Appli_Pokémon
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
            this.TBNom = new System.Windows.Forms.TextBox();
            this.TBType = new System.Windows.Forms.TextBox();
            this.TBAnnee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonAddType = new System.Windows.Forms.Button();
            this.TBTypeAdd = new System.Windows.Forms.TextBox();
            this.buttonAffTen = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NbTen = new System.Windows.Forms.Label();
            this.buttonPJ = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TBNom
            // 
            this.TBNom.Location = new System.Drawing.Point(96, 50);
            this.TBNom.Name = "TBNom";
            this.TBNom.Size = new System.Drawing.Size(100, 20);
            this.TBNom.TabIndex = 0;
            // 
            // TBType
            // 
            this.TBType.Location = new System.Drawing.Point(96, 92);
            this.TBType.Name = "TBType";
            this.TBType.Size = new System.Drawing.Size(100, 20);
            this.TBType.TabIndex = 1;
            // 
            // TBAnnee
            // 
            this.TBAnnee.Location = new System.Drawing.Point(96, 134);
            this.TBAnnee.Name = "TBAnnee";
            this.TBAnnee.Size = new System.Drawing.Size(100, 20);
            this.TBAnnee.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom Pokémon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Année Naissance";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(96, 176);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(100, 23);
            this.buttonRegister.TabIndex = 6;
            this.buttonRegister.Text = "Add Pokémon";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonAddType
            // 
            this.buttonAddType.Location = new System.Drawing.Point(343, 85);
            this.buttonAddType.Name = "buttonAddType";
            this.buttonAddType.Size = new System.Drawing.Size(75, 23);
            this.buttonAddType.TabIndex = 7;
            this.buttonAddType.Text = "Add Type";
            this.buttonAddType.UseVisualStyleBackColor = true;
            this.buttonAddType.Click += new System.EventHandler(this.button1_Click);
            // 
            // TBTypeAdd
            // 
            this.TBTypeAdd.Location = new System.Drawing.Point(330, 50);
            this.TBTypeAdd.Name = "TBTypeAdd";
            this.TBTypeAdd.Size = new System.Drawing.Size(100, 20);
            this.TBTypeAdd.TabIndex = 8;
            // 
            // buttonAffTen
            // 
            this.buttonAffTen.Location = new System.Drawing.Point(464, 175);
            this.buttonAffTen.Name = "buttonAffTen";
            this.buttonAffTen.Size = new System.Drawing.Size(120, 23);
            this.buttonAffTen.TabIndex = 9;
            this.buttonAffTen.Text = "Affiche Ténèbres";
            this.buttonAffTen.UseVisualStyleBackColor = true;
            this.buttonAffTen.Click += new System.EventHandler(this.buttonAffTen_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(464, 59);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nb :";
            // 
            // NbTen
            // 
            this.NbTen.AutoSize = true;
            this.NbTen.Location = new System.Drawing.Point(498, 217);
            this.NbTen.Name = "NbTen";
            this.NbTen.Size = new System.Drawing.Size(19, 13);
            this.NbTen.TabIndex = 12;
            this.NbTen.Text = "....";
            // 
            // buttonPJ
            // 
            this.buttonPJ.Location = new System.Drawing.Point(83, 268);
            this.buttonPJ.Name = "buttonPJ";
            this.buttonPJ.Size = new System.Drawing.Size(130, 23);
            this.buttonPJ.TabIndex = 13;
            this.buttonPJ.Text = "Affiche Plus Jeune";
            this.buttonPJ.UseVisualStyleBackColor = true;
            this.buttonPJ.Click += new System.EventHandler(this.buttonPJ_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "PLUS JEUNE ?";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(215, 55);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(80, 95);
            this.listBox2.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonPJ);
            this.Controls.Add(this.NbTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonAffTen);
            this.Controls.Add(this.TBTypeAdd);
            this.Controls.Add(this.buttonAddType);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBAnnee);
            this.Controls.Add(this.TBType);
            this.Controls.Add(this.TBNom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBNom;
        private System.Windows.Forms.TextBox TBType;
        private System.Windows.Forms.TextBox TBAnnee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonAddType;
        private System.Windows.Forms.TextBox TBTypeAdd;
        private System.Windows.Forms.Button buttonAffTen;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label NbTen;
        private System.Windows.Forms.Button buttonPJ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox2;
    }
}

