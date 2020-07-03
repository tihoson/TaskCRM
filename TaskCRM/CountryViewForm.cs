using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskCRM
{
    public partial class CountryViewForm : Form
    {
        public CountryViewForm(Dictionary<string, dynamic> countryInfo)
        {
            InitializeComponent();

            nameTextBox.Text = countryInfo["name"];
            codeTextBox.Text = countryInfo["alpha3Code"];
            capitalTextBox.Text = countryInfo["capital"];
            areaTextBox.Text = countryInfo["area"].ToString();
            populationTextBox.Text = countryInfo["population"].ToString();
            regionTextBox.Text = countryInfo["region"];
        }

        private void CloseButtonClick(object sender, EventArgs e) => Close();

        private void SaveButtonClick(object sender, EventArgs e)
        {
            var connector = (Owner as MainForm).DBConnector;

            var ids = GetIDs(connector);

            if (ids == null)
            {
                return;
            }
            try
            {
                var q = "SELECT code FROM dbo.country WHERE dbo.country.code = '" + codeTextBox.Text + "'";

                var ds = connector.GetDataSet(q);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    var insq = "INSERT dbo.country(name, capital_id, region_id, area, population, code) " +
                        "VALUES('" + capitalTextBox.Text + "'," + ids[0] + "," + ids[1] + "," + areaTextBox.Text +
                        "," + populationTextBox.Text + ",'" + codeTextBox.Text + "')";
                    connector.ExecuteQuery(insq);

                    MessageBox.Show("Success");
                }
            } 
            catch (SqlException)
            {
                MessageBox.Show("Some problems with DB");
            }

            Close();
        }

        private string[] GetIDs(DBConnector connector)
        {
            var ids = new string[2];

            var tables = new string[] { "city", "region" };
            var names = new string[] { "'" + capitalTextBox.Text + "'", "'" + regionTextBox.Text + "'" };

            for (var i = 0; i < 2; i++)
            {
                try
                {
                    var tbName = "dbo." + tables[i];
                    var q = "SELECT " + tbName + ".id FROM " + tbName +
                        " WHERE " + tbName + ".name = " + names[i];

                    var ds = connector.GetDataSet(q);

                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        connector.ExecuteQuery("INSERT " + tbName + "(name) VALUES(" + names[i] + ")");
                        ds = connector.GetDataSet(q);
                    }
                    ids[i] = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Some problems with DB");
                    return null;
                }
            }

            return ids;
        }
    }
}
