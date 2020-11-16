using CopyFilesToLocation.Models;
using CopyFilesToLocation.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace CopyFilesToLocation.Data
{
    public class GetDatas

    {

        #region Zmienne
        //private static SqlConnection ConnectToBase = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Database=TestDB;Integrated Security=True;");
        private string Connection;
        private static SqlCommand Command;
        private static SqlDataReader Reader;
        private static string SqlQuery = "";
        #endregion Zmienne
        
        #region Metody
        public List<Documentheaders> GetDocumentheadersDocuments(string zapytka, 
                                                                 RadioButton radioButtonEu, 
                                                                 RadioButton radioButtonNa,
                                                                 RadioButton radioButtonAa)
        {
            GetConnectionToDb getConnectionToDb = new GetConnectionToDb();
            Connection = getConnectionToDb.getConnectionToDataBase(radioButtonEu, radioButtonNa, radioButtonAa);
            SqlConnection ConnectToBase = new SqlConnection(Connection);
            var documentList = new List<Documentheaders>();

            try
            {
                if (ConnectToBase.State == System.Data.ConnectionState.Closed)
                {
                    ConnectToBase.Open();
                }
                if (ConnectToBase.State == System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("Polaczono");
                }
                //SqlQuery = string.Format("select * from dbo.Documentheader");
                SqlQuery = string.Format(zapytka);
                Command = new SqlCommand(SqlQuery, ConnectToBase);
                Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        documentList.Add(new Documentheaders(Convert.ToInt32(Reader["Id"].ToString()), Reader["Path"].ToString(),
                                        Reader["FileName"].ToString(), Reader["Country"].ToString(), Convert.ToInt32(Reader["Vendor"].ToString())));
                    }
                    Reader.Close();
                }
            }
            catch (Exception ex)
            {

                string error = string.Format("Problem podczas pobierania danych:\n{0} ", ex.Message);
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConnectToBase.Close();
                if (Reader != null)
                {
                    Reader.Dispose();
                    Reader = null;
                }
            }

            return documentList;
        }
        //public List<Documentheaders> GetDataByVendor(string vendors)
        //{

        //    var documentList = new List<Documentheaders>();

        //    try
        //    {
        //        if (ConnectToBase.State == System.Data.ConnectionState.Closed)
        //        {
        //            ConnectToBase.Open();
        //        }
        //        SqlQuery = string.Format("select * from dbo.Documentheader where Vendor in (" + vendors + ")");
        //        Command = new SqlCommand(SqlQuery, ConnectToBase);
        //        Reader = Command.ExecuteReader();

        //        if (Reader.HasRows)
        //        {
        //            while (Reader.Read())
        //            {
        //                documentList.Add(new Documentheaders(Convert.ToInt32(Reader["Id"].ToString()), Reader["Path"].ToString(),
        //                                Reader["FileName"].ToString(), Reader["Country"].ToString(), Convert.ToInt32(Reader["Vendor"].ToString())));
        //            }
        //            Reader.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        string error = string.Format("Problem podczas pobierania danych:\n{0} ", ex.Message);
        //        MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        ConnectToBase.Close();
        //        if (Reader != null)
        //        {
        //            Reader.Dispose();
        //            Reader = null;
        //        }
        //    }

        //    return documentList;
        //}
        //public List<Documentheaders> GetDataByCountryCode(string countryCode)
        //{

        //    var documentList = new List<Documentheaders>();

        //    try
        //    {
        //        if (ConnectToBase.State == System.Data.ConnectionState.Closed)
        //        {
        //            ConnectToBase.Open();
        //        }
        //        SqlQuery = string.Format("select * from dbo.Documentheader where Country in (" + countryCode + ")");
        //        Command = new SqlCommand(SqlQuery, ConnectToBase);
        //        Reader = Command.ExecuteReader();

        //        if (Reader.HasRows)
        //        {
        //            while (Reader.Read())
        //            {
        //                documentList.Add(new Documentheaders(Convert.ToInt32(Reader["Id"].ToString()), Reader["Path"].ToString(),
        //                                Reader["FileName"].ToString(), Reader["Country"].ToString(), Convert.ToInt32(Reader["Vendor"].ToString())));
        //            }
        //            Reader.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        string error = string.Format("Problem podczas pobierania danych:\n{0} ", ex.Message);
        //        MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        ConnectToBase.Close();
        //        if (Reader != null)
        //        {
        //            Reader.Dispose();
        //            Reader = null;
        //        }
        //    }

        //    return documentList;
        //}
        //public List<Documentheaders> GetDataByCountryCodeAndVendor(string vendor, string countryCode)
        //{

        //    var documentList = new List<Documentheaders>();

        //    try
        //    {
        //        if (ConnectToBase.State == System.Data.ConnectionState.Closed)
        //        {
        //            ConnectToBase.Open();
        //        }
        //        SqlQuery = string.Format("select * from dbo.Documentheader where Vendor in ("+vendor+") and Country in (" + countryCode + ");");
        //        Command = new SqlCommand(SqlQuery, ConnectToBase);
        //        Reader = Command.ExecuteReader();

        //        if (Reader.HasRows)
        //        {
        //            while (Reader.Read())
        //            {
        //                documentList.Add(new Documentheaders(Convert.ToInt32(Reader["Id"].ToString()), Reader["Path"].ToString(),
        //                                Reader["FileName"].ToString(), Reader["Country"].ToString(), Convert.ToInt32(Reader["Vendor"].ToString())));
        //            }
        //            Reader.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        string error = string.Format("Problem podczas pobierania danych:\n{0} ", ex.Message);
        //        MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        ConnectToBase.Close();
        //        if (Reader != null)
        //        {
        //            Reader.Dispose();
        //            Reader = null;
        //        }
        //    }

        //    return documentList;

           
        //    }

        //public List<Documentheaders> GetDataByCountryCodeAndVendorAndFileName(string vendor, string countryCode, string filename)
        //{

        //    var documentList = new List<Documentheaders>();

        //    try
        //    {
        //        if (ConnectToBase.State == System.Data.ConnectionState.Closed)
        //        {
        //            ConnectToBase.Open();
        //        }
        //        SqlQuery = string.Format("select * from dbo.Documentheader where Vendor in (" + vendor + ") " +
        //                                   "and Country in (" + countryCode + ") and FileName in("+filename+");");
        //        Command = new SqlCommand(SqlQuery, ConnectToBase);
        //        Reader = Command.ExecuteReader();

        //        if (Reader.HasRows)
        //        {
        //            while (Reader.Read())
        //            {
        //                documentList.Add(new Documentheaders(Convert.ToInt32(Reader["Id"].ToString()), Reader["Path"].ToString(),
        //                                Reader["FileName"].ToString(), Reader["Country"].ToString(), Convert.ToInt32(Reader["Vendor"].ToString())));
        //            }
        //            Reader.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        string error = string.Format("Problem podczas pobierania danych:\n{0} ", ex.Message);
        //        MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        ConnectToBase.Close();
        //        if (Reader != null)
        //        {
        //            Reader.Dispose();
        //            Reader = null;
        //        }
        //    }

        //    return documentList;
        //}
        //public List<Documentheaders> GetDataByFileName(string filename)
        //{

        //    var documentList = new List<Documentheaders>();

        //    try
        //    {
        //        if (ConnectToBase.State == System.Data.ConnectionState.Closed)
        //        {
        //            ConnectToBase.Open();
        //        }
        //        SqlQuery = string.Format("select * from dbo.Documentheader where FileName in(" + filename + ");");
        //        Command = new SqlCommand(SqlQuery, ConnectToBase);
        //        Reader = Command.ExecuteReader();

        //        if (Reader.HasRows)
        //        {
        //            while (Reader.Read())
        //            {
        //                documentList.Add(new Documentheaders(Convert.ToInt32(Reader["Id"].ToString()), Reader["Path"].ToString(),
        //                                Reader["FileName"].ToString(), Reader["Country"].ToString(), Convert.ToInt32(Reader["Vendor"].ToString())));
        //            }
        //            Reader.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        string error = string.Format("Problem podczas pobierania danych:\n{0} ", ex.Message);
        //        MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        ConnectToBase.Close();
        //        if (Reader != null)
        //        {
        //            Reader.Dispose();
        //            Reader = null;
        //        }
        //    }

        //    return documentList;
        //}
        #endregion Metody
    }
}
