namespace Project.Views
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btn_fournisseur = new System.Windows.Forms.Button();
            this.btn_produit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_deconnexion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_fournisseur
            // 
            this.btn_fournisseur.Location = new System.Drawing.Point(92, 109);
            this.btn_fournisseur.Name = "btn_fournisseur";
            this.btn_fournisseur.Size = new System.Drawing.Size(141, 29);
            this.btn_fournisseur.TabIndex = 0;
            this.btn_fournisseur.Text = "Fournisseur";
            this.btn_fournisseur.UseVisualStyleBackColor = true;
            this.btn_fournisseur.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_produit
            // 
            this.btn_produit.Location = new System.Drawing.Point(92, 49);
            this.btn_produit.Name = "btn_produit";
            this.btn_produit.Size = new System.Drawing.Size(141, 29);
            this.btn_produit.TabIndex = 1;
            this.btn_produit.Text = "Produit";
            this.btn_produit.UseVisualStyleBackColor = true;
            this.btn_produit.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(219, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 134);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_deconnexion
            // 
            this.btn_deconnexion.Location = new System.Drawing.Point(556, 12);
            this.btn_deconnexion.Name = "btn_deconnexion";
            this.btn_deconnexion.Size = new System.Drawing.Size(104, 29);
            this.btn_deconnexion.TabIndex = 3;
            this.btn_deconnexion.Text = "Deconnexion";
            this.btn_deconnexion.UseVisualStyleBackColor = true;
            this.btn_deconnexion.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btn_produit);
            this.panel1.Controls.Add(this.btn_fournisseur);
            this.panel1.Location = new System.Drawing.Point(162, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 203);
            this.panel1.TabIndex = 4;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(672, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_deconnexion);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btn_fournisseur;
        private Button btn_produit;
        private PictureBox pictureBox1;
        private Button btn_deconnexion;
        private Panel panel1;
    }
}