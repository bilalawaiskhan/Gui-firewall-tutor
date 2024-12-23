namespace project
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ResetProgressButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SaveSuggestionButton = new System.Windows.Forms.Button();
            this.Close_RulesFormButton2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.dataGridView1.Location = new System.Drawing.Point(-5, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1176, 805);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(396, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "FireWall Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(532, 175);
            this.label2.TabIndex = 4;
            this.label2.Text = "Welcome to FireWall Settings!\r\n\r\nWe hope that you enjoying the experience of the " +
    "FireWall.\r\n\r\nNeed a new Start. Reset your progress.";
            // 
            // ResetProgressButton
            // 
            this.ResetProgressButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ResetProgressButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetProgressButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetProgressButton.Location = new System.Drawing.Point(404, 327);
            this.ResetProgressButton.Name = "ResetProgressButton";
            this.ResetProgressButton.Size = new System.Drawing.Size(187, 47);
            this.ResetProgressButton.TabIndex = 12;
            this.ResetProgressButton.Text = "Reset Progress";
            this.ResetProgressButton.UseVisualStyleBackColor = false;
            this.ResetProgressButton.Click += new System.EventHandler(this.ResetProgressButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(904, 175);
            this.label3.TabIndex = 13;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(425, 537);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(525, 86);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SaveSuggestionButton
            // 
            this.SaveSuggestionButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SaveSuggestionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveSuggestionButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveSuggestionButton.Location = new System.Drawing.Point(591, 644);
            this.SaveSuggestionButton.Name = "SaveSuggestionButton";
            this.SaveSuggestionButton.Size = new System.Drawing.Size(187, 47);
            this.SaveSuggestionButton.TabIndex = 15;
            this.SaveSuggestionButton.Text = "Save Suggestion";
            this.SaveSuggestionButton.UseVisualStyleBackColor = false;
            this.SaveSuggestionButton.Click += new System.EventHandler(this.SaveSuggestionButton_Click);
            // 
            // Close_RulesFormButton2
            // 
            this.Close_RulesFormButton2.Location = new System.Drawing.Point(3, 0);
            this.Close_RulesFormButton2.Name = "Close_RulesFormButton2";
            this.Close_RulesFormButton2.Size = new System.Drawing.Size(40, 33);
            this.Close_RulesFormButton2.TabIndex = 16;
            this.Close_RulesFormButton2.Text = "x";
            this.Close_RulesFormButton2.UseVisualStyleBackColor = true;
            this.Close_RulesFormButton2.Click += new System.EventHandler(this.Close_RulesFormButton2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.Close_RulesFormButton2);
            this.panel1.Location = new System.Drawing.Point(-5, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 33);
            this.panel1.TabIndex = 39;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 797);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SaveSuggestionButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResetProgressButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form7";
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ResetProgressButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SaveSuggestionButton;
        private System.Windows.Forms.Button Close_RulesFormButton2;
        private System.Windows.Forms.Panel panel1;
    }
}