namespace KorisnickiInterfejs
{
    partial class GlavnaForma
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
            this.GlavniMeni = new System.Windows.Forms.MenuStrip();
            this.artikalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosArtiklaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaArtiklaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GlavniMeni.SuspendLayout();
            this.SuspendLayout();
            // 
            // GlavniMeni
            // 
            this.GlavniMeni.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.GlavniMeni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artikalToolStripMenuItem,
            this.turaToolStripMenuItem});
            this.GlavniMeni.Location = new System.Drawing.Point(0, 0);
            this.GlavniMeni.Name = "GlavniMeni";
            this.GlavniMeni.Size = new System.Drawing.Size(1390, 52);
            this.GlavniMeni.TabIndex = 5;
            this.GlavniMeni.Text = "menuStrip1";
            // 
            // artikalToolStripMenuItem
            // 
            this.artikalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosArtiklaToolStripMenuItem,
            this.pretragaArtiklaToolStripMenuItem});
            this.artikalToolStripMenuItem.Name = "artikalToolStripMenuItem";
            this.artikalToolStripMenuItem.Size = new System.Drawing.Size(125, 48);
            this.artikalToolStripMenuItem.Text = "Artikal";
            // 
            // unosArtiklaToolStripMenuItem
            // 
            this.unosArtiklaToolStripMenuItem.Name = "unosArtiklaToolStripMenuItem";
            this.unosArtiklaToolStripMenuItem.Size = new System.Drawing.Size(382, 54);
            this.unosArtiklaToolStripMenuItem.Text = "Unos artikla";
            this.unosArtiklaToolStripMenuItem.Click += new System.EventHandler(this.unosArtiklaToolStripMenuItem_Click);
            // 
            // pretragaArtiklaToolStripMenuItem
            // 
            this.pretragaArtiklaToolStripMenuItem.Name = "pretragaArtiklaToolStripMenuItem";
            this.pretragaArtiklaToolStripMenuItem.Size = new System.Drawing.Size(382, 54);
            this.pretragaArtiklaToolStripMenuItem.Text = "Pretraga artikla";
            this.pretragaArtiklaToolStripMenuItem.Click += new System.EventHandler(this.pretragaArtiklaToolStripMenuItem_Click);
            // 
            // turaToolStripMenuItem
            // 
            this.turaToolStripMenuItem.Name = "turaToolStripMenuItem";
            this.turaToolStripMenuItem.Size = new System.Drawing.Size(100, 48);
            this.turaToolStripMenuItem.Text = "Tura";
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 890);
            this.Controls.Add(this.GlavniMeni);
            this.MainMenuStrip = this.GlavniMeni;
            this.Name = "GlavnaForma";
            this.Text = "Form1";
            this.GlavniMeni.ResumeLayout(false);
            this.GlavniMeni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip GlavniMeni;
        private System.Windows.Forms.ToolStripMenuItem artikalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosArtiklaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaArtiklaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turaToolStripMenuItem;
    }
}

