using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Security.Cryptography;

namespace RSA_Tool
{
    public partial class MainWindow : Form
    {
        private static Architecture.SQL Arch = new Architecture.SQL();
        DataTable dt = new DataTable();

        public MainWindow()
        {
            InitializeComponent();

            //load data to DataTable
            Arch.LoadDataTable(ref dt, Properties.Settings.Default.rsaDBConnection, "Select * from dataTable;");
        }

        /// <summary>
        /// Convert HEX to Bytes
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public static byte[] StringToByteArray(String hex)
        {
            int numberChars = hex.Length;
            var bytes = new byte[numberChars / 2];
            for (int i = 0; i < numberChars; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            return bytes;
        }

        /// <summary>
        /// Convert Bytes to HEX
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string BytesToHex(byte[] bytes)
        {
            var hexstring = new StringBuilder(bytes.Length);
            for (int i = 0; i < bytes.Length; i++)
            {
                hexstring.Append(bytes[i].ToString("X2"));
            }
            return hexstring.ToString();
        }

        /// <summary>
        /// Creates the private and the associated public key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Encrypts the source text with the private key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void encryptText_Click(object sender, EventArgs e)
        {
            try
            {
                var rsa = new RSACryptoServiceProvider();
                rsa.FromXmlString(textBoxPrivateKey.Text);

                var encryptedSymmetricKey = rsa.SignData(Encoding.Unicode.GetBytes(textBoxSourceText.Text), new SHA1CryptoServiceProvider());
                textBoxSignature.Text = BytesToHex(encryptedSymmetricKey);

                //save keys in db
                if (dt.Rows.Count != 0)
                    Arch.RunSqlStatement(Properties.Settings.Default.rsaDBConnection, "INSERT INTO dataTable (Id, PrivateKey, PublicKey, SourceText, SignatureText) VALUES( (SELECT TOP 1 ID FROM dataTable ORDER BY ID DESC) + 1 ,'" + textBoxPrivateKey.Text + "', '" + textBoxPublicKey.Text + "', '" + textBoxSourceText.Text + "', '" + textBoxSignature.Text + "')");
                else
                    Arch.RunSqlStatement(Properties.Settings.Default.rsaDBConnection, "INSERT INTO dataTable (Id, PrivateKey, PublicKey, SourceText, SignatureText) VALUES( 0 ,'" + textBoxPrivateKey.Text + "', '" + textBoxPublicKey.Text + "', '" + textBoxSourceText.Text + "', '" + textBoxSignature.Text + "')");
            }
            catch
                {
                    MessageBox.Show("Wrong private and/or public key!", "Wrong keys", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                pictureBox_Sign.BackColor = Color.YellowGreen;
                pictureBox_Sign1.BackColor = Color.YellowGreen;
                //Reset ColorBars
                pictureBox_check.BackColor = Color.Transparent;
                pictureBox_createKeys.BackColor = Color.Transparent;
        }

        /// <summary>
        /// Checks the signatrue for validity with the public key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                MessageBox.Show("Wrong private and/or public key!", "Wrong keys", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            pictureBox_Sign.BackColor = Color.DodgerBlue;
            pictureBox_check.BackColor = Color.DodgerBlue;
            //Reset ColorBars
            pictureBox_createKeys.BackColor = Color.Transparent;
            pictureBox_Sign1.BackColor = Color.Transparent;

            MessageBox.Show("Signature and source text matches: " + signOK, "Signature Verification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_loadData_Click(object sender, EventArgs e)
        {
            DataTable searchedRows = new DataTable();
            Arch.LoadDataTable(ref searchedRows, Properties.Settings.Default.rsaDBConnection, "Select * from dataTable where SignatureText = '" + textBoxSignature.Text + "'");

            if (searchedRows.Rows.Count > 0) {
                textBoxPrivateKey.Text = searchedRows.Rows[0]["PrivateKey"].ToString();
                textBoxPublicKey.Text = searchedRows.Rows[0]["PublicKey"].ToString();
                textBoxSourceText.Text = searchedRows.Rows[0]["SourceText"].ToString();
            } else
            {
                textBoxPrivateKey.Text = String.Empty;
                textBoxPublicKey.Text = String.Empty;
                textBoxSourceText.Text = String.Empty;
                MessageBox.Show("No data with this signature was found!", "Wrong Signature", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
