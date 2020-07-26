namespace RSA_Tool
{
    partial class SettingsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            this.lb_DBPath = new System.Windows.Forms.Label();
            this.tb_dbPath = new System.Windows.Forms.TextBox();
            this.bt_browseDBPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_DBPath
            // 
            this.lb_DBPath.AutoSize = true;
            this.lb_DBPath.Location = new System.Drawing.Point(12, 9);
            this.lb_DBPath.Name = "lb_DBPath";
            this.lb_DBPath.Size = new System.Drawing.Size(78, 13);
            this.lb_DBPath.TabIndex = 0;
            this.lb_DBPath.Text = "Database Path";
            // 
            // tb_dbPath
            // 
            this.tb_dbPath.Location = new System.Drawing.Point(95, 6);
            this.tb_dbPath.Name = "tb_dbPath";
            this.tb_dbPath.Size = new System.Drawing.Size(355, 20);
            this.tb_dbPath.TabIndex = 1;
            // 
            // bt_browseDBPath
            // 
            this.bt_browseDBPath.Location = new System.Drawing.Point(456, 5);
            this.bt_browseDBPath.Name = "bt_browseDBPath";
            this.bt_browseDBPath.Size = new System.Drawing.Size(25, 20);
            this.bt_browseDBPath.TabIndex = 2;
            this.bt_browseDBPath.Text = "...";
            this.bt_browseDBPath.UseVisualStyleBackColor = true;
            this.bt_browseDBPath.Click += new System.EventHandler(this.bt_browseDBPath_Click);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 106);
            this.Controls.Add(this.bt_browseDBPath);
            this.Controls.Add(this.tb_dbPath);
            this.Controls.Add(this.lb_DBPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(509, 145);
            this.MinimumSize = new System.Drawing.Size(509, 145);
            this.Name = "SettingsWindow";
            this.Text = "Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SettingsWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_DBPath;
        private System.Windows.Forms.TextBox tb_dbPath;
        private System.Windows.Forms.Button bt_browseDBPath;
    }
}