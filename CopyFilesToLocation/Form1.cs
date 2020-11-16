using CopyFilesToLocation.Data;
using CopyFilesToLocation.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CopyFilesToLocation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GgetData_Click(object sender, EventArgs e)
        {
            //int rowsLimit = Convert.ToInt32(fetchFirst_numericBox.Value);
            
            GetDatas dataBaseConnection = new GetDatas();
            string zapytka = vendor_richTextBox.Text;
            result_dataGridView.DataSource = dataBaseConnection.GetDocumentheadersDocuments(zapytka,
                                                                                            ulEu_radioButton,
                                                                                            ulNa_radioButton,
                                                                                            ulAar_radioButton);

            //if ((vendor_checkBox.Checked || countryCode_CheckBox.Checked || fileName_checkBox.Checked) != true)
            //{
            //    result_dataGridView.DataSource = dataBaseConnection.GetDocumentheadersDocuments(zapytka);
            //}
            //else if (vendor_checkBox.Checked && !countryCode_CheckBox.Checked && !fileName_checkBox.Checked)
            //{
            //    string vendorsNumbers = vendor_richTextBox.Text;

            //    result_dataGridView.DataSource = dataBaseConnection.GetDataByVendor(vendorsNumbers);
            //}
            //else if (countryCode_CheckBox.Checked && !vendor_checkBox.Checked && !fileName_checkBox.Checked)
            //{
            //    string countryCodes = countryCode_richTextBox.Text;
            //    result_dataGridView.DataSource = dataBaseConnection.GetDataByCountryCode(countryCodes);
            //}
            //else if (countryCode_CheckBox.Checked  && vendor_checkBox.Checked && !fileName_checkBox.Checked)
            //{
            //    string vendors = vendor_richTextBox.Text;
            //    string countryCodes = countryCode_richTextBox.Text;
                
            //    result_dataGridView.DataSource = dataBaseConnection.GetDataByCountryCodeAndVendor(vendors, countryCodes);
            //}
            //else if (fileName_checkBox.Checked && !countryCode_CheckBox.Checked && !vendor_checkBox.Checked)
            //{
            //    string fileName = fileName_richBox.Text;

            //    result_dataGridView.DataSource = dataBaseConnection.GetDataByFileName(fileName);
            //}
            //else if (countryCode_CheckBox.Checked && vendor_checkBox.Checked && fileName_checkBox.Checked)
            //{
            //    string vendors = vendor_richTextBox.Text;
            //    string countryCodes = countryCode_richTextBox.Text;
            //    string fileName = fileName_richBox.Text;

            //    result_dataGridView.DataSource = dataBaseConnection.GetDataByCountryCodeAndVendorAndFileName(vendors, countryCodes, fileName);
            //}
        }

        private void copy_button_Click(object sender, EventArgs e)
        {
            string copyTo = @"C:\C#\TestKopiowaniaPlików\FolderDoKtoregoKopiuje\";
            CopyFile copyFile = new CopyFile();
            if (string.IsNullOrEmpty(copyTo_TextBox.Text))
            { 
                copyFile.CopieFiles(result_dataGridView, copyTo);
            }
            else 
            {
                copyFile.CopieFiles(result_dataGridView, copyTo_TextBox.Text);
            }
                    
                    
             

        }

        private void copyFrom_button_Click(object sender, EventArgs e)
        {
            GetPathToCopy getPathToCopy = new GetPathToCopy();
            copyFrom_textBox.Text = getPathToCopy.GethPathFromDialog();
        }

        private void copyTo_button_Click(object sender, EventArgs e)
        {
            GetPathToCopy getPathToCopy = new GetPathToCopy();
            copyTo_TextBox.Text = getPathToCopy.GethPathFromDialog();
        }

        private void bazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PolaczenieZBaza polaczenieZBaza = new PolaczenieZBaza();
            polaczenieZBaza.Show();
        }
    }
}
