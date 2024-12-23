namespace project
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FirewallTutorHelpForm_Title_label = new System.Windows.Forms.Label();
            this.Close_HelpFormButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FirewallTutorHelpForm_Text_label = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-68, -10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1249, 864);
            this.dataGridView1.TabIndex = 0;
            // 
            // FirewallTutorHelpForm_Title_label
            // 
            this.FirewallTutorHelpForm_Title_label.AutoSize = true;
            this.FirewallTutorHelpForm_Title_label.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.FirewallTutorHelpForm_Title_label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirewallTutorHelpForm_Title_label.Location = new System.Drawing.Point(377, 39);
            this.FirewallTutorHelpForm_Title_label.Name = "FirewallTutorHelpForm_Title_label";
            this.FirewallTutorHelpForm_Title_label.Size = new System.Drawing.Size(237, 45);
            this.FirewallTutorHelpForm_Title_label.TabIndex = 1;
            this.FirewallTutorHelpForm_Title_label.Text = "FireWall Tutor";
            // 
            // Close_HelpFormButton
            // 
            this.Close_HelpFormButton.Location = new System.Drawing.Point(0, 0);
            this.Close_HelpFormButton.Name = "Close_HelpFormButton";
            this.Close_HelpFormButton.Size = new System.Drawing.Size(40, 33);
            this.Close_HelpFormButton.TabIndex = 3;
            this.Close_HelpFormButton.Text = "x";
            this.Close_HelpFormButton.UseVisualStyleBackColor = true;
            this.Close_HelpFormButton.Click += new System.EventHandler(this.Close_HelpFormButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.Close_HelpFormButton);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 33);
            this.panel1.TabIndex = 37;
            // 
            // FirewallTutorHelpForm_Text_label
            // 
            this.FirewallTutorHelpForm_Text_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirewallTutorHelpForm_Text_label.AutoSize = true;
            this.FirewallTutorHelpForm_Text_label.BackColor = System.Drawing.Color.DarkGray;
            this.FirewallTutorHelpForm_Text_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FirewallTutorHelpForm_Text_label.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirewallTutorHelpForm_Text_label.ForeColor = System.Drawing.Color.Black;
            this.FirewallTutorHelpForm_Text_label.Location = new System.Drawing.Point(51, 117);
            this.FirewallTutorHelpForm_Text_label.Name = "FirewallTutorHelpForm_Text_label";
            this.FirewallTutorHelpForm_Text_label.Size = new System.Drawing.Size(935, 682);
            this.FirewallTutorHelpForm_Text_label.TabIndex = 2;
            this.FirewallTutorHelpForm_Text_label.Text = resources.GetString("FirewallTutorHelpForm_Text_label.Text");
            this.FirewallTutorHelpForm_Text_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 793);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FirewallTutorHelpForm_Text_label);
            this.Controls.Add(this.FirewallTutorHelpForm_Title_label);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label FirewallTutorHelpForm_Title_label;
        private System.Windows.Forms.Button Close_HelpFormButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label FirewallTutorHelpForm_Text_label;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}