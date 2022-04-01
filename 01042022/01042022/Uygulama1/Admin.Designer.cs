
namespace Uygulama1
{
    partial class Admin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kullanıcıKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıHareketleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıKaydetToolStripMenuItem,
            this.kullanıcıHareketleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kullanıcıKaydetToolStripMenuItem
            // 
            this.kullanıcıKaydetToolStripMenuItem.Name = "kullanıcıKaydetToolStripMenuItem";
            this.kullanıcıKaydetToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.kullanıcıKaydetToolStripMenuItem.Text = "Kullanıcı Kaydet";
            this.kullanıcıKaydetToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıKaydetToolStripMenuItem_Click);
            // 
            // kullanıcıHareketleriToolStripMenuItem
            // 
            this.kullanıcıHareketleriToolStripMenuItem.Name = "kullanıcıHareketleriToolStripMenuItem";
            this.kullanıcıHareketleriToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.kullanıcıHareketleriToolStripMenuItem.Text = "Banka Hareketleri";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıHareketleriToolStripMenuItem;
    }
}