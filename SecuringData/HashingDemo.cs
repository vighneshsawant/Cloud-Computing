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
    public partial class HashingDemo : Form
    {
        enum HashingAlgorithms { MD5, RIPEMD160, SHA1, SHA256, SHA384, SHA512, MACTripleDES, HMACSHA1 };
        public HashingDemo()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            comboBoxAlgorithm.DataSource = Enum.GetNames(typeof(HashingAlgorithms));
            comboBoxAlgorithm.SelectedIndex = 0;
        }

        //hash the input and display the result 
        private void buttonComputeHash_Click(object sender, EventArgs e)
        {
            byte[] input = Encoding.ASCII.GetBytes(textBoxInput.Text);

            HashAlgorithm Alg = GetSelectedAlgorithm();
            Alg.ComputeHash(input);

            textBoxHash.Text = Convert.ToBase64String(Alg.Hash);
        }

        private HashAlgorithm GetSelectedAlgorithm()
        {
            //for keyed hashing algorithms only
            Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(textBoxKey.Text,
                Encoding.ASCII.GetBytes(textBoxSalt.Text));

            HashAlgorithm Alg = null;
            if (comboBoxAlgorithm.SelectedIndex == 0)
                Alg = new MD5CryptoServiceProvider();
            else if (comboBoxAlgorithm.SelectedIndex == 1)
                Alg = new RIPEMD160Managed();
            else if (comboBoxAlgorithm.SelectedIndex == 2)
                Alg = new SHA1CryptoServiceProvider();
            else if (comboBoxAlgorithm.SelectedIndex == 3)
                Alg = new SHA256Managed();
            else if (comboBoxAlgorithm.SelectedIndex == 4)
                Alg = new SHA384Managed();           
            else if (comboBoxAlgorithm.SelectedIndex == 5)
                Alg = new  SHA512Managed();
            else if (comboBoxAlgorithm.SelectedIndex == 6)
                Alg = new MACTripleDES(rfc.GetBytes(16));//only 8,16,24 bytes accepted
            else if (comboBoxAlgorithm.SelectedIndex == 7)
                Alg = new HMACSHA1(rfc.GetBytes(29));

            return Alg;
        }

        private void comboBoxAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAlgorithm.SelectedIndex < 6)
            {
                textBoxKey.Enabled = false;
                textBoxSalt.Enabled = false;
            }
            else
            {
                textBoxKey.Enabled = true;
                textBoxSalt.Enabled = true;
            }
        }
    }
}