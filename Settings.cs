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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveSuggestionButton_Click(object sender, EventArgs e)
        {
            // SAVING SUGGESTION
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter a suggestion!");
            }
            else
            {
                textBox1.Text = string.Empty;
                MessageBox.Show("Suggestion Saved!");
            }
            
            //Further we can save suggestions to a list or file if needed.
        }

        private void ResetProgressButton_Click(object sender,EventArgs e)
        {
            //First of all we will make the results file empty 
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "Results.txt");

            // Clear the contents of the file
            File.WriteAllText(filePath, string.Empty);

            //Now we will make the rules file empty
           
            string RulesfilePath = Path.Combine(desktopPath, "rules.txt");

            // Clear the contents of the file
            File.WriteAllText(RulesfilePath, string.Empty);

            //Set the rule counter to zero again
            Rule.Rulecount = 0;

            //Set the packet Counter to zero as well
            Packet.PacketCount = 0;
            MessageBox.Show("Operation Successfull!");
        }

        private void Close_RulesFormButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
