namespace SecuringData
{
    partial class HashingDemo
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
            this.textBoxSalt = new System.Windows.Forms.TextBox();
            this.labelSalt = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.labelKey = new System.Windows.Forms.Label();
            this.comboBoxAlgorithm = new System.Windows.Forms.ComboBox();
            this.labelAlgorithm = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelHash = new System.Windows.Forms.Label();
            this.textBoxHash = new System.Windows.Forms.TextBox();
            this.buttonComputeHash = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSalt
            // 
            this.textBoxSalt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSalt.Location = new System.Drawing.Point(238, 50);
            this.textBoxSalt.MaxLength = 8;
            this.textBoxSalt.Name = "textBoxSalt";
            this.textBoxSalt.Size = new System.Drawing.Size(128, 20);
            this.textBoxSalt.TabIndex = 15;
            this.textBoxSalt.Text = "Must be 8 or More Characters";
            // 
            // labelSalt
            // 
            this.labelSalt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSalt.AutoSize = true;
            this.labelSalt.Location = new System.Drawing.Point(204, 53);
            this.labelSalt.Name = "labelSalt";
            this.labelSalt.Size = new System.Drawing.Size(28, 13);
            this.labelSalt.TabIndex = 14;
            this.labelSalt.Text = "Salt:";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(66, 50);
            this.textBoxKey.MaxLength = 8;
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(128, 20);
            this.textBoxKey.TabIndex = 13;
            this.textBoxKey.Text = "Your Secret Key";
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(8, 53);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(28, 13);
            this.labelKey.TabIndex = 12;
            this.labelKey.Text = "Key:";
            // 
            // comboBoxAlgorithm
            // 
            this.comboBoxAlgorithm.FormattingEnabled = true;
            this.comboBoxAlgorithm.Location = new System.Drawing.Point(67, 15);
            this.comboBoxAlgorithm.Name = "comboBoxAlgorithm";
            this.comboBoxAlgorithm.Size = new System.Drawing.Size(127, 21);
            this.comboBoxAlgorithm.TabIndex = 11;
            this.comboBoxAlgorithm.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlgorithm_SelectedIndexChanged);
            // 
            // labelAlgorithm
            // 
            this.labelAlgorithm.AutoSize = true;
            this.labelAlgorithm.Location = new System.Drawing.Point(8, 18);
            this.labelAlgorithm.Name = "labelAlgorithm";
            this.labelAlgorithm.Size = new System.Drawing.Size(53, 13);
            this.labelAlgorithm.TabIndex = 10;
            this.labelAlgorithm.Text = "Algorithm:";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInput.Location = new System.Drawing.Point(11, 98);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput.Size = new System.Drawing.Size(355, 116);
            this.textBoxInput.TabIndex = 23;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(8, 82);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(58, 13);
            this.labelInput.TabIndex = 24;
            this.labelInput.Text = "Input Text:";
            // 
            // labelHash
            // 
            this.labelHash.AutoSize = true;
            this.labelHash.Location = new System.Drawing.Point(8, 227);
            this.labelHash.Name = "labelHash";
            this.labelHash.Size = new System.Drawing.Size(166, 13);
            this.labelHash.TabIndex = 25;
            this.labelHash.Text = "Computed Hash (Base64 Format):";
            // 
            // textBoxHash
            // 
            this.textBoxHash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHash.Location = new System.Drawing.Point(11, 243);
            this.textBoxHash.Multiline = true;
            this.textBoxHash.Name = "textBoxHash";
            this.textBoxHash.Size = new System.Drawing.Size(355, 33);
            this.textBoxHash.TabIndex = 26;
            // 
            // buttonComputeHash
            // 
            this.buttonComputeHash.Location = new System.Drawing.Point(11, 284);
            this.buttonComputeHash.Name = "buttonComputeHash";
            this.buttonComputeHash.Size = new System.Drawing.Size(98, 23);
            this.buttonComputeHash.TabIndex = 27;
            this.buttonComputeHash.Text = "Compute Hash";
            this.buttonComputeHash.UseVisualStyleBackColor = true;
            this.buttonComputeHash.Click += new System.EventHandler(this.buttonComputeHash_Click);
            // 
            // HashingDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 313);
            this.Controls.Add(this.buttonComputeHash);
            this.Controls.Add(this.textBoxHash);
            this.Controls.Add(this.labelHash);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.textBoxSalt);
            this.Controls.Add(this.labelSalt);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.comboBoxAlgorithm);
            this.Controls.Add(this.labelAlgorithm);
            this.Name = "HashingDemo";
            this.Text = "Hashing Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSalt;
        private System.Windows.Forms.Label labelSalt;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.ComboBox comboBoxAlgorithm;
        private System.Windows.Forms.Label labelAlgorithm;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelHash;
        private System.Windows.Forms.TextBox textBoxHash;
        private System.Windows.Forms.Button buttonComputeHash;
    }
}