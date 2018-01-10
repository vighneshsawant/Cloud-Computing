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
using System.IO;

namespace SecuringData
{
    enum SymmetricCiphers { DES, AES, TripleDES, RC2 };

    public partial class PrivateKeyCipher : Form
    {
        public PrivateKeyCipher()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            comboBoxAlgorithm.DataSource = Enum.GetNames(typeof(SymmetricCiphers));            
            comboBoxAlgorithm.SelectedIndex = 0;
        }

        //Simple Private-Key Encryption Operation
        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            string password = textBoxKey.Text;
            string salt = textBoxSalt.Text;
            string plainText = textBoxInput.Text;
            byte[]plainBytes=Encoding.ASCII.GetBytes(plainText);

            //Rfc2898DeriveBytes: Used to Generate Strong Keys
            Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(password, 
                Encoding.ASCII.GetBytes(salt));//Non-English Alfhabets Will not Work on ASCII Encoding

            SymmetricAlgorithm Alg = GetSelectedAlgorithm();

            Alg.Key = rfc.GetBytes(Alg.KeySize / 8);
            Alg.IV = rfc.GetBytes(Alg.BlockSize / 8);

            MemoryStream strCiphered = new MemoryStream();//To Store Encrypted Data

            CryptoStream strCrypto = new CryptoStream(strCiphered, 
                Alg.CreateEncryptor(), CryptoStreamMode.Write);

            strCrypto.Write(plainBytes, 0, plainBytes.Length);
            strCrypto.Close();
            textBoxCiphered.Text = Convert.ToBase64String(strCiphered.ToArray());
            strCiphered.Close();
        }        

        //Simple Private-Key Decryption Operation
        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            string password = textBoxKey.Text;
            string salt = textBoxSalt.Text;
            string cipheredText = textBoxCiphered.Text;
            byte[] cipheredBytes = Convert.FromBase64String(cipheredText);

            //Rfc2898DeriveBytes: Used to Generate Strong Keys
            Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(password,
                Encoding.ASCII.GetBytes(salt));//Non-English Alfhabets Will not Work on ASCII Encoding

            SymmetricAlgorithm Alg = GetSelectedAlgorithm();

            Alg.Key = rfc.GetBytes(Alg.KeySize / 8);
            Alg.IV = rfc.GetBytes(Alg.BlockSize / 8);

            MemoryStream strDeciphered = new MemoryStream();//To Store Decrypted Data

            CryptoStream strCrypto = new CryptoStream(strDeciphered,
                Alg.CreateDecryptor(), CryptoStreamMode.Write);

            strCrypto.Write(cipheredBytes, 0, cipheredBytes.Length);
            strCrypto.Close();
            textBoxDeciphered.Text = Encoding.ASCII.GetString(strDeciphered.ToArray());
            strDeciphered.Close();
        }

        private SymmetricAlgorithm GetSelectedAlgorithm()
        {
            SymmetricAlgorithm Alg = null;
            if (comboBoxAlgorithm.SelectedIndex == 0)
                Alg = new DESCryptoServiceProvider();
            else if (comboBoxAlgorithm.SelectedIndex == 1)
                Alg = new RijndaelManaged();//RijndaelManaged: AES Algorithm in .NET
            else if (comboBoxAlgorithm.SelectedIndex == 2)
                Alg = new TripleDESCryptoServiceProvider();
            else
                Alg = new RC2CryptoServiceProvider();
            return Alg;
        }
    }
}