﻿using CopyFilesToLocation.Data;
using System.IO;
using System.Windows.Forms;

namespace CopyFilesToLocation.Services
{
    public class CopyFile
    {
        public void CopieFiles(DataGridView dataGrid, string copyTo)
        {
            Logs logs = new Logs();
            int rows = dataGrid.RowCount;
            for (int i = 0; i < rows; i++)
            {
                string path = dataGrid.Rows[i].Cells[1].Value.ToString();
                string fileName = dataGrid.Rows[i].Cells[2].Value.ToString();
                string vendor = dataGrid.Rows[i].Cells[4].Value.ToString();
                string pathString = Path.Combine(copyTo, vendor);
                if (!Directory.Exists(pathString))
                {

                    Directory.CreateDirectory(pathString);

                };
                if (File.Exists(path + fileName)){ 
                string sourceFile = Path.Combine(path, fileName);
                string destFile = Path.Combine(copyTo + vendor, fileName);

                File.Copy(sourceFile, destFile, true);
                    logs.WriteLog("Plik " + fileName + " został skopiowany z " + path + " do " + copyTo + vendor);
                }
                else
                {
                    logs.WriteLog("Plik " + fileName + " nie został skopiowany") ;
                    
                }


            }

        }

    }
}