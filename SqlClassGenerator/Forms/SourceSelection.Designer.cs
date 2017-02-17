namespace SqlClassGenerator.Forms
{
    partial class SourceSelection
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblProvider = new System.Windows.Forms.Label();
            this.lvlServer = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.comboProvider = new System.Windows.Forms.ComboBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConnectToServer = new System.Windows.Forms.Button();
            this.checkWindowsAuthentication = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.lblProvider, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.lvlServer, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.lblUser, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.lblPassword, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.comboProvider, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.txtServer, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.txtUser, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.txtPassword, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.btnConnectToServer, 1, 6);
            this.tableLayoutPanel.Controls.Add(this.checkWindowsAuthentication, 1, 5);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 8;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(317, 190);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // lblProvider
            // 
            this.lblProvider.AutoSize = true;
            this.lblProvider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProvider.Location = new System.Drawing.Point(3, 0);
            this.lblProvider.Name = "lblProvider";
            this.lblProvider.Size = new System.Drawing.Size(94, 26);
            this.lblProvider.TabIndex = 0;
            this.lblProvider.Text = "Provider:";
            this.lblProvider.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvlServer
            // 
            this.lvlServer.AutoSize = true;
            this.lvlServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvlServer.Location = new System.Drawing.Point(3, 52);
            this.lvlServer.Name = "lvlServer";
            this.lvlServer.Size = new System.Drawing.Size(94, 26);
            this.lvlServer.TabIndex = 1;
            this.lvlServer.Text = "Server:";
            this.lvlServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUser.Location = new System.Drawing.Point(3, 78);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(94, 26);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "User:";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassword.Location = new System.Drawing.Point(3, 104);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(94, 26);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboProvider
            // 
            this.comboProvider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProvider.FormattingEnabled = true;
            this.comboProvider.Location = new System.Drawing.Point(103, 3);
            this.comboProvider.Name = "comboProvider";
            this.comboProvider.Size = new System.Drawing.Size(194, 21);
            this.comboProvider.TabIndex = 5;
            this.comboProvider.SelectedIndexChanged += new System.EventHandler(this.comboProvider_SelectedIndexChanged);
            // 
            // txtServer
            // 
            this.txtServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtServer.Enabled = false;
            this.txtServer.Location = new System.Drawing.Point(103, 55);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(194, 20);
            this.txtServer.TabIndex = 6;
            // 
            // txtUser
            // 
            this.txtUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUser.Enabled = false;
            this.txtUser.Location = new System.Drawing.Point(103, 81);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(194, 20);
            this.txtUser.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(103, 107);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(194, 20);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnConnectToServer
            // 
            this.btnConnectToServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnectToServer.Enabled = false;
            this.btnConnectToServer.Location = new System.Drawing.Point(103, 157);
            this.btnConnectToServer.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnConnectToServer.Name = "btnConnectToServer";
            this.btnConnectToServer.Size = new System.Drawing.Size(194, 24);
            this.btnConnectToServer.TabIndex = 11;
            this.btnConnectToServer.Text = "Connect";
            this.btnConnectToServer.UseVisualStyleBackColor = true;
            this.btnConnectToServer.Click += new System.EventHandler(this.btnConnectToServer_Click);
            // 
            // checkWindowsAuthentication
            // 
            this.checkWindowsAuthentication.AutoSize = true;
            this.checkWindowsAuthentication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkWindowsAuthentication.Enabled = false;
            this.checkWindowsAuthentication.Location = new System.Drawing.Point(103, 133);
            this.checkWindowsAuthentication.Name = "checkWindowsAuthentication";
            this.checkWindowsAuthentication.Size = new System.Drawing.Size(194, 20);
            this.checkWindowsAuthentication.TabIndex = 12;
            this.checkWindowsAuthentication.Text = "Windows authentication";
            this.checkWindowsAuthentication.UseVisualStyleBackColor = true;
            this.checkWindowsAuthentication.CheckedChanged += new System.EventHandler(this.checkWindowsAuthentication_CheckedChanged);
            // 
            // SourceSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 190);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "SourceSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Source";
            this.Load += new System.EventHandler(this.SourceSelection_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label lblProvider;
        private System.Windows.Forms.Label lvlServer;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.ComboBox comboProvider;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnConnectToServer;
        private System.Windows.Forms.CheckBox checkWindowsAuthentication;
    }
}