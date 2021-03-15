namespace KorisnickiInterfejs
{
    partial class UnosArtikla
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.btnZapamti = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtRokTrajanja = new System.Windows.Forms.TextBox();
            this.txtProizvodjac = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artikal ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cena:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rok trajanja: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Proizvodjac: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Naziv:";
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Location = new System.Drawing.Point(591, 60);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(257, 61);
            this.btnKreiraj.TabIndex = 6;
            this.btnKreiraj.Text = "Kreiraj artikal";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // btnZapamti
            // 
            this.btnZapamti.Location = new System.Drawing.Point(46, 471);
            this.btnZapamti.Name = "btnZapamti";
            this.btnZapamti.Size = new System.Drawing.Size(389, 71);
            this.btnZapamti.TabIndex = 7;
            this.btnZapamti.Text = "Zapamti artikal";
            this.btnZapamti.UseVisualStyleBackColor = true;
            this.btnZapamti.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(276, 69);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(254, 38);
            this.txtId.TabIndex = 8;
            // 
            // txtRokTrajanja
            // 
            this.txtRokTrajanja.Location = new System.Drawing.Point(232, 282);
            this.txtRokTrajanja.Name = "txtRokTrajanja";
            this.txtRokTrajanja.Size = new System.Drawing.Size(203, 38);
            this.txtRokTrajanja.TabIndex = 10;
            // 
            // txtProizvodjac
            // 
            this.txtProizvodjac.Location = new System.Drawing.Point(232, 197);
            this.txtProizvodjac.Name = "txtProizvodjac";
            this.txtProizvodjac.Size = new System.Drawing.Size(203, 38);
            this.txtProizvodjac.TabIndex = 11;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(203, 99);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(232, 38);
            this.txtNaziv.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCena);
            this.groupBox1.Controls.Add(this.txtProizvodjac);
            this.groupBox1.Controls.Add(this.txtNaziv);
            this.groupBox1.Controls.Add(this.btnZapamti);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtRokTrajanja);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(60, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 613);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o artiklu:";
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(153, 367);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(282, 38);
            this.txtCena.TabIndex = 13;
            // 
            // UnosArtikla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1636, 982);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.label1);
            this.Name = "UnosArtikla";
            this.Text = "UnosArtikla";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.Button btnZapamti;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtRokTrajanja;
        private System.Windows.Forms.TextBox txtProizvodjac;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCena;
    }
}