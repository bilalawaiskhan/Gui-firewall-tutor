namespace project
{
    partial class Form4
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
            this.FirewallTutorViewResultForm_Title_label_Click = new System.Windows.Forms.Label();
            this.ViewResult_Form_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close_ViewResultsFormButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewResults_Form_lables2 = new System.Windows.Forms.Label();
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
            this.dataGridView1.Location = new System.Drawing.Point(-7, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1190, 863);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FirewallTutorViewResultForm_Title_label_Click
            // 
            this.FirewallTutorViewResultForm_Title_label_Click.AutoSize = true;
            this.FirewallTutorViewResultForm_Title_label_Click.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.FirewallTutorViewResultForm_Title_label_Click.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirewallTutorViewResultForm_Title_label_Click.Location = new System.Drawing.Point(475, 31);
            this.FirewallTutorViewResultForm_Title_label_Click.Name = "FirewallTutorViewResultForm_Title_label_Click";
            this.FirewallTutorViewResultForm_Title_label_Click.Size = new System.Drawing.Size(131, 45);
            this.FirewallTutorViewResultForm_Title_label_Click.TabIndex = 2;
            this.FirewallTutorViewResultForm_Title_label_Click.Text = "Results";
            this.FirewallTutorViewResultForm_Title_label_Click.Click += new System.EventHandler(this.FirewallTutorViewResultsForm_Title_label_Click);
            // 
            // ViewResult_Form_label
            // 
            this.ViewResult_Form_label.AutoSize = true;
            this.ViewResult_Form_label.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ViewResult_Form_label.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewResult_Form_label.Location = new System.Drawing.Point(26, 145);
            this.ViewResult_Form_label.Name = "ViewResult_Form_label";
            this.ViewResult_Form_label.Size = new System.Drawing.Size(50, 20);
            this.ViewResult_Form_label.TabIndex = 3;
            this.ViewResult_Form_label.Text = "label2";
            this.ViewResult_Form_label.Visible = false;
            this.ViewResult_Form_label.Click += new System.EventHandler(this.ViewResult_Form_label_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.Close_ViewResultsFormButton);
            this.panel1.Location = new System.Drawing.Point(2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 33);
            this.panel1.TabIndex = 40;
            // 
            // Close_ViewResultsFormButton
            // 
            this.Close_ViewResultsFormButton.Location = new System.Drawing.Point(0, 3);
            this.Close_ViewResultsFormButton.Name = "Close_ViewResultsFormButton";
            this.Close_ViewResultsFormButton.Size = new System.Drawing.Size(40, 33);
            this.Close_ViewResultsFormButton.TabIndex = 41;
            this.Close_ViewResultsFormButton.Text = "x";
            this.Close_ViewResultsFormButton.UseVisualStyleBackColor = true;
            this.Close_ViewResultsFormButton.Click += new System.EventHandler(this.Close_ViewResultsFormButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 728);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(802, 50);
            this.label1.TabIndex = 41;
            this.label1.Text = "Note: After 10 Packets Results the previous results will be cleared to make space" +
    "s for new ones.\r\n  The results will be rest after the application is closed.\r\n";
            // 
            // ViewResults_Form_lables2
            // 
            this.ViewResults_Form_lables2.AutoSize = true;
            this.ViewResults_Form_lables2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ViewResults_Form_lables2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewResults_Form_lables2.Location = new System.Drawing.Point(82, 110);
            this.ViewResults_Form_lables2.Name = "ViewResults_Form_lables2";
            this.ViewResults_Form_lables2.Size = new System.Drawing.Size(59, 25);
            this.ViewResults_Form_lables2.TabIndex = 42;
            this.ViewResults_Form_lables2.Text = "label1";
            this.ViewResults_Form_lables2.Visible = false;
            this.ViewResults_Form_lables2.Click += new System.EventHandler(this.ViewResulgs_Form_lables2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 797);
            this.Controls.Add(this.ViewResults_Form_lables2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ViewResult_Form_label);
            this.Controls.Add(this.FirewallTutorViewResultForm_Title_label_Click);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label FirewallTutorViewResultForm_Title_label_Click;
        private System.Windows.Forms.Label ViewResult_Form_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Close_ViewResultsFormButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ViewResults_Form_lables2;
    }
}