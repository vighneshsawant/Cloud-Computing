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
    public partial class PublicKeyCipher : Form
    {
        private RSACryptoServiceProvider rsaCipher;

        public PublicKeyCipher()
        {
            InitializeComponent();
            GenerateKeyPairs();
        }
        /*
         * Unlike symmetric ciphers, we are not free to choose our 
         * public-private key pairs. That is because these two keys
         * are mathematically linked each other. A proper way on 
         * creating these keys in .NET is to use an asymmetric class 
         * which generates these keys on its constructor. 
         */
        private void GenerateKeyPairs()
        {                        
            //Each time this constructor is called, 
            //a different public-private key pair is generated.
            rsaCipher = new RSACryptoServiceProvider();

            //retrieve public parameters
            textBoxPublicKey.Text = rsaCipher.ToXmlString(false);

            //retrieve private parameters
            textBoxPrivateKey.Text = rsaCipher.ToXmlString(true);            
        }

        /*
         * From MSDN Documentation:
         * "Asymmetric private keys should never be stored verbatim 
         * or in plain text on the local computer. If you need to 
         * store a private key, you should use a key container."
         * 
         * This method uses "CspParameters" class to store keys.
         */
        private void SaveOrLoadKey()
        {
            CspParameters csp = new CspParameters();
            csp.KeyContainerName = "PublicKeyDemo";
                  
            //if created before, loads the key
            //else generates new key and saves it to "PublicKeyDemo" container
            rsaCipher = new RSACryptoServiceProvider(csp);

            //retrieve public parameters
            textBoxPublicKey.Text = rsaCipher.ToXmlString(false);

            //retrieve private parameters
            textBoxPrivateKey.Text = rsaCipher.ToXmlString(true);
        }

        //if created, delete the key
        private void ClearKey()
        {
            CspParameters csp = new CspParameters();
            csp.KeyContainerName = "PublicKeyDemo";

            rsaCipher = new RSACryptoServiceProvider(csp);
            rsaCipher.PersistKeyInCsp = false;
            rsaCipher.Clear();
        }


        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            rsaCipher = new RSACryptoServiceProvider();

            string publicKey = textBoxPublicKey.Text;            
            rsaCipher.FromXmlString(publicKey);

            string plainText = textBoxPlain.Text;
            byte[] plainBytes = Encoding.ASCII.GetBytes(plainText);

            byte[] cipheredBytes = rsaCipher.Encrypt(plainBytes, true);
            string cipheredText = Convert.ToBase64String(cipheredBytes);

            textBoxCiphered.Text = cipheredText;
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            rsaCipher = new RSACryptoServiceProvider();

            string privateKey = textBoxPrivateKey.Text;
            rsaCipher.FromXmlString(privateKey);

            string cipheredText = textBoxCiphered.Text;
            byte[] cipheredBytes = Convert.FromBase64String(cipheredText);

            byte[] decipheredBytes = rsaCipher.Decrypt(cipheredBytes, true);
            string decipheredText = Encoding.ASCII.GetString(decipheredBytes);

            textBoxDeciphered.Text = decipheredText;
        }
                
    }
}