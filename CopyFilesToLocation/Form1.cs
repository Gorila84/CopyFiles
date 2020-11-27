using CopyFilesToLocation.Data;
using CopyFilesToLocation.Services;
using System;
using System.Configuration;
using System.Windows.Forms;
using System.Xml;

namespace CopyFilesToLocation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ulEu_radioButton.Checked = true;
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

        private void zipFolders_button_Click(object sender, EventArgs e)
        {
            string path = copyTo_TextBox.Text;
            ZipFolders zipFolders = new ZipFolders();
            zipFolders.ZipCopiedFolders(path);
        }
    }
}
