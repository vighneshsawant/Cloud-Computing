namespace SecuringData
{
    partial class PublicKeyCipher
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
            this.groupBoxKeys = new System.Windows.Forms.GroupBox();
            this.labelPublicKey = new System.Windows.Forms.Label();
            this.textBoxPublicKey = new System.Windows.Forms.TextBox();
            this.textBoxPrivateKey = new System.Windows.Forms.TextBox();
            this.labelPrivateKey = new System.Windows.Forms.Label();
            this.textBoxPlain = new System.Windows.Forms.TextBox();
            this.textBoxCiphered = new System.Windows.Forms.TextBox();
            this.textBoxDeciphered = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDeciphered = new System.Windows.Forms.Label();
            this.labelCiphered = new System.Windows.Forms.Label();
            this.labelPlain = new System.Windows.Forms.Label();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.groupBoxKeys.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxKeys
            // 
            this.groupBoxKeys.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxKeys.Controls.Add(this.labelPublicKey);
            this.groupBoxKeys.Controls.Add(this.textBoxPublicKey);
            this.groupBoxKeys.Controls.Add(this.textBoxPrivateKey);
            this.groupBoxKeys.Controls.Add(this.labelPrivateKey);
            this.groupBoxKeys.Location = new System.Drawing.Point(6, 12);
            this.groupBoxKeys.Name = "groupBoxKeys";
            this.groupBoxKeys.Size = new System.Drawing.Size(346, 103);
            this.groupBoxKeys.TabIndex = 6;
            this.groupBoxKeys.TabStop = false;
            this.groupBoxKeys.Text = "Public-Private Key Pairs (Auto Generated)";
            // 
            // labelPublicKey
            // 
            this.labelPublicKey.AutoSize = true;
            this.labelPublicKey.Location = new System.Drawing.Point(9, 22);
            this.labelPublicKey.Name = "labelPublicKey";
            this.labelPublicKey.Size = new System.Drawing.Size(39, 26);
            this.labelPublicKey.TabIndex = 0;
            this.labelPublicKey.Text = "Public \r\nKey:";
            // 
            // textBoxPublicKey
            // 
            this.textBoxPublicKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPublicKey.Location = new System.Drawing.Point(50, 19);
            this.textBoxPublicKey.Multiline = true;
            this.textBoxPublicKey.Name = "textBoxPublicKey";
            this.textBoxPublicKey.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPublicKey.Size = new System.Drawing.Size(290, 37);
            this.textBoxPublicKey.TabIndex = 1;
            // 
            // textBoxPrivateKey
            // 
            this.textBoxPrivateKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPrivateKey.Location = new System.Drawing.Point(50, 57);
            this.textBoxPrivateKey.Multiline = true;
            this.textBoxPrivateKey.Name = "textBoxPrivateKey";
            this.textBoxPrivateKey.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPrivateKey.Size = new System.Drawing.Size(290, 37);
            this.textBoxPrivateKey.TabIndex = 3;
            this.textBoxPrivateKey.Text = "Actually This is Public Key + Private Key";
            // 
            // labelPrivateKey
            // 
            this.labelPrivateKey.AutoSize = true;
            this.labelPrivateKey.Location = new System.Drawing.Point(9, 60);
            this.labelPrivateKey.Name = "labelPrivateKey";
            this.labelPrivateKey.Size = new System.Drawing.Size(40, 26);
            this.labelPrivateKey.TabIndex = 2;
            this.labelPrivateKey.Text = "Private\r\nKey:";
            // 
            // textBoxPlain
            // 
            this.textBoxPlain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPlain.Location = new System.Drawing.Point(50, 19);
            this.textBoxPlain.Multiline = true;
            this.textBoxPlain.Name = "textBoxPlain";
            this.textBoxPlain.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPlain.Size = new System.Drawing.Size(290, 37);
            this.textBoxPlain.TabIndex = 7;
            // 
            // textBoxCiphered
            // 
            this.textBoxCiphered.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCiphered.Location = new System.Drawing.Point(50, 62);
            this.textBoxCiphered.Multiline = true;
            this.textBoxCiphered.Name = "textBoxCiphered";
            this.textBoxCiphered.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxCiphered.Size = new System.Drawing.Size(290, 37);
            this.textBoxCiphered.TabIndex = 8;
            // 
            // textBoxDeciphered
            // 
            this.textBoxDeciphered.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDeciphered.Location = new System.Drawing.Point(50, 105);
            this.textBoxDeciphered.Multiline = true;
            this.textBoxDeciphered.Name = "textBoxDeciphered";
            this.textBoxDeciphered.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDeciphered.Size = new System.Drawing.Size(290, 37);
            this.textBoxDeciphered.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelDeciphered);
            this.groupBox1.Controls.Add(this.labelCiphered);
            this.groupBox1.Controls.Add(this.labelPlain);
            this.groupBox1.Controls.Add(this.buttonDecrypt);
            this.groupBox1.Controls.Add(this.buttonEncrypt);
            this.groupBox1.Controls.Add(this.textBoxCiphered);
            this.groupBox1.Controls.Add(this.textBoxDeciphered);
            this.groupBox1.Controls.Add(this.textBoxPlain);
            this.groupBox1.Location = new System.Drawing.Point(6, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 179);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asymmetric Encryption/Decryption";
            // 
            // labelDeciphered
            // 
            this.labelDeciphered.AutoSize = true;
            this.labelDeciphered.Location = new System.Drawing.Point(5, 108);
            this.labelDeciphered.Name = "labelDeciphered";
            this.labelDeciphered.Size = new System.Drawing.Size(30, 26);
            this.labelDeciphered.TabIndex = 31;
            this.labelDeciphered.Text = "Plain\r\nText";
            // 
            // labelCiphered
            // 
            this.labelCiphered.AutoSize = true;
            this.labelCiphered.Location = new System.Drawing.Point(5, 62);
            this.labelCiphered.Name = "labelCiphered";
            this.labelCiphered.Size = new System.Drawing.Size(37, 26);
            this.labelCiphered.TabIndex = 30;
            this.labelCiphered.Text = "Cipher\r\nText:";
            // 
            // labelPlain
            // 
            this.labelPlain.AutoSize = true;
            this.labelPlain.Location = new System.Drawing.Point(5, 19);
            this.labelPlain.Name = "labelPlain";
            this.labelPlain.Size = new System.Drawing.Size(31, 26);
            this.labelPlain.TabIndex = 29;
            this.labelPlain.Text = "Plain\r\nText:";
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(131, 148);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(75, 23);
            this.buttonDecrypt.TabIndex = 28;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(50, 148);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(75, 23);
            this.buttonEncrypt.TabIndex = 27;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // PublicKeyCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 303);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxKeys);
            this.Name = "PublicKeyCipher";
            this.Text = "Public Key Cipher";
            this.groupBoxKeys.ResumeLayout(false);
            this.groupBoxKeys.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxKeys;
        private System.Windows.Forms.Label labelPublicKey;
        private System.Windows.Forms.TextBox textBoxPublicKey;
        private System.Windows.Forms.TextBox textBoxPrivateKey;
        private System.Windows.Forms.Label labelPrivateKey;
        private System.Windows.Forms.TextBox textBoxPlain;
        private System.Windows.Forms.TextBox textBoxCiphered;
        private System.Windows.Forms.TextBox textBoxDeciphered;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Label labelPlain;
        private System.Windows.Forms.Label labelDeciphered;
        private System.Windows.Forms.Label labelCiphered;
    }
}