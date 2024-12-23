namespace project
{
    partial class Form6
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TutorialForm_Title_label = new System.Windows.Forms.Label();
            this.TutorialForm_label = new System.Windows.Forms.Label();
            this.HomeButtonTutorial = new System.Windows.Forms.Button();
            this.HelpButtonTutorial = new System.Windows.Forms.Button();
            this.SettingsButtonTutorial = new System.Windows.Forms.Button();
            this.TutorialForms_label3 = new System.Windows.Forms.Label();
            this.Tutorial_AddRulesButton = new System.Windows.Forms.Button();
            this.Tutorial_AboutButton = new System.Windows.Forms.Button();
            this.Tutorial_ViewRulesButton = new System.Windows.Forms.Button();
            this.Tutorial_CheckPacketsButton = new System.Windows.Forms.Button();
            this.Tutorial_Formlabel_TEXT = new System.Windows.Forms.Label();
            this.Tutorial_Formlabel5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close_TutorialFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1169, 845);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TutorialForm_Title_label
            // 
            this.TutorialForm_Title_label.AutoSize = true;
            this.TutorialForm_Title_label.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TutorialForm_Title_label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TutorialForm_Title_label.Location = new System.Drawing.Point(368, 44);
            this.TutorialForm_Title_label.Name = "TutorialForm_Title_label";
            this.TutorialForm_Title_label.Size = new System.Drawing.Size(273, 45);
            this.TutorialForm_Title_label.TabIndex = 2;
            this.TutorialForm_Title_label.Text = "FireWall Tutorial";
            // 
            // TutorialForm_label
            // 
            this.TutorialForm_label.AutoSize = true;
            this.TutorialForm_label.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TutorialForm_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TutorialForm_label.Location = new System.Drawing.Point(36, 116);
            this.TutorialForm_label.Name = "TutorialForm_label";
            this.TutorialForm_label.Size = new System.Drawing.Size(565, 35);
            this.TutorialForm_label.TabIndex = 3;
            this.TutorialForm_label.Text = "Please select a button below to see its tutorial:\r\n";
            // 
            // HomeButtonTutorial
            // 
            this.HomeButtonTutorial.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.HomeButtonTutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButtonTutorial.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButtonTutorial.Location = new System.Drawing.Point(42, 184);
            this.HomeButtonTutorial.Name = "HomeButtonTutorial";
            this.HomeButtonTutorial.Size = new System.Drawing.Size(120, 47);
            this.HomeButtonTutorial.TabIndex = 5;
            this.HomeButtonTutorial.Text = "Home";
            this.HomeButtonTutorial.UseVisualStyleBackColor = false;
            this.HomeButtonTutorial.Click += new System.EventHandler(this.HomeButtonTutorial_Click);
            // 
            // HelpButtonTutorial
            // 
            this.HelpButtonTutorial.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.HelpButtonTutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpButtonTutorial.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButtonTutorial.Location = new System.Drawing.Point(469, 184);
            this.HelpButtonTutorial.Name = "HelpButtonTutorial";
            this.HelpButtonTutorial.Size = new System.Drawing.Size(120, 47);
            this.HelpButtonTutorial.TabIndex = 6;
            this.HelpButtonTutorial.Text = "Help";
            this.HelpButtonTutorial.UseVisualStyleBackColor = false;
            this.HelpButtonTutorial.Click += new System.EventHandler(this.HelpButtonTutorial_Click);
            // 
            // SettingsButtonTutorial
            // 
            this.SettingsButtonTutorial.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SettingsButtonTutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButtonTutorial.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButtonTutorial.Location = new System.Drawing.Point(903, 184);
            this.SettingsButtonTutorial.Name = "SettingsButtonTutorial";
            this.SettingsButtonTutorial.Size = new System.Drawing.Size(120, 47);
            this.SettingsButtonTutorial.TabIndex = 8;
            this.SettingsButtonTutorial.Text = "Settings";
            this.SettingsButtonTutorial.UseVisualStyleBackColor = false;
            this.SettingsButtonTutorial.Click += new System.EventHandler(this.SettingsButtonTutorial_Click);
            // 
            // TutorialForms_label3
            // 
            this.TutorialForms_label3.AutoSize = true;
            this.TutorialForms_label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TutorialForms_label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TutorialForms_label3.Location = new System.Drawing.Point(37, 299);
            this.TutorialForms_label3.Name = "TutorialForms_label3";
            this.TutorialForms_label3.Size = new System.Drawing.Size(66, 28);
            this.TutorialForms_label3.TabIndex = 9;
            this.TutorialForms_label3.Text = "label3";
            this.TutorialForms_label3.Visible = false;
            // 
            // Tutorial_AddRulesButton
            // 
            this.Tutorial_AddRulesButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Tutorial_AddRulesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tutorial_AddRulesButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tutorial_AddRulesButton.Location = new System.Drawing.Point(42, 360);
            this.Tutorial_AddRulesButton.Name = "Tutorial_AddRulesButton";
            this.Tutorial_AddRulesButton.Size = new System.Drawing.Size(151, 47);
            this.Tutorial_AddRulesButton.TabIndex = 10;
            this.Tutorial_AddRulesButton.Text = "Add Rules";
            this.Tutorial_AddRulesButton.UseVisualStyleBackColor = false;
            this.Tutorial_AddRulesButton.Visible = false;
            this.Tutorial_AddRulesButton.Click += new System.EventHandler(this.Tutorial_AddRulesButton_Click);
            // 
            // Tutorial_AboutButton
            // 
            this.Tutorial_AboutButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Tutorial_AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tutorial_AboutButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tutorial_AboutButton.Location = new System.Drawing.Point(42, 604);
            this.Tutorial_AboutButton.Name = "Tutorial_AboutButton";
            this.Tutorial_AboutButton.Size = new System.Drawing.Size(151, 47);
            this.Tutorial_AboutButton.TabIndex = 11;
            this.Tutorial_AboutButton.Text = "View Results";
            this.Tutorial_AboutButton.UseVisualStyleBackColor = false;
            this.Tutorial_AboutButton.Visible = false;
            this.Tutorial_AboutButton.Click += new System.EventHandler(this.Tutorial_AboutButton_Click);
            // 
            // Tutorial_ViewRulesButton
            // 
            this.Tutorial_ViewRulesButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Tutorial_ViewRulesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tutorial_ViewRulesButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tutorial_ViewRulesButton.Location = new System.Drawing.Point(42, 525);
            this.Tutorial_ViewRulesButton.Name = "Tutorial_ViewRulesButton";
            this.Tutorial_ViewRulesButton.Size = new System.Drawing.Size(151, 47);
            this.Tutorial_ViewRulesButton.TabIndex = 12;
            this.Tutorial_ViewRulesButton.Text = "View Rules";
            this.Tutorial_ViewRulesButton.UseVisualStyleBackColor = false;
            this.Tutorial_ViewRulesButton.Visible = false;
            this.Tutorial_ViewRulesButton.Click += new System.EventHandler(this.Tutorial_ViewRulesButton_Click);
            // 
            // Tutorial_CheckPacketsButton
            // 
            this.Tutorial_CheckPacketsButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Tutorial_CheckPacketsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tutorial_CheckPacketsButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tutorial_CheckPacketsButton.Location = new System.Drawing.Point(42, 444);
            this.Tutorial_CheckPacketsButton.Name = "Tutorial_CheckPacketsButton";
            this.Tutorial_CheckPacketsButton.Size = new System.Drawing.Size(151, 47);
            this.Tutorial_CheckPacketsButton.TabIndex = 13;
            this.Tutorial_CheckPacketsButton.Text = "Check Packet";
            this.Tutorial_CheckPacketsButton.UseVisualStyleBackColor = false;
            this.Tutorial_CheckPacketsButton.Visible = false;
            this.Tutorial_CheckPacketsButton.Click += new System.EventHandler(this.Tutorial_CheckPacketsButton_Click);
            // 
            // Tutorial_Formlabel_TEXT
            // 
            this.Tutorial_Formlabel_TEXT.AutoSize = true;
            this.Tutorial_Formlabel_TEXT.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Tutorial_Formlabel_TEXT.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tutorial_Formlabel_TEXT.Location = new System.Drawing.Point(36, 264);
            this.Tutorial_Formlabel_TEXT.Name = "Tutorial_Formlabel_TEXT";
            this.Tutorial_Formlabel_TEXT.Size = new System.Drawing.Size(572, 35);
            this.Tutorial_Formlabel_TEXT.TabIndex = 14;
            this.Tutorial_Formlabel_TEXT.Text = "This button opens subMenu. Select the button:\r\n";
            this.Tutorial_Formlabel_TEXT.Visible = false;
            this.Tutorial_Formlabel_TEXT.Click += new System.EventHandler(this.label4_Click);
            // 
            // Tutorial_Formlabel5
            // 
            this.Tutorial_Formlabel5.AutoSize = true;
            this.Tutorial_Formlabel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Tutorial_Formlabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tutorial_Formlabel5.Location = new System.Drawing.Point(220, 324);
            this.Tutorial_Formlabel5.Name = "Tutorial_Formlabel5";
            this.Tutorial_Formlabel5.Size = new System.Drawing.Size(55, 23);
            this.Tutorial_Formlabel5.TabIndex = 15;
            this.Tutorial_Formlabel5.Text = "label5";
            this.Tutorial_Formlabel5.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.Close_TutorialFormButton);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 33);
            this.panel1.TabIndex = 38;
            // 
            // Close_TutorialFormButton
            // 
            this.Close_TutorialFormButton.Location = new System.Drawing.Point(0, 0);
            this.Close_TutorialFormButton.Name = "Close_TutorialFormButton";
            this.Close_TutorialFormButton.Size = new System.Drawing.Size(40, 33);
            this.Close_TutorialFormButton.TabIndex = 4;
            this.Close_TutorialFormButton.Text = "x";
            this.Close_TutorialFormButton.UseVisualStyleBackColor = true;
            this.Close_TutorialFormButton.Click += new System.EventHandler(this.CloseTutorialForm_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 793);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Tutorial_Formlabel5);
            this.Controls.Add(this.Tutorial_Formlabel_TEXT);
            this.Controls.Add(this.Tutorial_CheckPacketsButton);
            this.Controls.Add(this.Tutorial_ViewRulesButton);
            this.Controls.Add(this.Tutorial_AboutButton);
            this.Controls.Add(this.Tutorial_AddRulesButton);
            this.Controls.Add(this.TutorialForms_label3);
            this.Controls.Add(this.SettingsButtonTutorial);
            this.Controls.Add(this.HelpButtonTutorial);
            this.Controls.Add(this.HomeButtonTutorial);
            this.Controls.Add(this.TutorialForm_label);
            this.Controls.Add(this.TutorialForm_Title_label);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form6";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label TutorialForm_Title_label;
        private System.Windows.Forms.Label TutorialForm_label;
        private System.Windows.Forms.Button HomeButtonTutorial;
        private System.Windows.Forms.Button HelpButtonTutorial;
        private System.Windows.Forms.Button SettingsButtonTutorial;
        private System.Windows.Forms.Label TutorialForms_label3;
        private System.Windows.Forms.Button Tutorial_AddRulesButton;
        private System.Windows.Forms.Button Tutorial_AboutButton;
        private System.Windows.Forms.Button Tutorial_ViewRulesButton;
        private System.Windows.Forms.Button Tutorial_CheckPacketsButton;
        private System.Windows.Forms.Label Tutorial_Formlabel_TEXT;
        private System.Windows.Forms.Label Tutorial_Formlabel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Close_TutorialFormButton;
    }
}