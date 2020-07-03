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

namespace TaskCRM
{
    public partial class MainForm : Form
    {
        public DBConnector DBConnector { get; }
        public bool Connected { get; set; }

        public MainForm()
        {
            InitializeComponent();

            DBConnector = new DBConnector();

            ShowConnectionForm();
        }

        private void ShowButtonClick(object sender, EventArgs e)
        {
            string script = File.ReadAllText("../../RequestAll.sql");
            new DataViewForm(DBConnector.GetDataSet(script).Tables[0]).Show(this);
        }

        private void SearchButtonClick(object sender, EventArgs e)
        {
            var countryInfo = JSONDeserializer.DeserializeResponse(NetConnector.GetCountryResponse(countryTextBox.Text));
            
            if (countryInfo == null)
            {
                MessageBox.Show("Country not found");
            }
            else
            {
                new CountryViewForm(countryInfo).Show(this);
            }
        }

        private void ShowConnectionForm() => new ConnectionForm().Show(this);

        private void ConnectionButtonClick(object sender, EventArgs e) => ShowConnectionForm();

        public void EnableButtons()
        {
            showButton.Enabled = true;
            searchButton.Enabled = true;
            countryTextBox.Enabled = true;
        }
    }
}
