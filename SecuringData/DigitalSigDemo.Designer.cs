namespace SecuringData
{
    partial class DigitalSigDemo
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
            this.comboBoxAlgorithm = new System.Windows.Forms.ComboBox();
            this.labelAlgorithm = new System.Windows.Forms.Label();
            this.textBoxSign = new System.Windows.Forms.TextBox();
            this.labelMes = new System.Windows.Forms.Label();
            this.textBoxSignature = new System.Windows.Forms.TextBox();
            this.labelHash = new System.Windows.Forms.Label();
            this.groupBoxKeys = new System.Windows.Forms.GroupBox();
            this.labelPublicKey = new System.Windows.Forms.Label();
            this.textBoxPublicKey = new System.Windows.Forms.TextBox();
            this.textBoxPrivateKey = new System.Windows.Forms.TextBox();
            this.labelPrivateKey = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxVerify = new System.Windows.Forms.TextBox();
            this.labelRecMes = new System.Windows.Forms.Label();
            this.buttonSign = new System.Windows.Forms.Button();
            this.buttonVerify = new System.Windows.Forms.Button();
            this.labelIsVerified = new System.Windows.Forms.Label();
            this.groupBoxKeys.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxAlgorithm
            // 
            this.comboBoxAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAlgorithm.FormattingEnabled = true;
            this.comboBoxAlgorithm.Location = new System.Drawing.Point(287, 32);
            this.comboBoxAlgorithm.Name = "comboBoxAlgorithm";
            this.comboBoxAlgorithm.Size = new System.Drawing.Size(71, 21);
            this.comboBoxAlgorithm.TabIndex = 7;
            // 
            // labelAlgorithm
            // 
            this.labelAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAlgorithm.AutoSize = true;
            this.labelAlgorithm.Location = new System.Drawing.Point(284, 16);
            this.labelAlgorithm.Name = "labelAlgorithm";
            this.labelAlgorithm.Size = new System.Drawing.Size(53, 13);
            this.labelAlgorithm.TabIndex = 6;
            this.labelAlgorithm.Text = "Algorithm:";
            // 
            // textBoxSign
            // 
            this.textBoxSign.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSign.Location = new System.Drawing.Point(9, 32);
            this.textBoxSign.Multiline = true;
            this.textBoxSign.Name = "textBoxSign";
            this.textBoxSign.Size = new System.Drawing.Size(275, 37);
            this.textBoxSign.TabIndex = 8;
            // 
            // labelMes
            // 
            this.labelMes.AutoSize = true;
            this.labelMes.Location = new System.Drawing.Point(9, 16);
            this.labelMes.Name = "labelMes";
            this.labelMes.Size = new System.Drawing.Size(121, 13);
            this.labelMes.TabIndex = 9;
            this.labelMes.Text = "Message To Be Signed:";
            // 
            // textBoxSignature
            // 
            this.textBoxSignature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSignature.Location = new System.Drawing.Point(12, 35);
            this.textBoxSignature.Name = "textBoxSignature";
            this.textBoxSignature.Size = new System.Drawing.Size(346, 20);
            this.textBoxSignature.TabIndex = 10;
            // 
            // labelHash
            // 
            this.labelHash.AutoSize = true;
            this.labelHash.Location = new System.Drawing.Point(9, 16);
            this.labelHash.Name = "labelHash";
            this.labelHash.Size = new System.Drawing.Size(275, 13);
            this.labelHash.TabIndex = 11;
            this.labelHash.Text = "Signature (Encrypted Hash of Message, Base64 Format):";
            // 
            // groupBoxKeys
            // 
            this.groupBoxKeys.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxKeys.Controls.Add(this.labelPublicKey);
            this.groupBoxKeys.Controls.Add(this.textBoxPublicKey);
            this.groupBoxKeys.Controls.Add(this.textBoxPrivateKey);
            this.groupBoxKeys.Controls.Add(this.labelPrivateKey);
            this.groupBoxKeys.Location = new System.Drawing.Point(12, 12);
            this.groupBoxKeys.Name = "groupBoxKeys";
            this.groupBoxKeys.Size = new System.Drawing.Size(367, 103);
            this.groupBoxKeys.TabIndex = 12;
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
            this.textBoxPublicKey.Size = new System.Drawing.Size(308, 37);
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
            this.textBoxPrivateKey.Size = new System.Drawing.Size(308, 37);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.comboBoxAlgorithm);
            this.groupBox1.Controls.Add(this.labelAlgorithm);
            this.groupBox1.Controls.Add(this.textBoxSign);
            this.groupBox1.Controls.Add(this.labelMes);
            this.groupBox1.Location = new System.Drawing.Point(12, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 76);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign Message";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBoxVerify);
            this.groupBox2.Controls.Add(this.labelRecMes);
            this.groupBox2.Controls.Add(this.textBoxSignature);
            this.groupBox2.Controls.Add(this.labelHash);
            this.groupBox2.Location = new System.Drawing.Point(12, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 120);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Verify Message";
            // 
            // textBoxVerify
            // 
            this.textBoxVerify.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVerify.Location = new System.Drawing.Point(12, 74);
            this.textBoxVerify.Multiline = true;
            this.textBoxVerify.Name = "textBoxVerify";
            this.textBoxVerify.Size = new System.Drawing.Size(346, 37);
            this.textBoxVerify.TabIndex = 12;
            // 
            // labelRecMes
            // 
            this.labelRecMes.AutoSize = true;
            this.labelRecMes.Location = new System.Drawing.Point(9, 58);
            this.labelRecMes.Name = "labelRecMes";
            this.labelRecMes.Size = new System.Drawing.Size(102, 13);
            this.labelRecMes.TabIndex = 13;
            this.labelRecMes.Text = "Received Message:";
            // 
            // buttonSign
            // 
            this.buttonSign.Location = new System.Drawing.Point(12, 329);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(96, 23);
            this.buttonSign.TabIndex = 15;
            this.buttonSign.Text = "Sign Message";
            this.buttonSign.UseVisualStyleBackColor = true;
            this.buttonSign.Click += new System.EventHandler(this.buttonSign_Click);
            // 
            // buttonVerify
            // 
            this.buttonVerify.Location = new System.Drawing.Point(123, 329);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(96, 23);
            this.buttonVerify.TabIndex = 16;
            this.buttonVerify.Text = "Verify Message";
            this.buttonVerify.UseVisualStyleBackColor = true;
            this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click);
            // 
            // labelIsVerified
            // 
            this.labelIsVerified.AutoSize = true;
            this.labelIsVerified.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelIsVerified.ForeColor = System.Drawing.Color.Red;
            this.labelIsVerified.Location = new System.Drawing.Point(225, 334);
            this.labelIsVerified.Name = "labelIsVerified";
            this.labelIsVerified.Size = new System.Drawing.Size(32, 13);
            this.labelIsVerified.TabIndex = 17;
            this.labelIsVerified.Text = "State";
            // 
            // DigitalSigDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 354);
            this.Controls.Add(this.labelIsVerified);
            this.Controls.Add(this.buttonVerify);
            this.Controls.Add(this.buttonSign);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxKeys);
            this.Name = "DigitalSigDemo";
            this.Text = "Digital Signature Demo";
            this.groupBoxKeys.ResumeLayout(false);
            this.groupBoxKeys.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAlgorithm;
        private System.Windows.Forms.Label labelAlgorithm;
        private System.Windows.Forms.TextBox textBoxSign;
        private System.Windows.Forms.Label labelMes;
        private System.Windows.Forms.TextBox textBoxSignature;
        private System.Windows.Forms.Label labelHash;
        private System.Windows.Forms.GroupBox groupBoxKeys;
        private System.Windows.Forms.Label labelPublicKey;
        private System.Windows.Forms.TextBox textBoxPublicKey;
        private System.Windows.Forms.TextBox textBoxPrivateKey;
        private System.Windows.Forms.Label labelPrivateKey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxVerify;
        private System.Windows.Forms.Label labelRecMes;
        private System.Windows.Forms.Button buttonSign;
        private System.Windows.Forms.Button buttonVerify;
        private System.Windows.Forms.Label labelIsVerified;
    }
}