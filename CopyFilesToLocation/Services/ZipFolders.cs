using Ionic.Zip;
using System;
using System.Windows.Forms;

namespace CopyFilesToLocation.Services
{
    public class ZipFolders
    {
        public void ZipCopiedFolders(string path)
        {
            try
            {
                string[] folders = System.IO.Directory.GetDirectories(path, "*", System.IO.SearchOption.AllDirectories);

                foreach (var folder in folders)
                {

                    ZipFile zipFile = new ZipFile(folder + ".zip");
                    zipFile.AddDirectory(folder, "");
                    zipFile.Save();
                }
                MessageBox.Show("Dokumenty zostały spakowane");
            }
            catch (Exception ex)
            {
                string error = string.Format("Problem podczas pakowania danych:\n{0} ", ex.Message);
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
