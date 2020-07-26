namespace RSA_Tool
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.textBoxPrivateKey = new System.Windows.Forms.TextBox();
            this.textBoxPublicKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createKeys = new System.Windows.Forms.Button();
            this.textBoxSignature = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.signtext = new System.Windows.Forms.Button();
            this.textBoxSourceText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checksign = new System.Windows.Forms.Button();
            this.pictureBox_createKeys = new System.Windows.Forms.PictureBox();
            this.pictureBox_Sign = new System.Windows.Forms.PictureBox();
            this.pictureBox_Sign1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_check = new System.Windows.Forms.PictureBox();
            this.btn_loadKeys = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_createLicenseFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_createKeys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Sign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Sign1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_check)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPrivateKey
            // 
            this.textBoxPrivateKey.Location = new System.Drawing.Point(37, 51);
            this.textBoxPrivateKey.Multiline = true;
            this.textBoxPrivateKey.Name = "textBoxPrivateKey";
            this.textBoxPrivateKey.Size = new System.Drawing.Size(250, 200);
            this.textBoxPrivateKey.TabIndex = 0;
            // 
            // textBoxPublicKey
            // 
            this.textBoxPublicKey.Location = new System.Drawing.Point(382, 51);
            this.textBoxPublicKey.Multiline = true;
            this.textBoxPublicKey.Name = "textBoxPublicKey";
            this.textBoxPublicKey.Size = new System.Drawing.Size(250, 200);
            this.textBoxPublicKey.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Private Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Public Key";
            // 
            // createKeys
            // 
            this.createKeys.BackColor = System.Drawing.Color.Salmon;
            this.createKeys.Location = new System.Drawing.Point(302, 51);
            this.createKeys.Name = "createKeys";
            this.createKeys.Size = new System.Drawing.Size(66, 61);
            this.createKeys.TabIndex = 4;
            this.createKeys.Text = "Create Keys";
            this.createKeys.UseVisualStyleBackColor = false;
            this.createKeys.Click += new System.EventHandler(this.createKeys_Click);
            // 
            // textBoxSignature
            // 
            this.textBoxSignature.Location = new System.Drawing.Point(382, 301);
            this.textBoxSignature.Multiline = true;
            this.textBoxSignature.Name = "textBoxSignature";
            this.textBoxSignature.Size = new System.Drawing.Size(250, 200);
            this.textBoxSignature.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Signature";
            // 
            // signtext
            // 
            this.signtext.BackColor = System.Drawing.Color.YellowGreen;
            this.signtext.Location = new System.Drawing.Point(302, 301);
            this.signtext.Name = "signtext";
            this.signtext.Size = new System.Drawing.Size(66, 61);
            this.signtext.TabIndex = 7;
            this.signtext.Text = "Encrypt Source Text And Save All";
            this.signtext.UseVisualStyleBackColor = false;
            this.signtext.Click += new System.EventHandler(this.encryptText_Click);
            // 
            // textBoxSourceText
            // 
            this.textBoxSourceText.Location = new System.Drawing.Point(41, 301);
            this.textBoxSourceText.Multiline = true;
            this.textBoxSourceText.Name = "textBoxSourceText";
            this.textBoxSourceText.Size = new System.Drawing.Size(250, 200);
            this.textBoxSourceText.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Source Text";
            // 
            // checksign
            // 
            this.checksign.BackColor = System.Drawing.Color.DodgerBlue;
            this.checksign.Location = new System.Drawing.Point(302, 440);
            this.checksign.Name = "checksign";
            this.checksign.Size = new System.Drawing.Size(66, 61);
            this.checksign.TabIndex = 10;
            this.checksign.Text = "Verify Signature";
            this.checksign.UseVisualStyleBackColor = false;
            this.checksign.Click += new System.EventHandler(this.checksign_Click);
            // 
            // pictureBox_createKeys
            // 
            this.pictureBox_createKeys.Location = new System.Drawing.Point(37, 257);
            this.pictureBox_createKeys.Name = "pictureBox_createKeys";
            this.pictureBox_createKeys.Size = new System.Drawing.Size(595, 15);
            this.pictureBox_createKeys.TabIndex = 11;
            this.pictureBox_createKeys.TabStop = false;
            // 
            // pictureBox_Sign
            // 
            this.pictureBox_Sign.Location = new System.Drawing.Point(16, 507);
            this.pictureBox_Sign.Name = "pictureBox_Sign";
            this.pictureBox_Sign.Size = new System.Drawing.Size(637, 15);
            this.pictureBox_Sign.TabIndex = 12;
            this.pictureBox_Sign.TabStop = false;
            // 
            // pictureBox_Sign1
            // 
            this.pictureBox_Sign1.Location = new System.Drawing.Point(16, 51);
            this.pictureBox_Sign1.Name = "pictureBox_Sign1";
            this.pictureBox_Sign1.Size = new System.Drawing.Size(15, 457);
            this.pictureBox_Sign1.TabIndex = 13;
            this.pictureBox_Sign1.TabStop = false;
            // 
            // pictureBox_check
            // 
            this.pictureBox_check.Location = new System.Drawing.Point(638, 50);
            this.pictureBox_check.Name = "pictureBox_check";
            this.pictureBox_check.Size = new System.Drawing.Size(15, 457);
            this.pictureBox_check.TabIndex = 14;
            this.pictureBox_check.TabStop = false;
            // 
            // btn_loadKeys
            // 
            this.btn_loadKeys.BackColor = System.Drawing.Color.Violet;
            this.btn_loadKeys.Location = new System.Drawing.Point(302, 190);
            this.btn_loadKeys.Name = "btn_loadKeys";
            this.btn_loadKeys.Size = new System.Drawing.Size(66, 61);
            this.btn_loadKeys.TabIndex = 15;
            this.btn_loadKeys.Text = "Load Data By Signature";
            this.btn_loadKeys.UseVisualStyleBackColor = false;
            this.btn_loadKeys.Click += new System.EventHandler(this.btn_loadData_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(668, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // btn_createLicenseFile
            // 
            this.btn_createLicenseFile.BackColor = System.Drawing.Color.DarkGray;
            this.btn_createLicenseFile.Location = new System.Drawing.Point(302, 368);
            this.btn_createLicenseFile.Name = "btn_createLicenseFile";
            this.btn_createLicenseFile.Size = new System.Drawing.Size(66, 61);
            this.btn_createLicenseFile.TabIndex = 17;
            this.btn_createLicenseFile.Text = "Create License File";
            this.btn_createLicenseFile.UseVisualStyleBackColor = false;
            this.btn_createLicenseFile.Click += new System.EventHandler(this.btn_createLicenseFile_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 532);
            this.Controls.Add(this.btn_createLicenseFile);
            this.Controls.Add(this.btn_loadKeys);
            this.Controls.Add(this.pictureBox_check);
            this.Controls.Add(this.pictureBox_Sign1);
            this.Controls.Add(this.pictureBox_Sign);
            this.Controls.Add(this.pictureBox_createKeys);
            this.Controls.Add(this.checksign);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSourceText);
            this.Controls.Add(this.signtext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSignature);
            this.Controls.Add(this.createKeys);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPublicKey);
            this.Controls.Add(this.textBoxPrivateKey);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "RSA - Generate and Check Key";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_createKeys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Sign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Sign1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_check)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPrivateKey;
        private System.Windows.Forms.TextBox textBoxPublicKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createKeys;
        private System.Windows.Forms.TextBox textBoxSignature;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button signtext;
        private System.Windows.Forms.TextBox textBoxSourceText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button checksign;
        private System.Windows.Forms.PictureBox pictureBox_createKeys;
        private System.Windows.Forms.PictureBox pictureBox_Sign;
        private System.Windows.Forms.PictureBox pictureBox_Sign1;
        private System.Windows.Forms.PictureBox pictureBox_check;
        private System.Windows.Forms.Button btn_loadKeys;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Button btn_createLicenseFile;
    }
}

