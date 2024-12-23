namespace project
{
    partial class Form2
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
            this.CheckpacketForm_TitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.close1PacketForm_button = new System.Windows.Forms.Button();
            this.checkPacket_button = new System.Windows.Forms.Button();
            this.clearPacket_feildsButton = new System.Windows.Forms.Button();
            this.srcIP_textBox = new System.Windows.Forms.TextBox();
            this.dstIP_textBox = new System.Windows.Forms.TextBox();
            this.srcPort_textBox = new System.Windows.Forms.TextBox();
            this.dstPort_textBox = new System.Windows.Forms.TextBox();
            this.Protocol_textBox = new System.Windows.Forms.TextBox();
            this.Data_textBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close2PacketForm_button = new System.Windows.Forms.Button();
            this.Display_packet_Resultslabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.CheckPacketFormText2_label = new System.Windows.Forms.Label();
            this.CheckPacketFormText_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.dataGridView1.Location = new System.Drawing.Point(-1, -5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1181, 804);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CheckpacketForm_TitleLabel
            // 
            this.CheckpacketForm_TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckpacketForm_TitleLabel.AutoSize = true;
            this.CheckpacketForm_TitleLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CheckpacketForm_TitleLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckpacketForm_TitleLabel.Location = new System.Drawing.Point(471, 37);
            this.CheckpacketForm_TitleLabel.Name = "CheckpacketForm_TitleLabel";
            this.CheckpacketForm_TitleLabel.Size = new System.Drawing.Size(250, 50);
            this.CheckpacketForm_TitleLabel.TabIndex = 17;
            this.CheckpacketForm_TitleLabel.Text = "Check Packet";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 27);
            this.label1.TabIndex = 18;
            this.label1.Text = " Source IpAddress: ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 27);
            this.label2.TabIndex = 23;
            this.label2.Text = "Destination IpAddress: ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 27);
            this.label3.TabIndex = 25;
            this.label3.Text = "Source Port: ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 27);
            this.label4.TabIndex = 26;
            this.label4.Text = "Destination  Port: ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 27);
            this.label5.TabIndex = 29;
            this.label5.Text = "Protocol: ";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 27);
            this.label6.TabIndex = 31;
            this.label6.Text = "Packet Data: ";
            // 
            // close1PacketForm_button
            // 
            this.close1PacketForm_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close1PacketForm_button.Location = new System.Drawing.Point(26, 661);
            this.close1PacketForm_button.Name = "close1PacketForm_button";
            this.close1PacketForm_button.Size = new System.Drawing.Size(152, 50);
            this.close1PacketForm_button.TabIndex = 32;
            this.close1PacketForm_button.Text = "Close";
            this.close1PacketForm_button.UseVisualStyleBackColor = true;
            this.close1PacketForm_button.Click += new System.EventHandler(this.close1PacketForm_button_Click);
            // 
            // checkPacket_button
            // 
            this.checkPacket_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPacket_button.Location = new System.Drawing.Point(512, 661);
            this.checkPacket_button.Name = "checkPacket_button";
            this.checkPacket_button.Size = new System.Drawing.Size(152, 50);
            this.checkPacket_button.TabIndex = 33;
            this.checkPacket_button.Text = "Check Packet";
            this.checkPacket_button.UseVisualStyleBackColor = true;
            this.checkPacket_button.Click += new System.EventHandler(this.checkPacket_button_Click);
            // 
            // clearPacket_feildsButton
            // 
            this.clearPacket_feildsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearPacket_feildsButton.Location = new System.Drawing.Point(1007, 661);
            this.clearPacket_feildsButton.Name = "clearPacket_feildsButton";
            this.clearPacket_feildsButton.Size = new System.Drawing.Size(152, 50);
            this.clearPacket_feildsButton.TabIndex = 34;
            this.clearPacket_feildsButton.Text = "Clear";
            this.clearPacket_feildsButton.UseVisualStyleBackColor = true;
            this.clearPacket_feildsButton.Click += new System.EventHandler(this.clearPacket_feildsButton_Click);
            // 
            // srcIP_textBox
            // 
            this.srcIP_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.srcIP_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.srcIP_textBox.Location = new System.Drawing.Point(420, 129);
            this.srcIP_textBox.Name = "srcIP_textBox";
            this.srcIP_textBox.Size = new System.Drawing.Size(403, 22);
            this.srcIP_textBox.TabIndex = 35;
            // 
            // dstIP_textBox
            // 
            this.dstIP_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.dstIP_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dstIP_textBox.Location = new System.Drawing.Point(420, 180);
            this.dstIP_textBox.Name = "dstIP_textBox";
            this.dstIP_textBox.Size = new System.Drawing.Size(403, 22);
            this.dstIP_textBox.TabIndex = 36;
            // 
            // srcPort_textBox
            // 
            this.srcPort_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.srcPort_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.srcPort_textBox.Location = new System.Drawing.Point(420, 231);
            this.srcPort_textBox.Name = "srcPort_textBox";
            this.srcPort_textBox.Size = new System.Drawing.Size(403, 22);
            this.srcPort_textBox.TabIndex = 37;
            // 
            // dstPort_textBox
            // 
            this.dstPort_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.dstPort_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dstPort_textBox.Location = new System.Drawing.Point(420, 284);
            this.dstPort_textBox.Name = "dstPort_textBox";
            this.dstPort_textBox.Size = new System.Drawing.Size(403, 22);
            this.dstPort_textBox.TabIndex = 38;
            // 
            // Protocol_textBox
            // 
            this.Protocol_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.Protocol_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Protocol_textBox.Location = new System.Drawing.Point(420, 338);
            this.Protocol_textBox.Name = "Protocol_textBox";
            this.Protocol_textBox.Size = new System.Drawing.Size(403, 22);
            this.Protocol_textBox.TabIndex = 39;
            // 
            // Data_textBox
            // 
            this.Data_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.Data_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Data_textBox.Location = new System.Drawing.Point(420, 388);
            this.Data_textBox.Name = "Data_textBox";
            this.Data_textBox.Size = new System.Drawing.Size(403, 22);
            this.Data_textBox.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.close2PacketForm_button);
            this.panel1.Location = new System.Drawing.Point(-1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 33);
            this.panel1.TabIndex = 41;
            // 
            // close2PacketForm_button
            // 
            this.close2PacketForm_button.Location = new System.Drawing.Point(3, 0);
            this.close2PacketForm_button.Name = "close2PacketForm_button";
            this.close2PacketForm_button.Size = new System.Drawing.Size(40, 33);
            this.close2PacketForm_button.TabIndex = 1;
            this.close2PacketForm_button.Text = "x";
            this.close2PacketForm_button.UseVisualStyleBackColor = true;
            this.close2PacketForm_button.Click += new System.EventHandler(this.close2PacketForm_button_Click_1);
            // 
            // Display_packet_Resultslabel
            // 
            this.Display_packet_Resultslabel.AutoSize = true;
            this.Display_packet_Resultslabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Display_packet_Resultslabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display_packet_Resultslabel.Location = new System.Drawing.Point(48, 476);
            this.Display_packet_Resultslabel.Name = "Display_packet_Resultslabel";
            this.Display_packet_Resultslabel.Size = new System.Drawing.Size(13, 20);
            this.Display_packet_Resultslabel.TabIndex = 42;
            this.Display_packet_Resultslabel.Text = " ";
            this.Display_packet_Resultslabel.Visible = false;
            this.Display_packet_Resultslabel.Click += new System.EventHandler(this.Display_packet_Resultslabel_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.IndianRed;
            this.label9.Location = new System.Drawing.Point(300, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 31);
            this.label9.TabIndex = 44;
            this.label9.Text = "*";
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
            this.label10.Location = new System.Drawing.Point(183, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 28);
            this.label10.TabIndex = 45;
            this.label10.Text = "*";
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
            this.label11.Location = new System.Drawing.Point(230, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 28);
            this.label11.TabIndex = 46;
            this.label11.Text = "*";
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
            this.label12.Location = new System.Drawing.Point(137, 315);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 28);
            this.label12.TabIndex = 47;
            this.label12.Text = "*";
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
            this.label13.Location = new System.Drawing.Point(170, 364);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 28);
            this.label13.TabIndex = 48;
            this.label13.Text = "*";
            this.label13.Click += new System.EventHandler(this.label13_Click);
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
            this.label14.Location = new System.Drawing.Point(246, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 28);
            this.label14.TabIndex = 49;
            this.label14.Text = "*";
            // 
            // CheckPacketFormText2_label
            // 
            this.CheckPacketFormText2_label.AutoSize = true;
            this.CheckPacketFormText2_label.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CheckPacketFormText2_label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckPacketFormText2_label.ForeColor = System.Drawing.Color.IndianRed;
            this.CheckPacketFormText2_label.Location = new System.Drawing.Point(46, 527);
            this.CheckPacketFormText2_label.Name = "CheckPacketFormText2_label";
            this.CheckPacketFormText2_label.Size = new System.Drawing.Size(30, 31);
            this.CheckPacketFormText2_label.TabIndex = 50;
            this.CheckPacketFormText2_label.Text = "* ";
            this.CheckPacketFormText2_label.Click += new System.EventHandler(this.label7_Click);
            // 
            // CheckPacketFormText_label
            // 
            this.CheckPacketFormText_label.AutoSize = true;
            this.CheckPacketFormText_label.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CheckPacketFormText_label.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckPacketFormText_label.Location = new System.Drawing.Point(82, 527);
            this.CheckPacketFormText_label.Name = "CheckPacketFormText_label";
            this.CheckPacketFormText_label.Size = new System.Drawing.Size(245, 31);
            this.CheckPacketFormText_label.TabIndex = 51;
            this.CheckPacketFormText_label.Text = "User must fill this field";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(82, 580);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(619, 28);
            this.label7.TabIndex = 52;
            this.label7.Text = "Note: Even if no Rule is found the Packet will be denied by default";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 797);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CheckPacketFormText_label);
            this.Controls.Add(this.CheckPacketFormText2_label);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Display_packet_Resultslabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Data_textBox);
            this.Controls.Add(this.Protocol_textBox);
            this.Controls.Add(this.dstPort_textBox);
            this.Controls.Add(this.srcPort_textBox);
            this.Controls.Add(this.dstIP_textBox);
            this.Controls.Add(this.srcIP_textBox);
            this.Controls.Add(this.clearPacket_feildsButton);
            this.Controls.Add(this.checkPacket_button);
            this.Controls.Add(this.close1PacketForm_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckpacketForm_TitleLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label CheckpacketForm_TitleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button close1PacketForm_button;
        private System.Windows.Forms.Button checkPacket_button;
        private System.Windows.Forms.Button clearPacket_feildsButton;
        private System.Windows.Forms.TextBox srcIP_textBox;
        private System.Windows.Forms.TextBox dstIP_textBox;
        private System.Windows.Forms.TextBox srcPort_textBox;
        private System.Windows.Forms.TextBox dstPort_textBox;
        private System.Windows.Forms.TextBox Protocol_textBox;
        private System.Windows.Forms.TextBox Data_textBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button close2PacketForm_button;
        private System.Windows.Forms.Label Display_packet_Resultslabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label CheckPacketFormText2_label;
        private System.Windows.Forms.Label CheckPacketFormText_label;
        private System.Windows.Forms.Label label7;
    }
}