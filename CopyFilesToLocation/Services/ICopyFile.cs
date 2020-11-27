using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyFilesToLocation.Services
{
    public interface ICopyFile
    {
        void CopieFiles(DataGridView dataGrid, string copyTo);
    }
}
