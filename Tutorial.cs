using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace project
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeButtonTutorial_Click(object sender, EventArgs e)
        {

            // IN  THIS FORM WE MAKE USRE THAT ONLY PARTICULAR BUTTON TEXT IS SHOWN AND NOT OTHER
            TutorialForms_label3.Text = "";
            Tutorial_Formlabel5.Visible = false;
            TutorialForms_label3.Visible = false;
            Tutorial_Formlabel_TEXT.Visible = true;
            Tutorial_AddRulesButton.Visible = true;
            Tutorial_AboutButton.Visible = true;
            Tutorial_ViewRulesButton.Visible = true;
            Tutorial_CheckPacketsButton.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void HelpButtonTutorial_Click(object sender, EventArgs e)
        {
            //NECESARRY TO MAKE LABELS EMPTY EVERYTIME WE WANT TO ADD NEW TEXT
            TutorialForms_label3.Text = "";
            Tutorial_Formlabel5.Visible = false;
            Tutorial_Formlabel5.Visible = false;
            Tutorial_Formlabel_TEXT.Visible = false;
            Tutorial_AddRulesButton.Visible = false;
            Tutorial_AboutButton.Visible = false;
            Tutorial_ViewRulesButton.Visible = false;
            Tutorial_CheckPacketsButton.Visible = false;
            TutorialForms_label3.Text ="***Firewall Help Button***\n\n"+ "This is the Help page for the firewall tutor.\n\n" +
                "Here is what user can expect here: \n"+
                "***Query Solution***: If the user feels any query they can easily contact us.\n" +
                "***Purpose of app***: It also shows user the purpose of the app, what they can explore here.\n     It also explains how user" +
                " can take experience of real world firewall environment.";
            TutorialForms_label3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TutorialForms_label3.Text = "";
            Tutorial_Formlabel5.Visible = false;
            Tutorial_Formlabel_TEXT.Visible = false;
            Tutorial_AddRulesButton.Visible = false;
            Tutorial_AboutButton.Visible = false;
            Tutorial_ViewRulesButton.Visible = false;
            Tutorial_CheckPacketsButton.Visible = false;
            TutorialForms_label3.Text = "This is the page that explains the functionality and purpose of each button.\n" +
                "User can click on any button and see its functionality which makes it user friendly.";
            TutorialForms_label3.Visible = true;
        }

        private void SettingsButtonTutorial_Click(object sender, EventArgs e)
        {
            TutorialForms_label3.Text = "";
            
            Tutorial_Formlabel5.Visible = false;
            Tutorial_Formlabel_TEXT.Visible = false;
            Tutorial_AddRulesButton.Visible = false;
            Tutorial_AboutButton.Visible = false;
            Tutorial_ViewRulesButton.Visible = false;
            Tutorial_CheckPacketsButton.Visible = false;
            TutorialForms_label3.Text = "***Firewall Tutor Settings***\n\n" +
                           "This section allows you to customize your Firewall Tutor experience.\n\n" +
                           " Here you can adjust the following options:\n" +
                 "***Reset Progress***: This option allows you to completely reset your progress in the Firewall Tutor\n" +
                 "    and start from the beginning.";
            TutorialForms_label3.Visible = true;
        }

        private void Tutorial_AboutButton_Click(object sender, EventArgs e)
        {
            TutorialForms_label3.Visible = false;
            Tutorial_Formlabel5.Text = "";
            Tutorial_Formlabel5.Text = "*** View Results Button ***\n\n" +

  "This section displays the most recent firewall activity log.\n\n" +

  "**Viewing Results:**\n" +
  "1. The log shows captured network traffic data along with the corresponding\n" +
  "   rule number applied (if any).\n" +
  "2. Only the results from the current application session are displayed.\n" +
  "   - Once you close the application, the log is cleared.\n\n" +

  "**Understanding the Log:**\n" +
  " - Each entry may include details like:\n" +
  "   - Packet data (may be displayed in a summarized or raw format)\n" +
  "   - Rule number applied (if a rule matched the packet criteria)\n\n" +

  "**Note:**\n" +
  "- The displayed information may vary depending on the application's\n" +
  "   configuration.";
            Tutorial_Formlabel5.Visible = true;
            
        }

        private void Tutorial_AddRulesButton_Click(object sender, EventArgs e)
        {
            TutorialForms_label3.Visible = false;
            
            Tutorial_Formlabel5.Text = "";

            Tutorial_Formlabel5.Text = "*** Add Rules Button ***\n\n" +

  "This section allows you to define custom firewall rules to manage incoming\n" +
  "and outgoing network traffic.\n\n" +

  "**Choosing a Rule Type:**\n" +
  "1. Select the desired rule type from the dropdown menu.\n" +
  "   - Available rule types include source IP address, destination IP address,\n" +
  "     source port, destination port, protocol, or data content.\n" +
  "2. Define the specific criteria for your chosen rule type in the corresponding fields.\n" +
  "   - At least one criterion must be specified.\n\n" +
  "**Creating a Rule:**\n" +
  "1. **Rule Criteria:** After selecting the rule type, fill in the relevant details\n" +
  "   like source/destination IP addresses, ports, protocol, or data string (depending\n" +
  "   on the chosen rule type).\n\n" +

  "**Remember:**\n" +
  "- Only one rule type can be selected at a time.\n" +
  "- You must define at least one criterion for the chosen rule type.\n";
            Tutorial_Formlabel5.Visible = true;
        }

        private void Tutorial_CheckPacketsButton_Click(object sender, EventArgs e)
        {
            TutorialForms_label3.Visible = false;
            
            Tutorial_Formlabel5.Text = "";
            Tutorial_Formlabel5.Text = "*** Check Packet Data ***\n\n" +

    "This section allows you to analyze a network packet and view the results.\n" +

    "**Analyze a Packet:**\n" +

    "1. **Enter Packet Details:**\n" +
    "    * Fill in all the required fields with information about the network packet\n      you want to analyze.\n" +

    "2. **Click 'Check Packet' Button:**\n" +
    "    * After entering all the necessary details, click the 'Check Packet' button\n      to initiate the analysis.\n\n" +

    "**Results:**\n" +

    "  * Following the analysis, the result will be displayed below the 'Check Packet' button:\n" +
    "    * **Action Taken:** A message indicating the specific action performed based\n         on the packet data (e.g., 'Packet Allowed,' 'Packet Blocked').\n" +
    "    * **Timestamp:** The current timestamp will be automatically added, reflecting\n         the time of analysis.\n\n";
            Tutorial_Formlabel5.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tutorial_ViewRulesButton_Click(object sender, EventArgs e)
        {
            TutorialForms_label3.Visible = false;
            Tutorial_Formlabel5.Text = "";
            Tutorial_Formlabel5.Text = "***View Rules ***\n\n" +

    "This section allows you to view all the custom firewall rules you have created.\n\n" +

    "**Viewing Your Rules:**\n" +

    "1. **Click 'View Rules' Button:**\n" +
    "   **Click the 'View Rules' button to display a list of all your currently defined firewall rules.\n"
   + " A maximum of 20 rules can be defined at a time. \n" +
      "* Rules will be reset to zero after reaching this limit and even after closing the application.\n\n";
            Tutorial_Formlabel5.Visible = true;
        }

        private void CloseTutorialForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
