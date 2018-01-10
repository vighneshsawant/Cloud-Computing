namespace SecuringData
{
    partial class PrivateKeyCipher
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
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.labelKey = new System.Windows.Forms.Label();
            this.comboBoxAlgorithm = new System.Windows.Forms.ComboBox();
            this.labelAlgorithm = new System.Windows.Forms.Label();
            this.textBoxSalt = new System.Windows.Forms.TextBox();
            this.labelSalt = new System.Windows.Forms.Label();
            this.labelDeciphered = new System.Windows.Forms.Label();
            this.labelCiphered = new System.Windows.Forms.Label();
            this.labelInputText = new System.Windows.Forms.Label();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.textBoxDeciphered = new System.Windows.Forms.TextBox();
            this.textBoxCiphered = new System.Windows.Forms.TextBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxKey
            // 
            this.textBoxKey.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxKey.Location = new System.Drawing.Point(176, 20);
            this.textBoxKey.MaxLength = 8;
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(100, 20);
            this.textBoxKey.TabIndex = 7;
            this.textBoxKey.Text = "Your Secret Key";
            // 
            // labelKey
            // 
            this.labelKey.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(142, 23);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(28, 13);
            this.labelKey.TabIndex = 6;
            this.labelKey.Text = "Key:";
            // 
            // comboBoxAlgorithm
            // 
            this.comboBoxAlgorithm.FormattingEnabled = true;
            this.comboBoxAlgorithm.Location = new System.Drawing.Point(65, 20);
            this.comboBoxAlgorithm.Name = "comboBoxAlgorithm";
            this.comboBoxAlgorithm.Size = new System.Drawing.Size(77, 21);
            this.comboBoxAlgorithm.TabIndex = 5;
            // 
            // labelAlgorithm
            // 
            this.labelAlgorithm.AutoSize = true;
            this.labelAlgorithm.Location = new System.Drawing.Point(6, 23);
            this.labelAlgorithm.Name = "labelAlgorithm";
            this.labelAlgorithm.Size = new System.Drawing.Size(53, 13);
            this.labelAlgorithm.TabIndex = 4;
            this.labelAlgorithm.Text = "Algorithm:";
            // 
            // textBoxSalt
            // 
            this.textBoxSalt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSalt.Location = new System.Drawing.Point(313, 20);
            this.textBoxSalt.MaxLength = 8;
            this.textBoxSalt.Name = "textBoxSalt";
            this.textBoxSalt.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalt.TabIndex = 9;
            this.textBoxSalt.Text = "Must be 8 or More Characters";
            // 
            // labelSalt
            // 
            this.labelSalt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSalt.AutoSize = true;
            this.labelSalt.Location = new System.Drawing.Point(280, 23);
            this.labelSalt.Name = "labelSalt";
            this.labelSalt.Size = new System.Drawing.Size(28, 13);
            this.labelSalt.TabIndex = 8;
            this.labelSalt.Text = "Salt:";
            // 
            // labelDeciphered
            // 
            this.labelDeciphered.AutoSize = true;
            this.labelDeciphered.Location = new System.Drawing.Point(6, 209);
            this.labelDeciphered.Name = "labelDeciphered";
            this.labelDeciphered.Size = new System.Drawing.Size(83, 13);
            this.labelDeciphered.TabIndex = 29;
            this.labelDeciphered.Text = "Decrypted Text:";
            // 
            // labelCiphered
            // 
            this.labelCiphered.AutoSize = true;
            this.labelCiphered.Location = new System.Drawing.Point(6, 130);
            this.labelCiphered.Name = "labelCiphered";
            this.labelCiphered.Size = new System.Drawing.Size(162, 13);
            this.labelCiphered.TabIndex = 28;
            this.labelCiphered.Text = "Encrypted Text (Base64 Format):";
            // 
            // labelInputText
            // 
            this.labelInputText.AutoSize = true;
            this.labelInputText.Location = new System.Drawing.Point(6, 54);
            this.labelInputText.Name = "labelInputText";
            this.labelInputText.Size = new System.Drawing.Size(87, 13);
            this.labelInputText.TabIndex = 27;
            this.labelInputText.Text = "Input(Plain) Text:";
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(99, 286);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(75, 23);
            this.buttonDecrypt.TabIndex = 26;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(9, 286);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(75, 23);
            this.buttonEncrypt.TabIndex = 25;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // textBoxDeciphered
            // 
            this.textBoxDeciphered.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDeciphered.Location = new System.Drawing.Point(9, 225);
            this.textBoxDeciphered.Multiline = true;
            this.textBoxDeciphered.Name = "textBoxDeciphered";
            this.textBoxDeciphered.ReadOnly = true;
            this.textBoxDeciphered.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDeciphered.Size = new System.Drawing.Size(404, 55);
            this.textBoxDeciphered.TabIndex = 24;
            // 
            // textBoxCiphered
            // 
            this.textBoxCiphered.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCiphered.Location = new System.Drawing.Point(9, 146);
            this.textBoxCiphered.Multiline = true;
            this.textBoxCiphered.Name = "textBoxCiphered";
            this.textBoxCiphered.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCiphered.Size = new System.Drawing.Size(404, 55);
            this.textBoxCiphered.TabIndex = 23;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInput.Location = new System.Drawing.Point(9, 70);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput.Size = new System.Drawing.Size(404, 55);
            this.textBoxInput.TabIndex = 22;
            // 
            // PrivateKeyCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 315);
            this.Controls.Add(this.labelDeciphered);
            this.Controls.Add(this.labelCiphered);
            this.Controls.Add(this.labelInputText);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.textBoxDeciphered);
            this.Controls.Add(this.textBoxCiphered);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.textBoxSalt);
            this.Controls.Add(this.labelSalt);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.comboBoxAlgorithm);
            this.Controls.Add(this.labelAlgorithm);
            this.Name = "PrivateKeyCipher";
            this.Text = "Private Key Cipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.ComboBox comboBoxAlgorithm;
        private System.Windows.Forms.Label labelAlgorithm;
        private System.Windows.Forms.TextBox textBoxSalt;
        private System.Windows.Forms.Label labelSalt;
        private System.Windows.Forms.Label labelDeciphered;
        private System.Windows.Forms.Label labelCiphered;
        private System.Windows.Forms.Label labelInputText;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.TextBox textBoxDeciphered;
        private System.Windows.Forms.TextBox textBoxCiphered;
        private System.Windows.Forms.TextBox textBoxInput;
    }
}