using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        // Converts an IP address string in dotted-decimal notation to a long integer value
        public long IPToLong(string ipAddress)
        {
            // Split the IP address string into its four parts
            string[] ipParts = ipAddress.Split('.');

            // Check that there are exactly four parts
            if (ipParts.Length != 4)
            {
                // Invalid IP address format
                return -1;
            }

            // Initialize the result variable to 0
            long result = 0;

            // Loop through each part of the IP address
            for (int i = 0; i < 4; i++)
            {
                // Check that the part can be parsed as an integer
                if (!int.TryParse(ipParts[i], out int ipPart))
                {
                    // Invalid IP address format
                    return -1;
                }

                // Add the part to the result variable, shifting the previous parts to the left by 8 bits
                result = (result << 8) + ipPart;
            }

            // Return the final result value
            return result;
        }


        // Writing a fucntion to check if IP falls in a given range
        public bool IsIPInRange(string ipAddress, string range)
        {
            // If the IP address is in range it must contain '-'
            if (range.Contains("-"))
            {
                // The range has a start and end IP, so check if the IP falls within the range
                string[] rangeParts = range.Split('-');
                if (IPToLong(rangeParts[0]) == -1 || IPToLong(rangeParts[1]) == -1)
                {
                    // One of the range IPs is not in the correct format, so return false
                    return false;
                }
                 //set the start and end range
                long startIP = IPToLong(rangeParts[0]);
                long endIP = IPToLong(rangeParts[1]);

                long ip = IPToLong(ipAddress);
                // return the range
                return ip >= startIP && ip <= endIP;
            }
            else
            {
                // The range is a single IP, so check if the IP matches exactly
                if (IPToLong(ipAddress) == -1 || IPToLong(range) == -1)
                {
                    // One of the IPs is not in the correct format, so return false
                    return false;
                }

                return IPToLong(ipAddress) == IPToLong(range);
            }
        }
        private bool MatchesRule(Packet packet, Rule rule)
        {
            
            
            // Check if source IP matches rule's source IP range
            if (IsIPInRange(packet.sourceIP, rule.SourceIP))
            {
                return true;
                
            }
            
            // Check if destination IP matches rule's destination IP range
            if (IsIPInRange(packet.destinationIP, rule.DestinationIP))
            {
                return true;
            }

            // Check if source port matches rule's source port
            if (packet.SourcePort == rule.SourcePort)
            {
                return true;
            }

            // Check if destination port matches rule's destination port
            if ( packet.DestinationPort == rule.DestinationPort)
            {
                return true;
            }

            // Check if protocol matches rule's protocol
            if ( packet.Protocol == rule.Protocol)
            {
                return true;
            }

            if (packet.Data == rule.Data)
            {
                return true;
            }

            return false;
        }

        private bool MatchesAnyRule(Packet packet, List<Rule> rules)
        {
            foreach (Rule rule in rules)
            {
                // check of rule is matches and action is Allow
                if (MatchesRule(packet, rule) && rule.Action == "Allow")
                {
                    return true; // Packet matches this rule
                }
                // check if rule is found an action is deny
                else if (MatchesRule(packet, rule) && rule.Action == "Deny")
                {
                    return false;
                }
                //if no rule is found packet will be denied by default
            }
            return false; // Default action if no rules match
        }

        // Searches through a list of rules to find the first rule that matches a given packet
        // Returns the index of the matching rule, or -1 if no rule matches
        private int getRuleno(Packet packet, List<Rule> rules)
        {
            // Loop through each rule in the list
            for (int i = 0; i < rules.Count; i++)
            {
                // Get the current rule
                Rule rule = rules[i];

                // Check if the packet matches the current rule
                if (MatchesRule(packet, rule))
                {
                    // If the packet matches, return the index of the rule plus 1 (since rule indices are 1-based)
                    return i + 1;
                }
            }

            // If no rule matches, return -1
            return -1;
        }



        private void close1PacketForm_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void clearPacket_feildsButton_Click(object sender, EventArgs e)
        {
            //clear all filed including the result
            Display_packet_Resultslabel.Visible = false;
            srcIP_textBox.Clear();
            dstIP_textBox.Clear();
            srcPort_textBox.Clear();
            dstPort_textBox.Clear();
            Protocol_textBox.Clear();
            Data_textBox.Clear();
        }

        private void close2PacketForm_button_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        // A list of packets that have been added to the system
        private List<Packet> packets = new List<Packet>();

        // Adds a packet to the list of packets
        // Returns true if the packet was added successfully, or false if there was an error
        private bool AddPacket(Packet packet)
        {
            // Attempt to add the packet to the list
            try
            {
                // Add the packet to the list
                packets.Add(packet);
                Packet.PacketCount++; //increment Packet count
                // If the addition was successful, return true
                return true;
            }
            catch (Exception ex)
            {
                // If there was an error, display a message box with the error message
                MessageBox.Show($"Error adding packet to list: {ex.Message}");

                // Return false to indicate that the addition failed
                return false;
            }
        }

        // Checks if a given IP address string is valid
        // Returns true if the IP address is valid, or false if it is not
        private bool checkPacketIp(string ip)
        {
            // Split the IP address string into its four parts
            string[] parts = ip.Split('.');

            // Check that there are exactly four parts
            if (parts.Length != 4)
            {
                // If there are not exactly four parts, the IP address is invalid
                return false;
            }

            // Loop through each part of the IP address
            foreach (string part in parts)
            {
                // Check that the part can be parsed as an integer
                if (!int.TryParse(part, out int value))
                {
                    // If any part cannot be parsed as an integer, the IP address is invalid
                    return false;
                }

                // Check that the value is between 0 and 255 (inclusive)
                if (value < 0 || value > 255)
                {
                    // If any value is outside this range, the IP address is invalid
                    return false;
                }
            }

            // If all parts are valid, the IP address is valid
            return true;
        }
        // Reads a list of rules from a file on the desktop
        // Returns a list of rules that were read from the file
        private List<Rule> ReadRulesFromFile()
        {
            // Create a new list of rules to store the rules that are read from the file
            List<Rule> rules = new List<Rule>();

            // Get the path to the desktop
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Combine the desktop path with the name of the rules file to get the full file path
            string filePath = Path.Combine(desktopPath, "rules.txt");

            // Use a StreamReader to read the contents of the file
            using (var reader = new StreamReader(filePath))
            {
                // Read each line of the file
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Split the line into its parts
                    string[] parts = line.Split(' ');

                    // Check that there are at least four parts
                    if (parts.Length >= 4)
                    {
                        // Parse the first part as the rule number
                        int ruleNo = int.Parse(parts[0]);

                        // Parse the second part as the rule type
                        string ruleTypeString = parts[1];

                        // Parse the third part as the rule value
                        string ruleValue = parts[2];

                        // Parse the fourth part as the action
                        string action = parts[3];

                        // Determine the rule type based on the second part
                        RuleType ruleType;
                        switch (ruleTypeString.ToUpper())
                        {
                            //check from rule file if patricular syntax is present sets the ruleType based on thta
                            case "SRCIP:":
                                ruleType = RuleType.SourceIP;
                                break;
                            case "DSTIP:":
                                ruleType = RuleType.DestinationIP;
                                break;
                            case "SRCPORT:":
                                ruleType = RuleType.SourcePort;
                                break;
                            case "DSTPORT:":
                                ruleType = RuleType.DestinationPort;
                                break;
                            case "PRO:":
                                ruleType = RuleType.Protocol;
                                break;
                            case "DATA:":
                                ruleType = RuleType.Data;
                                break;
                            default:
                                // Handle invalid rule name
                                throw new ArgumentException("Invalid rule Type: " + ruleTypeString);
                        }

                        // Create a new rule based on the parsed values
                        switch (ruleType)
                        {
                            //note constuctor pattern 1.SRCIP 2.DSTIP 3.SRCPORT 4.DSTPORT 5.PROTOCOL 6.DATA 7.ACTION 8.RULETYPE
                            case RuleType.SourceIP:
                                rules.Add(new Rule(ruleValue, "", -1, -1, "", "", action, ruleType));
                                break;
                            case RuleType.DestinationIP:
                                rules.Add(new Rule("", ruleValue, -1, -1, "", "", action, ruleType));
                                break;
                            case RuleType.SourcePort:
                                if (int.TryParse(ruleValue, out int port))
                                {
                                    rules.Add(new Rule("", "", port, -1, "", "", action, ruleType));
                                }
                                else
                                {
                                    throw new ArgumentException("Invalid port number", nameof(ruleValue));
                                }
                                break;
                            case RuleType.DestinationPort:
                                if (int.TryParse(ruleValue, out int desport))
                                {
                                    rules.Add(new Rule("", "", -1, desport, "", "", action, ruleType));
                                }
                                else
                                {
                                    throw new ArgumentException("Invalid port number", nameof(ruleValue));
                                }
                                break;
                            case RuleType.Protocol:
                                rules.Add(new Rule("", "", -1, -1, ruleValue, "", action, ruleType));
                                break;

                            case RuleType.Data:
                                rules.Add(new Rule("", "", -1, -1, "", ruleValue, action, ruleType));
                                break;
                            default:
                                throw new Exception($"Unknown rule type: {ruleType}");
                        }
                    }

                }

            }

            return rules;
        }
        private void checkPacket_button_Click(object sender, EventArgs e)
        {
            // CHECK THAT ALL FIELDS MUST BE FILLED
            if (srcIP_textBox.Text != "" && dstIP_textBox.Text != "" && srcPort_textBox.Text != "" && dstPort_textBox.Text != ""
                && Protocol_textBox.Text != "" && Data_textBox.Text != "")
            {
              
                // Get the input values from the UI
                string sourceIpAddress = srcIP_textBox.Text;     
                string destinationIpAddress = dstIP_textBox.Text;
                bool sourceIpValid =checkPacketIp(sourceIpAddress);
                bool destinationIpValid = checkPacketIp(destinationIpAddress);
                if (!sourceIpValid || !destinationIpValid)
                {
                    MessageBox.Show("Invalid IP address format. The format should be a.b.c.d.");
                    return;
                }

                int sourcePort = int.Parse(srcPort_textBox.Text);
                int destinationPort = int.Parse(dstPort_textBox.Text);
                string protocol = Protocol_textBox.Text;
                string data = Data_textBox.Text;
              
                  

                // Check if the source port is within the valid range
                if (sourcePort < 0 || sourcePort > 65535)
                {
                    MessageBox.Show("Invalid source port number. The valid range is 0 to 65535.");
                    return;
                }

                // Check if the destination port is within the valid range
                if (destinationPort < 0 || destinationPort > 65535)
                {
                    MessageBox.Show("Invalid destination port number. The valid range is 0 to 65535.");
                    return;
                }

                // Read the rules from the file
                List<Rule> rules = ReadRulesFromFile();
               

                // Create a new packet and check the rules against it
                Packet packet = new Packet(sourceIpAddress, destinationIpAddress, sourcePort, destinationPort, protocol, data);
                bool allowed = MatchesAnyRule(packet, rules);

                // Generate timestamp
                DateTime currentTime = DateTime.Now; //get the current date and time
                string formattedTimestamp = currentTime.ToString("yyyy-MM-dd HH:mm:ss"); // Customize the format as needed

                if (AddPacket(packet))
                {
                    //IF PACKET IS ADDED TO THE LIST
                    srcIP_textBox.Clear();
                    dstIP_textBox.Clear();
                    srcPort_textBox.Clear();
                    dstPort_textBox.Clear();
                    Protocol_textBox.Clear();
                    Data_textBox.Clear();
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string filePath = Path.Combine(desktopPath, "Results.txt");
                    //DECIDES THE RESULTS OF THE PACKET
                    string result = allowed ? "Allowed" : "Denied";

                    //GETTING THE RULE NO
                    int ruleNo = getRuleno(packet, rules);

                    if (allowed) //IF RULE IS FOUND AND PACKET IS ALLOWED
                    {
                        Display_packet_Resultslabel.Text = formattedTimestamp + "     " + "SRCIP: " + sourceIpAddress + "   "
                           + "DSTIP: " + destinationIpAddress + "    " + "SRCPORT: " + sourcePort.ToString()
                           + "    " + "DSTPORT: " + destinationPort.ToString() + "     "
                            + "PRO: " + protocol + "    " + "DATA: " + data + "    " + result + "   " + "Rule no " + (ruleNo > 0 ? ruleNo.ToString() : "No rule found");
                        Display_packet_Resultslabel.Visible = true;

                        using (StreamWriter writer = new StreamWriter(filePath, true))
                        {
                            writer.WriteLine(Display_packet_Resultslabel.Text + "\n");
                        }
                    }
                    else //IF RULE IS FOUND AND PACKED IN DENIED
                    {
                        if (ruleNo > 0)
                        {
                            Display_packet_Resultslabel.Text = formattedTimestamp + "     " + "SRCIP: " + sourceIpAddress + "   "
                               + "DSTIP: " + destinationIpAddress + "    " + "SRCPORT: " + sourcePort.ToString()
                               + "    " + "DSTPORT: " + destinationPort.ToString() + "     "
                                + "PRO: " + protocol + "    " + "DATA: " + data + "    " + result + "    " + "Rule no " + ruleNo;
                            Display_packet_Resultslabel.Visible = true;

                            using (StreamWriter writer = new StreamWriter(filePath, true))
                            {
                                writer.WriteLine(Display_packet_Resultslabel.Text + "\n");
                            }
                        }
                        else
                        { //NO RULE FOUND
                            Display_packet_Resultslabel.Text = formattedTimestamp + "     " + "SRCIP: " + sourceIpAddress + "   "
                              + "DSTIP: " + destinationIpAddress + "    " + "SRCPORT: " + sourcePort.ToString()
                              + "    " + "DSTPORT: " + destinationPort.ToString() + "     "
                               + "PRO: " + protocol + "    " + "DATA: " + data + "    " + result + "    " + "No rule found";
                            Display_packet_Resultslabel.Visible = true;

                            using (StreamWriter writer = new StreamWriter(filePath, true))
                            {
                                writer.WriteLine(Display_packet_Resultslabel.Text + "\n");
                            }
                        }
                       

                      
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Error.All Fields must be filled!");
            }
        }
      

       


    private void Display_packet_Resultslabel_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
