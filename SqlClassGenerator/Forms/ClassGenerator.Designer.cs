namespace SqlClassGenerator.Forms
{
    partial class ClassGenerator
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.comboTables = new System.Windows.Forms.ComboBox();
            this.lblTables = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.btnColumnChooser = new System.Windows.Forms.Button();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.lblClassName = new System.Windows.Forms.Label();
            this.checkAutoProperty = new System.Windows.Forms.CheckBox();
            this.lblAutoProperty = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblAutoProperty);
            this.panelTop.Controls.Add(this.checkAutoProperty);
            this.panelTop.Controls.Add(this.lblClassName);
            this.panelTop.Controls.Add(this.txtClassName);
            this.panelTop.Controls.Add(this.comboTables);
            this.panelTop.Controls.Add(this.lblTables);
            this.panelTop.Controls.Add(this.btnGenerate);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(598, 94);
            this.panelTop.TabIndex = 0;
            // 
            // comboTables
            // 
            this.comboTables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTables.FormattingEnabled = true;
            this.comboTables.Location = new System.Drawing.Point(91, 12);
            this.comboTables.Name = "comboTables";
            this.comboTables.Size = new System.Drawing.Size(495, 21);
            this.comboTables.TabIndex = 2;
            // 
            // lblTables
            // 
            this.lblTables.AutoSize = true;
            this.lblTables.Location = new System.Drawing.Point(43, 15);
            this.lblTables.Name = "lblTables";
            this.lblTables.Size = new System.Drawing.Size(42, 13);
            this.lblTables.TabIndex = 1;
            this.lblTables.Text = "Tables:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(511, 63);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnColumnChooser);
            this.panelBottom.Controls.Add(this.btnSettings);
            this.panelBottom.Controls.Add(this.btnCopy);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 443);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(598, 46);
            this.panelBottom.TabIndex = 1;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(12, 11);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Enabled = false;
            this.btnCopy.Location = new System.Drawing.Point(511, 11);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // richTextBox
            // 
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox.Location = new System.Drawing.Point(0, 94);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(598, 349);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            // 
            // btnColumnChooser
            // 
            this.btnColumnChooser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColumnChooser.Enabled = false;
            this.btnColumnChooser.Location = new System.Drawing.Point(430, 11);
            this.btnColumnChooser.Name = "btnColumnChooser";
            this.btnColumnChooser.Size = new System.Drawing.Size(75, 23);
            this.btnColumnChooser.TabIndex = 2;
            this.btnColumnChooser.Text = "Columns";
            this.btnColumnChooser.UseVisualStyleBackColor = true;
            this.btnColumnChooser.Click += new System.EventHandler(this.btnColumnChooser_Click);
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(91, 39);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(495, 20);
            this.txtClassName.TabIndex = 3;
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(21, 42);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(64, 13);
            this.lblClassName.TabIndex = 4;
            this.lblClassName.Text = "Class name:";
            // 
            // checkAutoProperty
            // 
            this.checkAutoProperty.AutoSize = true;
            this.checkAutoProperty.Location = new System.Drawing.Point(91, 68);
            this.checkAutoProperty.Name = "checkAutoProperty";
            this.checkAutoProperty.Size = new System.Drawing.Size(15, 14);
            this.checkAutoProperty.TabIndex = 5;
            this.checkAutoProperty.UseVisualStyleBackColor = true;
            // 
            // lblAutoProperty
            // 
            this.lblAutoProperty.AutoSize = true;
            this.lblAutoProperty.Location = new System.Drawing.Point(12, 68);
            this.lblAutoProperty.Name = "lblAutoProperty";
            this.lblAutoProperty.Size = new System.Drawing.Size(73, 13);
            this.lblAutoProperty.TabIndex = 7;
            this.lblAutoProperty.Text = "Auto property:";
            // 
            // ClassGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 489);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "ClassGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Class Generator";
            this.Shown += new System.EventHandler(this.ClassGenerator_Shown);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.ComboBox comboTables;
        private System.Windows.Forms.Label lblTables;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnColumnChooser;
        private System.Windows.Forms.Label lblAutoProperty;
        private System.Windows.Forms.CheckBox checkAutoProperty;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.TextBox txtClassName;
    }
}