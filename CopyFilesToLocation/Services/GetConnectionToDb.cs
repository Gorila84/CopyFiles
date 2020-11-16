using CopyFilesToLocation.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyFilesToLocation.Services
{
    public class GetConnectionToDb
    {
        private string host;
        private string connection;
        private string ip;
        private string dataBaseName;
        public string getConnectionToDataBase(RadioButton radioButtonEu, RadioButton radioButtonNa,
                                            RadioButton radioButtonAa)
        {
            ConnectionToDataBase connectionToDataBase = new ConnectionToDataBase();
            if (radioButtonEu.Checked)
            {
                ip = ConfigurationManager.AppSettings["uleu.ip"];
                dataBaseName = ConfigurationManager.AppSettings["uleu.base.name"];
                host = ConfigurationManager.AppSettings["uleu.host"];



            }
            else if (radioButtonNa.Checked)
            {
                ip = ConfigurationManager.AppSettings["ulna.ip"];
                dataBaseName = ConfigurationManager.AppSettings["ulna.base.name"];
                host = ConfigurationManager.AppSettings["ulna.host"];


            }
            else if (radioButtonAa.Checked)
            {
                ip = ConfigurationManager.AppSettings["ulaa.ip"];
                dataBaseName = ConfigurationManager.AppSettings["ulaa.base.name"];
                host = ConfigurationManager.AppSettings["ulaa.host"];


            }
            return connection = "Data Source ="+host+"\\"+ip+"; Database ="+ dataBaseName+"; Integrated Security = True;";

        }

    }
}
