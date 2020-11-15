using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyFilesToLocation.Data
{
    public class ConnectionToDataBase
    {
        
        public string GetConectionString(string ip, string dataName)

            //"Data Source=localhost\\SQLEXPRESS;Database=TestDB;Integrated Security=True;"
        {   string connection;
            return connection = "Data Source="+ ip+";Database="+dataName+";Integrated Security=True;";
           
        }
    }
}
