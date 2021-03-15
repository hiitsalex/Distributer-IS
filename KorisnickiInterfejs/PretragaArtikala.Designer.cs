namespace KorisnickiInterfejs
{
    partial class PretragaArtikala
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
            this.txtKriterijum = new System.Windows.Forms.TextBox();
            this.dgvPretraga = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite kriterijum:";
            // 
            // txtKriterijum
            // 
            this.txtKriterijum.Location = new System.Drawing.Point(397, 86);
            this.txtKriterijum.Name = "txtKriterijum";
            this.txtKriterijum.Size = new System.Drawing.Size(996, 38);
            this.txtKriterijum.TabIndex = 1;
            this.txtKriterijum.TextChanged += new System.EventHandler(this.txtKriterijum_TextChanged);
            this.txtKriterijum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKriterijum_KeyDown);
            // 
            // dgvPretraga
            // 
            this.dgvPretraga.AllowUserToAddRows = false;
            this.dgvPretraga.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPretraga.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvPretraga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPretraga.Location = new System.Drawing.Point(72, 198);
            this.dgvPretraga.Name = "dgvPretraga";
            this.dgvPretraga.ReadOnly = true;
            this.dgvPretraga.RowHeadersVisible = false;
            this.dgvPretraga.RowHeadersWidth = 102;
            this.dgvPretraga.RowTemplate.Height = 40;
            this.dgvPretraga.Size = new System.Drawing.Size(1321, 582);
            this.dgvPretraga.TabIndex = 2;
            this.dgvPretraga.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPretraga_CellDoubleClick);
            // 
            // PretragaArtikala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1535, 828);
            this.Controls.Add(this.dgvPretraga);
            this.Controls.Add(this.txtKriterijum);
            this.Controls.Add(this.label1);
            this.Name = "PretragaArtikala";
            this.Text = "Pretraga artikala";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKriterijum;
        private System.Windows.Forms.DataGridView dgvPretraga;
    }
}