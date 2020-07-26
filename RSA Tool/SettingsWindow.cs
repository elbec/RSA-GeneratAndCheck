using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RSA_Tool
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void SettingsWindow_Load(object sender, EventArgs e)
        {
            tb_dbPath.Text = Properties.Settings.Default.dataBasePath;
        }

        private void bt_browseDBPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MS SQL Server database file (*.mdf)|*.mdf";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName.ToString();
                tb_dbPath.Text = fileName;
                Properties.Settings.Default.dataBasePath = fileName;
                Properties.Settings.Default.Save();

                Application.Restart();
            }
                
        }
    }
}
