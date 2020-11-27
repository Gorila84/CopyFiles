using CopyFilesToLocation.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CopyFilesToLocation
{
    public partial class PolaczenieZBaza : Form
    {
      
        public PolaczenieZBaza()
        {
            InitializeComponent();
            ulEuIP_textBox.Text = ConfigurationManager.AppSettings["uleu.ip"];
            ulEuDbName_textBox.Text = ConfigurationManager.AppSettings["uleu.base.name"];
            ulEuPort_textBox.Text = ConfigurationManager.AppSettings["uleu.host"];
            ulNaIP_textBox.Text = ConfigurationManager.AppSettings["ulna.ip"];
            ulNaDbName_textBox.Text = ConfigurationManager.AppSettings["ulna.base.name"];
            ulNaPort_textBox.Text = ConfigurationManager.AppSettings["ulna.host"];
            ulAarIP_textBox.Text = ConfigurationManager.AppSettings["ulaa.ip"];
            ulAarDbName_textBox.Text = ConfigurationManager.AppSettings["ulaa.base.name"];
            ulAarPort_textBox.Text = ConfigurationManager.AppSettings["ulaa.host"];
            userName_textBox.Text = ConfigurationManager.AppSettings["user.name"];
        }

        private void saveConnectionString_button_Click(object sender, EventArgs e)
        {
            string ipEu = ulEuIP_textBox.Text;
            string dbNameUlEu = ulEuDbName_textBox.Text;
            string portUlEu = ulEuPort_textBox.Text;
            string ipNa = ulNaIP_textBox.Text;
            string dbNameUlNa = ulNaDbName_textBox.Text;
            string portUlNa = ulNaPort_textBox.Text;
            string ipAar = ulAarIP_textBox.Text;
            string dbNameUlAar = ulAarDbName_textBox.Text;
            string portUlAar = ulAarPort_textBox.Text;

            SetupConfig setupConfig = new SetupConfig();
            setupConfig.UpdateEuConfig(ipEu, dbNameUlEu, portUlEu);
            setupConfig.UpdateNaConfig(ipNa, dbNameUlNa, portUlNa);
            setupConfig.UpdateAaConfig(ipAar, dbNameUlAar, portUlAar);

            ulEuIP_textBox.Text = ConfigurationManager.AppSettings["uleu.ip"];
            ulEuDbName_textBox.Text = ConfigurationManager.AppSettings["uleu.base.name"];
            ulEuPort_textBox.Text = ConfigurationManager.AppSettings["uleu.host"];
            ulNaIP_textBox.Text = ConfigurationManager.AppSettings["ulna.ip"];
            ulNaDbName_textBox.Text = ConfigurationManager.AppSettings["ulna.base.name"];
            ulNaPort_textBox.Text = ConfigurationManager.AppSettings["ulna.host"];
            ulAarIP_textBox.Text = ConfigurationManager.AppSettings["ulaa.ip"];
            ulAarDbName_textBox.Text = ConfigurationManager.AppSettings["ulaa.base.name"];
            ulAarPort_textBox.Text = ConfigurationManager.AppSettings["ulaa.host"];
        }
    }
}
