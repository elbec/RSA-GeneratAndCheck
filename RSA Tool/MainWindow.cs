using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace RSA_Tool
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Ceate private and public key
        private void createKeys_Click(object sender, EventArgs e)
        {
            textBoxPrivateKey.Text = "";
            textBoxPublicKey.Text = "";

            var rsa = new RSACryptoServiceProvider();
            textBoxPrivateKey.Text = rsa.ToXmlString(true);
            textBoxPublicKey.Text = rsa.ToXmlString(false);

            pictureBox_createKeys.BackColor = Color.Salmon;

            //Reset ColorBars
            pictureBox_check.BackColor = Color.Transparent;
            pictureBox_Sign.BackColor = Color.Transparent;
            pictureBox_Sign1.BackColor = Color.Transparent;

        }

        //Bytes to HEX
        public static string BytesToHex(byte[] bytes)
        {
            var hexstring = new StringBuilder(bytes.Length);
            for(int i = 0; i < bytes.Length;i++)
            {
                hexstring.Append(bytes[i].ToString("X2"));
            }
            return hexstring.ToString();
        }

        //Sign source text with private key
        private void signtext_Click(object sender, EventArgs e)
        {
                try
                {
                    var rsa = new RSACryptoServiceProvider();
                    rsa.FromXmlString(textBoxPrivateKey.Text);

                    var encryptedSymmetricKey = rsa.SignData(Encoding.Unicode.GetBytes(textBoxSourceText.Text), new SHA1CryptoServiceProvider());
                    textBoxSignature.Text = BytesToHex(encryptedSymmetricKey);
                }
                catch
                {
                    MessageBox.Show("Wrong private and/or public key!");
                    return;
                }

                pictureBox_Sign.BackColor = Color.YellowGreen;
                pictureBox_Sign1.BackColor = Color.YellowGreen;
                //Reset ColorBars
                pictureBox_check.BackColor = Color.Transparent;
                pictureBox_createKeys.BackColor = Color.Transparent;
        }

        //HEX to Bytes
        public static byte[] StringToByteArray(String hex)
        {
            int numberChars = hex.Length;
            var bytes = new byte[numberChars / 2];
            for (int i = 0; i < numberChars; i+=2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            return bytes;
        }

        //Check if source text and signature matches
        private void checksign_Click(object sender, EventArgs e)
        {
            bool signOK = false;
            try
            {
                var rsa = new RSACryptoServiceProvider();
                rsa.FromXmlString(textBoxPublicKey.Text);

                byte[] signText = StringToByteArray(textBoxSignature.Text);
                byte[] originalText = Encoding.Unicode.GetBytes(textBoxSourceText.Text);

                signOK = rsa.VerifyData(originalText, new SHA1CryptoServiceProvider(), signText);
            }
            catch
            {
                MessageBox.Show("Wrong private and/or public key!");
                return;
            }

            pictureBox_Sign.BackColor = Color.DodgerBlue;
            pictureBox_check.BackColor = Color.DodgerBlue;
            //Reset ColorBars
            pictureBox_createKeys.BackColor = Color.Transparent;
            pictureBox_Sign1.BackColor = Color.Transparent;

            MessageBox.Show("Signature and source text matches: " + signOK);
        }

    }
}
