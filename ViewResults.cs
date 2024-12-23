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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        //BY THIS METHOD WE GET THE RESULTS FROM FILE Results.txt
        public void DisplayResultFileContent(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {

                    string content = reader.ReadToEnd();
                    ViewResult_Form_label.Text = content; // replace textBox1 with the name of your TextBox or any other suitable control
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying file content: {ex.Message}");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //if packet count is zero display this text
            if (Packet.PacketCount == 0)
            {
                ViewResults_Form_lables2.Text = "No Packet checked till now";
                ViewResults_Form_lables2.Visible = true;
            }
            else
            {
                //get the content of the file
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, "Results.txt");
                DisplayResultFileContent(filePath);
                ViewResult_Form_label.Visible = true;
            }
            if (Packet.PacketCount == 10)
            {
                //If the packet count is 10 we clear the pervious all results to make spaces for new ones
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, "Results.txt");

                // Clear the contents of the file
                File.WriteAllText(filePath, string.Empty);

            }
        }

        private void FirewallTutorViewResultsForm_Title_label_Click(object sender, EventArgs e)
        {

        }

        private void ViewResult_Form_label_Click(object sender, EventArgs e)
        {
           
        }

        private void Close_ViewResultsFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewResulgs_Form_lables2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

       
}
