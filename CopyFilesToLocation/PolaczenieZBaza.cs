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
        }

         
    }
}
