namespace project
{
    partial class Form8
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
            this.ViewRules_Form_lables = new System.Windows.Forms.Label();
            this.ViewRulesForm_Title_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close_ViewRulesFormButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dataGridView1.Location = new System.Drawing.Point(-3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1185, 855);
            this.dataGridView1.TabIndex = 0;
            // 
            // ViewRules_Form_lables
            // 
            this.ViewRules_Form_lables.AutoSize = true;
            this.ViewRules_Form_lables.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ViewRules_Form_lables.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewRules_Form_lables.Location = new System.Drawing.Point(82, 176);
            this.ViewRules_Form_lables.Name = "ViewRules_Form_lables";
            this.ViewRules_Form_lables.Size = new System.Drawing.Size(59, 25);
            this.ViewRules_Form_lables.TabIndex = 1;
            this.ViewRules_Form_lables.Text = "label1";
            this.ViewRules_Form_lables.Click += new System.EventHandler(this.ViewRules_Form_lables_Click);
            // 
            // ViewRulesForm_Title_label
            // 
            this.ViewRulesForm_Title_label.AutoSize = true;
            this.ViewRulesForm_Title_label.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ViewRulesForm_Title_label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewRulesForm_Title_label.Location = new System.Drawing.Point(508, 33);
            this.ViewRulesForm_Title_label.Name = "ViewRulesForm_Title_label";
            this.ViewRulesForm_Title_label.Size = new System.Drawing.Size(104, 45);
            this.ViewRulesForm_Title_label.TabIndex = 3;
            this.ViewRulesForm_Title_label.Text = "Rules";
            this.ViewRulesForm_Title_label.Click += new System.EventHandler(this.ViewRulesForm_Title_label_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.Close_ViewRulesFormButton);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 33);
            this.panel1.TabIndex = 39;
            // 
            // Close_ViewRulesFormButton
            // 
            this.Close_ViewRulesFormButton.Location = new System.Drawing.Point(3, 0);
            this.Close_ViewRulesFormButton.Name = "Close_ViewRulesFormButton";
            this.Close_ViewRulesFormButton.Size = new System.Drawing.Size(40, 33);
            this.Close_ViewRulesFormButton.TabIndex = 40;
            this.Close_ViewRulesFormButton.Text = "x";
            this.Close_ViewRulesFormButton.UseVisualStyleBackColor = true;
            this.Close_ViewRulesFormButton.Click += new System.EventHandler(this.Close_ViewRulesFormButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 732);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(772, 50);
            this.label1.TabIndex = 42;
            this.label1.Text = "Note: After adding 20 Rules the previous rules will be cleared to make spaces for" +
    " new ones.\r\n   The rules will be reset after application is closed.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 797);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ViewRulesForm_Title_label);
            this.Controls.Add(this.ViewRules_Form_lables);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label ViewRules_Form_lables;
        private System.Windows.Forms.Label ViewRulesForm_Title_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Close_ViewRulesFormButton;
        private System.Windows.Forms.Label label1;
    }
}