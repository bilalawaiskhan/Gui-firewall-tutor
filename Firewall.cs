using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            CustomizeDesign();
            this.FormClosing += YourForm_FormClosing;
        }

        //Defining a method for the close button of our form to use it in constructor of  Form Firewall.cs
        private void YourForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            EmptyFile();
        }

        //After the program is closed in order to preserve and maintain packet count and rulecount and avoid program from unexpected
        //behaviour we makw thw file empty
        private void EmptyFile()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rulefilePath = Path.Combine(desktopPath, "rules.txt");
            string ResultsfilePath = Path.Combine(desktopPath, "Results.txt");
            File.WriteAllText(rulefilePath, string.Empty);
            File.WriteAllText(ResultsfilePath, string.Empty);
        }
        //Initially when the prograam begins the subMenu is invisible we will use this method in constructor of Firewall.cs Form
        private void CustomizeDesign()
        {
            panelMediaSubmenu.Visible = false;
        }
        //This method is to hide the subMenu
        private void HideSubMenu()
        {
            if (panelMediaSubmenu.Visible == true)
            {
                panelMediaSubmenu.Visible = false;
            }
        }

        //This method is to show submenu when user clicks once and if again it hides
   private void showSubMenu(Panel subMenu)
        {
          

            // If the submenu is currently hidden, hide all other submenus and show this one
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            // If the submenu is currently visible, hide it
            else
            {
                subMenu.Visible = false;
            }
        }
        private void FirewallHome_button_Click(object sender, EventArgs e)
        {
            //If the user clicks on the home button show subMenu to him
            showSubMenu(panelMediaSubmenu);
        }


        private void firewall_tutorAddRuleButton_Click(object sender, EventArgs e)
        {
            //using this method to properly open a new form under the child panel and hide subMenu initially
            openChildForm(new Form3());
            HideSubMenu();
        }

        private void firewall_tutorCheckPacketButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
            HideSubMenu();
        }

        private void firewall_tutorViewRulesButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Form8());
            HideSubMenu();
        }

        private void firewall_tutorialButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Form6());
        }

        private void firewall_tutorHelpButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Form5());

        }

        private void firewall_tutorSettingsButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Form7());
        }

        private void firewall_tutorViewresults_Button_Click_1(object sender, EventArgs e)
        {
            HideSubMenu();
            openChildForm(new Form4());

        }

        //Writing a function to create a  new form when user clicks on any button in main screen
        private Form activeForm = null;
        // Opens a new child form in the main screen's panel container.
        // Closes the currently active child form (if any) before opening the new form.
        private void openChildForm(Form childForm)
        {
            // Close the currently active form (if any)
            if (activeForm != null)
                activeForm.Close();

            // Set the new form as the active form
            activeForm = childForm;

            // Configure the new form to be a child form
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Add the new form to the panel container
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;

            // Bring the new form to the front and show it
            childForm.BringToFront();
            childForm.Show();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void panelMediaSubmenu_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void panellogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       


    }
}
