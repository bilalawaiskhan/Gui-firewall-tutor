using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form3 : Form
    {


        // Adds a new rule to the rules file on the user's desktop
        private bool AddRule(Rule rule)
        {
            // Get the path to the user's desktop
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Combine the desktop path with the rules file name to get the full file path
            string filePath = Path.Combine(desktopPath, "rules.txt");

            try
            {
                // Increment the rule count
                Rule.Rulecount++;

                // Open the rules file in append mode
                using (StreamWriter writer = File.AppendText(filePath))
                {
                    // Determine the type of rule being added
                    switch (rule.RuleType)
                    //Based on the enum ruleType we get the ruleType from ruleType combobox and write particular rule in the file
                    // with the rule number
                    {
                        case RuleType.SourceIP:
                            writer.WriteLine(Rule.Rulecount + " SRCIP: " + rule.SourceIP + " " + rule.Action);
                            break;
                        case RuleType.DestinationIP:
                            writer.WriteLine(Rule.Rulecount + " DSTIP: " + rule.DestinationIP + " " + rule.Action);
                            break;
                        case RuleType.SourcePort:
                            writer.WriteLine(Rule.Rulecount + " SRCPORT: " + rule.SourcePort + " " + rule.Action);
                            break;
                        case RuleType.DestinationPort:
                            writer.WriteLine(Rule.Rulecount + " DSTPORT: " + rule.DestinationPort + " " + rule.Action);
                            break;
                        case RuleType.Protocol:
                            writer.WriteLine(Rule.Rulecount + " PRO: " + rule.Protocol + " " + rule.Action);
                            break;
                        case RuleType.Data:
                            writer.WriteLine(Rule.Rulecount + " DATA: " + rule.Data + " " + rule.Action);
                            break;
                        default:
                            // Decrement the rule count and display an error message if the rule type is invalid
                            //This is done to make sure rule count is proper if there is error saving rule
                            Rule.Rulecount--;
                            MessageBox.Show("Invalid rule type");
                            return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                // Display an error message if there was a problem saving the rule
                MessageBox.Show($"Error saving rule: {ex.Message}");
                return false;
            }
        }
        public Form3()
        {
            InitializeComponent();

        }

        // Validates that a given IP address string is in the correct format
        private bool checkRulesIp(string ip)
        {
            // Split the IP address string into its four parts
            string[] parts = ip.Split('.');

            // Check that there are exactly four parts
            if (parts.Length != 4)
            {
                return false;
            }

            // Check that each part is a valid integer between 0 and 255
            foreach (string part in parts)
            {
                if (!int.TryParse(part, out int value) || value < 0 || value > 255)
                {
                    return false;
                }
            }

            // If all checks pass, return true to indicate correct IP format
            return true;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            //Closing button of form. Uses closes method to close the form
            this.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {



        }

        private void Close_RulesFormButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void ClearRuleFieldsButton_Click(object sender, EventArgs e)
        {
            //This button is used to clear the fields if user wants to clear the fields. After saving rule fields will be cleared 
            //automatically
            src_IPtextBox.Clear();
            dst_IptextBox.Clear();
            src_PorttextBox.Clear();
            dst_PorttextBox.Clear();
            protocol_Textbox.Clear();
            dataTextbox.Clear();
            ActioncomboBox.Text = "";
            RuleTypecomboBox.Text = "";

        }

        private void src_IPtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rulename_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ActioncomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Close_RulesFormButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }







        private void Save_Rules_Button_Click_1(object sender, EventArgs e)
        {
            //First check if user selects any ruleTYpe or not
            if (RuleTypecomboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a rule type.");
                return;
            }
            //Validate that any of these fields arent empty and action and ruletype combo box must not be empty along with
            //particular ruleType field
            if (src_IPtextBox.Text != "" || dst_IptextBox.Text != "" || src_PorttextBox.Text != ""
               ||dst_PorttextBox.Text!=""|| protocol_Textbox.Text != "" || dataTextbox.Text != "" &&ActioncomboBox.Text!="")
            {
                // Get the input values from the UI
                string sourceIpAddress = src_IPtextBox.Text;
                string destinationIpAddress = dst_IptextBox.Text;
                bool isSourceIPValid = checkRulesIp(sourceIpAddress);
                bool isDestinationIPValid = checkRulesIp(destinationIpAddress);
                //check is ruleType  is Source or destination IP to validate user for correct input
                if (RuleTypecomboBox.Text == "SourceIP"|| RuleTypecomboBox.Text == "DestinationIP")
                {
                    if(!isSourceIPValid && !isDestinationIPValid)
                    {
                        MessageBox.Show("Invalid IP address format. The format should be a.b.c.d.");
                        return;
                    }
                }
                int sourcePort = 0;
                int destinationPort = 0;

                //Validate usser for correct input in numbers instead of string and check if it can be parsed to int
                if (src_PorttextBox.Text != "")
                {
                    if (!int.TryParse(src_PorttextBox.Text, out sourcePort))
                    {
                        MessageBox.Show("Invalid source port number");
                        return;
                    }
                }

                if (dst_PorttextBox.Text != "")
                {
                    if (!int.TryParse(dst_PorttextBox.Text, out destinationPort))
                    {
                        MessageBox.Show("Invalid destination port number");
                        return;
                    }
                }

                //Check if selected ruleTye is Source Port to validate user for correct input
                if (RuleTypecomboBox.Text == "SourcePort")
                {
                    if (sourcePort < 0 || sourcePort > 65535)
                    {
                        MessageBox.Show("Invalid source port number. The valid range is 0 to 65535.");
                        return;
                    }

                }
                //Check if selected ruleTye is Destination to validate user for correct input
                if (RuleTypecomboBox.Text == "DestinationPort")
                {
                    if (destinationPort < 0 || destinationPort > 65535)
                    {
                        MessageBox.Show("Invalid Destination port number. The valid range is 0 to 65535.");
                        return;
                    }

                }
                string protocol = protocol_Textbox.Text;
                string data = dataTextbox.Text;
                string action = ActioncomboBox.Text;

                //Action field is a must to be filled
                if (ActioncomboBox.Text == "")
                {
                    MessageBox.Show("Please select an action for the rule.");
                    return;
                }

                // Get the selected rule type
                string ruleTypeString = RuleTypecomboBox.SelectedItem.ToString();


                // Parses the selected rule type from the RuleTypecomboBox as a RuleType enum value
                // check if enum contains a value which matches the ruleType value converted to string
                RuleType ruleType = (RuleType)Enum.Parse(typeof(RuleType), RuleTypecomboBox.SelectedItem.ToString());


                //if no match is found
                if (!Enum.TryParse(ruleTypeString, true, out ruleType))
                {
                    MessageBox.Show("Invalid rule type");
                    return;
                }
                else
                {

                    //if a match is found create a new rule
                    Rule rule = new Rule(sourceIpAddress, destinationIpAddress, sourcePort, destinationPort, protocol, data, action, ruleType);
                    
                    //check to see if Rule is added to the file
                    if (AddRule(rule))
                    {
                        
                        MessageBox.Show("Rule Added Successfully");

                        // Clear the input fields

                        src_IPtextBox.Clear();
                        dst_IptextBox.Clear();
                        src_PorttextBox.Clear();
                        dst_PorttextBox.Clear();
                        protocol_Textbox.Clear();
                        dataTextbox.Clear();
                        ActioncomboBox.Text = "";
                        RuleTypecomboBox.Text = "";

                        dst_IptextBox.Visible = false;
                        src_PorttextBox.Visible = false;
                        dst_PorttextBox.Visible = false;
                        protocol_Textbox.Visible = false;
                        dataTextbox.Visible = false;
                        src_IPtextBox.Visible = false;
                        label10.Visible = false;
                        label11.Visible = false;
                        label12.Visible = false;
                        label13.Visible = false;
                        label14.Visible = false;
                        label15.Visible = false;

                    }
                
                }
            }
            //make sure user enters all the fields
            else
            {
                MessageBox.Show("Required Fields must be filled");
            }
        }

        private void dst_PorttextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Checks the ruleType and then according to that make particular field or labels visible
            if (RuleTypecomboBox.Text == "SourceIP")
            {
                
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label15.Visible = false;
                dst_IptextBox.Visible = false;
                src_PorttextBox.Visible = false;
                dst_PorttextBox.Visible = false;
                protocol_Textbox.Visible = false;
                dataTextbox.Visible = false;
                src_IPtextBox.Visible = true;
                label14.Visible = true;
            }

            else if (RuleTypecomboBox.Text == "DestinationIP")
            {
                label14.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label15.Visible = false;
                dst_IptextBox.Visible = true;
                src_PorttextBox.Visible = false;
                dst_PorttextBox.Visible = false;
                protocol_Textbox.Visible = false;
                dataTextbox.Visible = false;
                src_IPtextBox.Visible = false;
                label10.Visible = true;
            }

            else if (RuleTypecomboBox.Text == "SourcePort")
            {
                label14.Visible = false;
                label10.Visible = false;
                label11.Visible = true;
                label12.Visible = false;
                label13.Visible = false;
                dst_IptextBox.Visible = false;
                src_PorttextBox.Visible = true;
                dst_PorttextBox.Visible = false;
                protocol_Textbox.Visible = false;
                dataTextbox.Visible = false;
                src_IPtextBox.Visible = false;
                label15.Visible = false;
            }

            else if (RuleTypecomboBox.Text == "DestinationPort")
            {
                label14.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = true;
                label13.Visible = false;
                dst_IptextBox.Visible = false;
                src_PorttextBox.Visible = false;
                dst_PorttextBox.Visible = true;
                protocol_Textbox.Visible = false;
                dataTextbox.Visible = false;
                src_IPtextBox.Visible = false;
                label15.Visible = false;
            }

            else if (RuleTypecomboBox.Text == "Protocol")
            {
                label14.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = true;
                dst_IptextBox.Visible = false;
                src_PorttextBox.Visible = false;
                dst_PorttextBox.Visible = false;
                protocol_Textbox.Visible = true;
                dataTextbox.Visible = false;
                src_IPtextBox.Visible = false;
                label15.Visible = false;
            }

            else if (RuleTypecomboBox.Text == "Data")
            {
                label14.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                dst_IptextBox.Visible = false;
                src_PorttextBox.Visible = false;
                dst_PorttextBox.Visible = false;
                protocol_Textbox.Visible = false;
                dataTextbox.Visible = true;
                src_IPtextBox.Visible = false;
                label15.Visible = true;
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void protocol_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
