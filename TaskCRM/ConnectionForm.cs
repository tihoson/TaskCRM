using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace TaskCRM
{
    public partial class ConnectionForm : Form
    {
        public ConnectionForm() => InitializeComponent();

        private void CheckBoxCheckedChanged(object sender, EventArgs e)
        {
            var labels = new Label[] { passLabel, userLabel };
            var boxes = new TextBox[] { passTextBox, userTextBox };

            for (var i = 0; i < 2; i++)
            {
                labels[i].Visible = boxes[i].Visible = !checkBox.Checked;
                boxes[i].Clear();
            }
        }

        private void CloseButtonClick(object sender, EventArgs e) => Close();

        private void ConnectButtonClick(object sender, EventArgs e)
        {
            var conStr = "Server=";
            if (serverNameTextBox.Text != "" && databaseTextBox.Text != "")
            {
                conStr += serverNameTextBox.Text + ";Initial Catalog=" + databaseTextBox.Text + ";";
            }
            else
            {
                MessageBox.Show("Fill up all fields!");
                return; 
            }

            if (checkBox.Checked)
            {
                conStr += "Trusted_Connection=True;";
            }
            else if (userTextBox.Text != "" && passTextBox.Text != "")
            {
                conStr += "User id=" + userTextBox.Text + ";Password=" + passTextBox.Text + ";";
            }
            else
            {
                MessageBox.Show("Fill up all fields!");
                return;
            }

            try
            {
                (Owner as MainForm).DBConnector.Open(conStr);
                if ((Owner as MainForm).DBConnector.IsOpen())
                {
                    MessageBox.Show("Success");
                    (Owner as MainForm).EnableButtons();
                    Close();                
                }
            }
            catch
            {
                MessageBox.Show("DB error");
                return;
            }   
        }
    }
}
