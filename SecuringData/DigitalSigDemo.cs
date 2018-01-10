//Copyright (c), October 2007, Some Rights Reserved 
//By Murat Firat

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SecuringData
{
    public partial class DigitalSigDemo : Form
    {
        enum DigSigAlgorithms { RSA, DSA };

        private RSACryptoServiceProvider rsaAlg = new RSACryptoServiceProvider();
        private DSACryptoServiceProvider dsaAlg = new DSACryptoServiceProvider();

        public DigitalSigDemo()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            comboBoxAlgorithm.DataSource = Enum.GetNames(typeof(DigSigAlgorithms));
            comboBoxAlgorithm.SelectedIndex = 0;
        }

        //sign message
        private void buttonSign_Click(object sender, EventArgs e)
        {
            byte[] MessageToBeSigned = Encoding.ASCII.GetBytes(textBoxSign.Text);
            byte[] signature = null;
            string publicParameters = null;
            string priavteParameters = null;

            if (comboBoxAlgorithm.SelectedIndex == 0)
            {
                signature = rsaAlg.SignData(MessageToBeSigned, "SHA1");
                publicParameters = rsaAlg.ToXmlString(false);
                priavteParameters = rsaAlg.ToXmlString(true);
            }
            else
            {
                signature = dsaAlg.SignData(MessageToBeSigned);
                publicParameters = dsaAlg.ToXmlString(false);
                priavteParameters = dsaAlg.ToXmlString(true);
            }

            textBoxVerify.Text = textBoxSign.Text;
            textBoxSignature.Text = Convert.ToBase64String(signature);
            textBoxPublicKey.Text = publicParameters;
            textBoxPrivateKey.Text = priavteParameters;
        }

        //verify message
        private void buttonVerify_Click(object sender, EventArgs e)
        {
            byte[] MessageToBeVerified = Encoding.ASCII.GetBytes(textBoxVerify.Text);
            byte[] signature = Convert.FromBase64String(textBoxSignature.Text);
            string publicParameters = textBoxPublicKey.Text;
            string priavteParameters = textBoxPrivateKey.Text;

            bool isVerified ;

            if (comboBoxAlgorithm.SelectedIndex == 0)
            {
                isVerified = rsaAlg.VerifyData(MessageToBeVerified, "SHA1", signature);
            }
            else
            {
                isVerified = dsaAlg.VerifyData(MessageToBeVerified, signature);
            }

            labelIsVerified.Text = isVerified ? "Message is Verified" : "Message is NOT Verified";
        }

    }
}