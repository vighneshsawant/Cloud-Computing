namespace SecuringData
{
    partial class Main
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
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.privateKeyCipherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.privateKeyCipherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicKeyCipherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hashingDemoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.digitalSignatureDemoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(430, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.privateKeyCipherToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.newToolStripMenuItem.Text = "File";
            // 
            // privateKeyCipherToolStripMenuItem1
            // 
            this.privateKeyCipherToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.privateKeyCipherToolStripMenuItem,
            this.publicKeyCipherToolStripMenuItem1,
            this.hashingDemoToolStripMenuItem1,
            this.digitalSignatureDemoToolStripMenuItem1});
            this.privateKeyCipherToolStripMenuItem1.Name = "privateKeyCipherToolStripMenuItem1";
            this.privateKeyCipherToolStripMenuItem1.Size = new System.Drawing.Size(106, 22);
            this.privateKeyCipherToolStripMenuItem1.Text = "&New";
            // 
            // privateKeyCipherToolStripMenuItem
            // 
            this.privateKeyCipherToolStripMenuItem.Name = "privateKeyCipherToolStripMenuItem";
            this.privateKeyCipherToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.privateKeyCipherToolStripMenuItem.Text = "Private Key Cipher";
            this.privateKeyCipherToolStripMenuItem.Click += new System.EventHandler(this.privateKeyCipherToolStripMenuItem_Click);
            // 
            // publicKeyCipherToolStripMenuItem1
            // 
            this.publicKeyCipherToolStripMenuItem1.Name = "publicKeyCipherToolStripMenuItem1";
            this.publicKeyCipherToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.publicKeyCipherToolStripMenuItem1.Text = "Public Key Cipher";
            this.publicKeyCipherToolStripMenuItem1.Click += new System.EventHandler(this.publicKeyCipherToolStripMenuItem1_Click);
            // 
            // hashingDemoToolStripMenuItem1
            // 
            this.hashingDemoToolStripMenuItem1.Name = "hashingDemoToolStripMenuItem1";
            this.hashingDemoToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.hashingDemoToolStripMenuItem1.Text = "Hashing Demo";
            this.hashingDemoToolStripMenuItem1.Click += new System.EventHandler(this.hashingDemoToolStripMenuItem1_Click);
            // 
            // digitalSignatureDemoToolStripMenuItem1
            // 
            this.digitalSignatureDemoToolStripMenuItem1.Name = "digitalSignatureDemoToolStripMenuItem1";
            this.digitalSignatureDemoToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.digitalSignatureDemoToolStripMenuItem1.Text = "Digital Signature Demo";
            this.digitalSignatureDemoToolStripMenuItem1.Click += new System.EventHandler(this.digitalSignatureDemoToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 385);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Securing Data in .NET | Common Ciphers";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem privateKeyCipherToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem privateKeyCipherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publicKeyCipherToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hashingDemoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem digitalSignatureDemoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

