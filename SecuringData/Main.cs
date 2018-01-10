//Copyright (c), October 2007, Some Rights Reserved 
//By Murat Firat

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SecuringData
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void privateKeyCipherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrivateKeyCipher prCip = new PrivateKeyCipher();
            ShowAsMDIChild(prCip);
                       
        }

        private void publicKeyCipherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PublicKeyCipher pbCip = new PublicKeyCipher();
            ShowAsMDIChild(pbCip);
        }

        private void hashingDemoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HashingDemo hashDemo = new HashingDemo();
            ShowAsMDIChild(hashDemo);
        }

        private void digitalSignatureDemoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DigitalSigDemo digDemo = new DigitalSigDemo();
            ShowAsMDIChild(digDemo);         
        }
        
        private void ShowAsMDIChild(Form child)
        {
            child.MdiParent = this;
            child.Show();
            child.WindowState = FormWindowState.Maximized;
        }

    }
}