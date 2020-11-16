using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyFilesToLocation.Data
{
    public class ConnectionToDataBase
    {
        private string connection;
        private string ip;
        private string dataBaseName;
      

        public string GetConectionStringUlEu()

            //"Data Source=localhost\\SQLEXPRESS;Database=TestDB;Integrated Security=True;"
        {
            ip = ConfigurationManager.AppSettings["uleu.ip"];
            dataBaseName = ConfigurationManager.AppSettings["uleu.base.name"];

           return connection ="Data Source=" + ip +";Database="+ dataBaseName + ";Integrated Security=True;";

           

        }

        public void GetConectionStringUlNa()

        //"Data Source=localhost\\SQLEXPRESS;Database=TestDB;Integrated Security=True;"
        {
            ip = ConfigurationManager.AppSettings["ulna.ip"];
            dataBaseName = ConfigurationManager.AppSettings["ulna.base.name"];

            SqlConnection ConnectToBase = new SqlConnection("Data Source=" + ip + ";Database=" + dataBaseName + ";Integrated Security=True;");

            if (ConnectToBase.State == System.Data.ConnectionState.Closed)
            {
                ConnectToBase.Open();
            }

        }

        public void GetConectionStringUlAa()

        //"Data Source=localhost\\SQLEXPRESS;Database=TestDB;Integrated Security=True;"
        {
            ip = ConfigurationManager.AppSettings["ulaa.ip"];
            dataBaseName = ConfigurationManager.AppSettings["ulaa.base.name"];

            SqlConnection ConnectToBase = new SqlConnection("Data Source=" + ip + ";Database=" + dataBaseName + ";Integrated Security=True;");

            if (ConnectToBase.State == System.Data.ConnectionState.Closed)
            {
                ConnectToBase.Open();
            }

        }
    }
}
