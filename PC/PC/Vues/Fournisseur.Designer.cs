﻿namespace PC.Vues
{
    partial class Fournisseur
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltext = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAjt = new System.Windows.Forms.Button();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lbltext);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 174);
            this.panel1.TabIndex = 1;
            // 
            // lbltext
            // 
            this.lbltext.AutoSize = true;
            this.lbltext.Location = new System.Drawing.Point(59, 65);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(201, 30);
            this.lbltext.TabIndex = 0;
            this.lbltext.Text = "Ajout Fournisseur";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.btnAjt);
            this.panel2.Controls.Add(this.txtAdresse);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtNom);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(50, 256);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(701, 389);
            this.panel2.TabIndex = 2;
            // 
            // btnAjt
            // 
            this.btnAjt.Location = new System.Drawing.Point(55, 262);
            this.btnAjt.Name = "btnAjt";
            this.btnAjt.Size = new System.Drawing.Size(168, 44);
            this.btnAjt.TabIndex = 0;
            this.btnAjt.Text = "Ajout";
            this.btnAjt.UseVisualStyleBackColor = true;
            this.btnAjt.Click += new System.EventHandler(this.btnAjt_Click);
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(271, 154);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(325, 26);
            this.txtAdresse.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adresse";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(271, 35);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(325, 26);
            this.txtNom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom Fournisseur";
            // 
            // Fournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Fournisseur";
            this.Text = "Fournisseur";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAjt;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label1;
    }
}