namespace project
{
    partial class Form3
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
            this.Close_RulesFormButton1 = new System.Windows.Forms.Button();
            this.ClearRuleFieldsButton = new System.Windows.Forms.Button();
            this.RulesFormTitle_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dst_IptextBox = new System.Windows.Forms.TextBox();
            this.src_PorttextBox = new System.Windows.Forms.TextBox();
            this.dst_PorttextBox = new System.Windows.Forms.TextBox();
            this.protocol_Textbox = new System.Windows.Forms.TextBox();
            this.dataTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ActioncomboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close_RulesFormButton2 = new System.Windows.Forms.Button();
            this.src_IPtextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.RulesForm_texts_label = new System.Windows.Forms.Label();
            this.RulesForm_text_label = new System.Windows.Forms.Label();
            this.Save_Rules_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RuleTypecomboBox = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Close_RulesFormButton1
            // 
            this.Close_RulesFormButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_RulesFormButton1.Location = new System.Drawing.Point(43, 735);
            this.Close_RulesFormButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Close_RulesFormButton1.Name = "Close_RulesFormButton1";
            this.Close_RulesFormButton1.Size = new System.Drawing.Size(111, 50);
            this.Close_RulesFormButton1.TabIndex = 1;
            this.Close_RulesFormButton1.Text = "Close";
            this.Close_RulesFormButton1.UseVisualStyleBackColor = true;
            this.Close_RulesFormButton1.Click += new System.EventHandler(this.Close_RulesFormButton1_Click);
            // 
            // ClearRuleFieldsButton
            // 
            this.ClearRuleFieldsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearRuleFieldsButton.Location = new System.Drawing.Point(1025, 720);
            this.ClearRuleFieldsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClearRuleFieldsButton.Name = "ClearRuleFieldsButton";
            this.ClearRuleFieldsButton.Size = new System.Drawing.Size(111, 50);
            this.ClearRuleFieldsButton.TabIndex = 3;
            this.ClearRuleFieldsButton.Text = "Clear";
            this.ClearRuleFieldsButton.UseVisualStyleBackColor = true;
            this.ClearRuleFieldsButton.Click += new System.EventHandler(this.ClearRuleFieldsButton_Click);
            // 
            // RulesFormTitle_label
            // 
            this.RulesFormTitle_label.AutoSize = true;
            this.RulesFormTitle_label.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.RulesFormTitle_label.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RulesFormTitle_label.Location = new System.Drawing.Point(365, 30);
            this.RulesFormTitle_label.Name = "RulesFormTitle_label";
            this.RulesFormTitle_label.Size = new System.Drawing.Size(369, 50);
            this.RulesFormTitle_label.TabIndex = 5;
            this.RulesFormTitle_label.Text = "Enter FireWall Rules";
            this.RulesFormTitle_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(453, 27);
            this.label2.TabIndex = 21;
            this.label2.Text = "Enter Source IpAddress(Single/Range): \r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(504, 27);
            this.label3.TabIndex = 22;
            this.label3.Text = "Enter Destination IpAddress(Single/Range): ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 27);
            this.label4.TabIndex = 23;
            this.label4.Text = "Enter Source Port: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 27);
            this.label5.TabIndex = 24;
            this.label5.Text = "Enter Destination Port: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 27);
            this.label6.TabIndex = 25;
            this.label6.Text = "Enter Protocol: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 498);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 27);
            this.label7.TabIndex = 26;
            this.label7.Text = "Enter Data: ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dst_IptextBox
            // 
            this.dst_IptextBox.BackColor = System.Drawing.SystemColors.Control;
            this.dst_IptextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dst_IptextBox.Location = new System.Drawing.Point(573, 254);
            this.dst_IptextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dst_IptextBox.Name = "dst_IptextBox";
            this.dst_IptextBox.Size = new System.Drawing.Size(403, 22);
            this.dst_IptextBox.TabIndex = 29;
            this.dst_IptextBox.Visible = false;
            this.dst_IptextBox.WordWrap = false;
            // 
            // src_PorttextBox
            // 
            this.src_PorttextBox.BackColor = System.Drawing.SystemColors.Control;
            this.src_PorttextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.src_PorttextBox.Location = new System.Drawing.Point(573, 314);
            this.src_PorttextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.src_PorttextBox.Name = "src_PorttextBox";
            this.src_PorttextBox.Size = new System.Drawing.Size(403, 22);
            this.src_PorttextBox.TabIndex = 30;
            this.src_PorttextBox.Visible = false;
            this.src_PorttextBox.WordWrap = false;
            // 
            // dst_PorttextBox
            // 
            this.dst_PorttextBox.BackColor = System.Drawing.SystemColors.Control;
            this.dst_PorttextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dst_PorttextBox.Location = new System.Drawing.Point(573, 374);
            this.dst_PorttextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dst_PorttextBox.Name = "dst_PorttextBox";
            this.dst_PorttextBox.Size = new System.Drawing.Size(403, 22);
            this.dst_PorttextBox.TabIndex = 31;
            this.dst_PorttextBox.Visible = false;
            this.dst_PorttextBox.WordWrap = false;
            this.dst_PorttextBox.TextChanged += new System.EventHandler(this.dst_PorttextBox_TextChanged);
            // 
            // protocol_Textbox
            // 
            this.protocol_Textbox.BackColor = System.Drawing.SystemColors.Control;
            this.protocol_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.protocol_Textbox.Location = new System.Drawing.Point(573, 437);
            this.protocol_Textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.protocol_Textbox.Name = "protocol_Textbox";
            this.protocol_Textbox.Size = new System.Drawing.Size(403, 22);
            this.protocol_Textbox.TabIndex = 32;
            this.protocol_Textbox.Visible = false;
            this.protocol_Textbox.WordWrap = false;
            this.protocol_Textbox.TextChanged += new System.EventHandler(this.protocol_Textbox_TextChanged);
            // 
            // dataTextbox
            // 
            this.dataTextbox.BackColor = System.Drawing.SystemColors.Control;
            this.dataTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataTextbox.Location = new System.Drawing.Point(573, 498);
            this.dataTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataTextbox.Name = "dataTextbox";
            this.dataTextbox.Size = new System.Drawing.Size(403, 22);
            this.dataTextbox.TabIndex = 33;
            this.dataTextbox.Visible = false;
            this.dataTextbox.TextChanged += new System.EventHandler(this.dataTextbox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 556);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 27);
            this.label8.TabIndex = 34;
            this.label8.Text = "Action: ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // ActioncomboBox
            // 
            this.ActioncomboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.ActioncomboBox.BackColor = System.Drawing.SystemColors.Control;
            this.ActioncomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ActioncomboBox.FormattingEnabled = true;
            this.ActioncomboBox.Items.AddRange(new object[] {
            "Allow",
            "Deny"});
            this.ActioncomboBox.Location = new System.Drawing.Point(573, 556);
            this.ActioncomboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActioncomboBox.Name = "ActioncomboBox";
            this.ActioncomboBox.Size = new System.Drawing.Size(403, 24);
            this.ActioncomboBox.TabIndex = 35;
            this.ActioncomboBox.SelectedIndexChanged += new System.EventHandler(this.ActioncomboBox_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-3, -2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1175, 806);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.Close_RulesFormButton2);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 33);
            this.panel1.TabIndex = 36;
            // 
            // Close_RulesFormButton2
            // 
            this.Close_RulesFormButton2.Location = new System.Drawing.Point(3, 2);
            this.Close_RulesFormButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Close_RulesFormButton2.Name = "Close_RulesFormButton2";
            this.Close_RulesFormButton2.Size = new System.Drawing.Size(40, 33);
            this.Close_RulesFormButton2.TabIndex = 0;
            this.Close_RulesFormButton2.Text = "x";
            this.Close_RulesFormButton2.UseVisualStyleBackColor = true;
            this.Close_RulesFormButton2.Click += new System.EventHandler(this.Close_RulesFormButton2_Click_1);
            // 
            // src_IPtextBox
            // 
            this.src_IPtextBox.BackColor = System.Drawing.SystemColors.Control;
            this.src_IPtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.src_IPtextBox.Location = new System.Drawing.Point(573, 196);
            this.src_IPtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.src_IPtextBox.Name = "src_IPtextBox";
            this.src_IPtextBox.Size = new System.Drawing.Size(403, 22);
            this.src_IPtextBox.TabIndex = 28;
            this.src_IPtextBox.Visible = false;
            this.src_IPtextBox.WordWrap = false;
            this.src_IPtextBox.TextChanged += new System.EventHandler(this.src_IPtextBox_TextChanged);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.IndianRed;
            this.label14.Location = new System.Drawing.Point(444, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 28);
            this.label14.TabIndex = 50;
            this.label14.Text = "*";
            this.label14.Visible = false;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.IndianRed;
            this.label10.Location = new System.Drawing.Point(495, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 28);
            this.label10.TabIndex = 51;
            this.label10.Text = "*";
            this.label10.Visible = false;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.IndianRed;
            this.label11.Location = new System.Drawing.Point(229, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 28);
            this.label11.TabIndex = 52;
            this.label11.Text = "*";
            this.label11.Visible = false;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.IndianRed;
            this.label12.Location = new System.Drawing.Point(285, 341);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 28);
            this.label12.TabIndex = 53;
            this.label12.Text = "*";
            this.label12.Visible = false;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.IndianRed;
            this.label13.Location = new System.Drawing.Point(191, 404);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 28);
            this.label13.TabIndex = 54;
            this.label13.Text = "*";
            this.label13.Visible = false;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.IndianRed;
            this.label15.Location = new System.Drawing.Point(145, 470);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 28);
            this.label15.TabIndex = 55;
            this.label15.Text = "*";
            this.label15.Visible = false;
            // 
            // RulesForm_texts_label
            // 
            this.RulesForm_texts_label.AutoSize = true;
            this.RulesForm_texts_label.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.RulesForm_texts_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RulesForm_texts_label.Location = new System.Drawing.Point(88, 625);
            this.RulesForm_texts_label.Name = "RulesForm_texts_label";
            this.RulesForm_texts_label.Size = new System.Drawing.Size(218, 28);
            this.RulesForm_texts_label.TabIndex = 57;
            this.RulesForm_texts_label.Text = "User must fill this field";
            // 
            // RulesForm_text_label
            // 
            this.RulesForm_text_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RulesForm_text_label.AutoSize = true;
            this.RulesForm_text_label.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.RulesForm_text_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RulesForm_text_label.ForeColor = System.Drawing.Color.IndianRed;
            this.RulesForm_text_label.Location = new System.Drawing.Point(51, 625);
            this.RulesForm_text_label.Name = "RulesForm_text_label";
            this.RulesForm_text_label.Size = new System.Drawing.Size(21, 28);
            this.RulesForm_text_label.TabIndex = 58;
            this.RulesForm_text_label.Text = "*";
            // 
            // Save_Rules_Button
            // 
            this.Save_Rules_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Rules_Button.Location = new System.Drawing.Point(549, 735);
            this.Save_Rules_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Save_Rules_Button.Name = "Save_Rules_Button";
            this.Save_Rules_Button.Size = new System.Drawing.Size(111, 50);
            this.Save_Rules_Button.TabIndex = 64;
            this.Save_Rules_Button.Text = "Save";
            this.Save_Rules_Button.UseVisualStyleBackColor = true;
            this.Save_Rules_Button.Click += new System.EventHandler(this.Save_Rules_Button_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 26);
            this.label1.TabIndex = 65;
            this.label1.Text = "Enter Rule Type: ";
            // 
            // RuleTypecomboBox
            // 
            this.RuleTypecomboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.RuleTypecomboBox.BackColor = System.Drawing.SystemColors.Control;
            this.RuleTypecomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RuleTypecomboBox.FormattingEnabled = true;
            this.RuleTypecomboBox.Items.AddRange(new object[] {
            "SourceIP",
            "DestinationIP",
            "SourcePort",
            "DestinationPort",
            "Protocol",
            "Data"});
            this.RuleTypecomboBox.Location = new System.Drawing.Point(573, 138);
            this.RuleTypecomboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RuleTypecomboBox.Name = "RuleTypecomboBox";
            this.RuleTypecomboBox.Size = new System.Drawing.Size(403, 24);
            this.RuleTypecomboBox.TabIndex = 66;
            this.RuleTypecomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.IndianRed;
            this.label16.Location = new System.Drawing.Point(191, 105);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 28);
            this.label16.TabIndex = 67;
            this.label16.Text = "*";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.IndianRed;
            this.label17.Location = new System.Drawing.Point(101, 538);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 28);
            this.label17.TabIndex = 68;
            this.label17.Text = "*";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(88, 672);
            this.label18.Name = "label18";
            this.label18.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label18.Size = new System.Drawing.Size(429, 28);
            this.label18.TabIndex = 69;
            this.label18.Text = " Note:IP range format: 192.168.0.1-192.168.0.10\r\n";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 798);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.RuleTypecomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save_Rules_Button);
            this.Controls.Add(this.RulesForm_text_label);
            this.Controls.Add(this.RulesForm_texts_label);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ActioncomboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataTextbox);
            this.Controls.Add(this.protocol_Textbox);
            this.Controls.Add(this.dst_PorttextBox);
            this.Controls.Add(this.src_PorttextBox);
            this.Controls.Add(this.dst_IptextBox);
            this.Controls.Add(this.src_IPtextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RulesFormTitle_label);
            this.Controls.Add(this.ClearRuleFieldsButton);
            this.Controls.Add(this.Close_RulesFormButton1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Close_RulesFormButton1;
        private System.Windows.Forms.Button ClearRuleFieldsButton;
        private System.Windows.Forms.Label RulesFormTitle_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dst_IptextBox;
        private System.Windows.Forms.TextBox src_PorttextBox;
        private System.Windows.Forms.TextBox dst_PorttextBox;
        private System.Windows.Forms.TextBox protocol_Textbox;
        private System.Windows.Forms.TextBox dataTextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ActioncomboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Close_RulesFormButton2;
        private System.Windows.Forms.TextBox src_IPtextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label RulesForm_texts_label;
        private System.Windows.Forms.Label RulesForm_text_label;
        private System.Windows.Forms.Button Save_Rules_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RuleTypecomboBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}