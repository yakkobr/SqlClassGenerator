namespace SqlClassGenerator.Forms
{
    partial class ColumnSelector
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
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnMarkAll = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.columnField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSqlType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCSharpType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnMarkNone = new System.Windows.Forms.Button();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnMarkNone);
            this.panelBottom.Controls.Add(this.btnMarkAll);
            this.panelBottom.Controls.Add(this.btnOk);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 331);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(462, 49);
            this.panelBottom.TabIndex = 0;
            // 
            // btnMarkAll
            // 
            this.btnMarkAll.Location = new System.Drawing.Point(12, 14);
            this.btnMarkAll.Name = "btnMarkAll";
            this.btnMarkAll.Size = new System.Drawing.Size(75, 23);
            this.btnMarkAll.TabIndex = 1;
            this.btnMarkAll.Text = "Select all";
            this.btnMarkAll.UseVisualStyleBackColor = true;
            this.btnMarkAll.Click += new System.EventHandler(this.btnMarkAll_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(375, 14);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // listView
            // 
            this.listView.CheckBoxes = true;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnField,
            this.columnSqlType,
            this.columnCSharpType});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(462, 331);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnField
            // 
            this.columnField.Text = "Column";
            this.columnField.Width = 200;
            // 
            // columnSqlType
            // 
            this.columnSqlType.Text = "SQL Type";
            this.columnSqlType.Width = 100;
            // 
            // columnCSharpType
            // 
            this.columnCSharpType.Text = "C# Type";
            this.columnCSharpType.Width = 100;
            // 
            // btnMarkNone
            // 
            this.btnMarkNone.Location = new System.Drawing.Point(93, 14);
            this.btnMarkNone.Name = "btnMarkNone";
            this.btnMarkNone.Size = new System.Drawing.Size(75, 23);
            this.btnMarkNone.TabIndex = 2;
            this.btnMarkNone.Text = "Select none";
            this.btnMarkNone.UseVisualStyleBackColor = true;
            this.btnMarkNone.Click += new System.EventHandler(this.btnMarkNone_Click);
            // 
            // ColumnSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 380);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.panelBottom);
            this.Name = "ColumnSelector";
            this.Text = "ColumnSelector";
            this.Load += new System.EventHandler(this.ColumnSelector_Load);
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnField;
        private System.Windows.Forms.ColumnHeader columnSqlType;
        private System.Windows.Forms.Button btnMarkAll;
        private System.Windows.Forms.ColumnHeader columnCSharpType;
        private System.Windows.Forms.Button btnMarkNone;
    }
}