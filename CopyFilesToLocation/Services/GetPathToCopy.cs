using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyFilesToLocation.Services
{
    public class GetPathToCopy
    {
        string results;
        
        public string GetPath(DataGridView dataGrid)
        {
            int rows = dataGrid.RowCount;
            for (int i = 0; i < rows; i++)
            {
                string vendor = dataGrid.Rows[i].Cells[1].Value.ToString();
            }
            return results;

        }

        public string GethPathFromDialog()
        {
            var dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            string copyFromPath  = dialog.SelectedPath;

            return copyFromPath + "\\";
        }
    }
}
