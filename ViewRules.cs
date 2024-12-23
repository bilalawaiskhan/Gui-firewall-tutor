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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void ViewRulesForm_Title_label_Click(object sender, EventArgs e)
        {

        }

        //getting content of file rules.txt
        public void DisplayFileContent(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                 
                    string content = reader.ReadToEnd();
                    ViewRules_Form_lables.Text = content; // replace textBox1 with the name of your TextBox or any other suitable control
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying file content: {ex.Message}");
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            //if rule count is zero display this text
            if (Rule.Rulecount == 0)
            {
                ViewRules_Form_lables.Text = "No Rule added till now";
                ViewRules_Form_lables.Visible = true;
            }
            else
            {
                // get the filee contents
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, "rules.txt");
                DisplayFileContent(filePath);

            }

            if (Rule.Rulecount == 20)
            {
                //we make sure to make spaces for new rules and reset previosu rules
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string RulesfilePath = Path.Combine(desktopPath, "rules.txt");

                // Clear the contents of the file
                File.WriteAllText(RulesfilePath, string.Empty);
            }
        }

        private void ViewRules_Form_lables_Click(object sender, EventArgs e)
        {

        }

        private void Close_ViewRulesFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
