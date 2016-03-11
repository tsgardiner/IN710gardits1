using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionTool
{
    public partial class Form1 : Form
    {

        Encryption newEncryption;
        public Form1()
        {
            InitializeComponent();

            newEncryption = new Encryption();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string textToEncrypt = tbInput.Text;               

            if (rbROT13.Checked)
            {
                newEncryption.encryptionType = new ROT13();
            }
            else if(rbReverse.Checked)
            {
                newEncryption.encryptionType = new ReverseEncryption();
            }

            string encrptedText = newEncryption.PlainTextToCypher(textToEncrypt);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string textToDecrypt = tbInput.Text;

            if (rbROT13.Checked)
            {
                newEncryption.encryptionType = new ROT13();
            }
            else if (rbReverse.Checked)
            {
                newEncryption.encryptionType = new ReverseEncryption();
            }

            string encrptedText = newEncryption.CypherToText(textToDecrypt);
        }
    }
}
