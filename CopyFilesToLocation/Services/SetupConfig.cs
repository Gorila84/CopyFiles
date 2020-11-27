using System.Configuration;

namespace CopyFilesToLocation.Services
{
    public class SetupConfig
    {
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        public void UpdateEuConfig(string ip, string dbName, string port)
        {
           

            config.AppSettings.Settings["uleu.ip"].Value = ip;
            config.AppSettings.Settings["uleu.base.name"].Value = dbName;
            config.AppSettings.Settings["uleu.host"].Value = port;

            config.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");
        }
        public void UpdateNaConfig(string ip, string dbName, string port)
        {
            

            config.AppSettings.Settings["ulna.ip"].Value = ip;
            config.AppSettings.Settings["ulna.base.name"].Value = dbName;
            config.AppSettings.Settings["ulna.host"].Value = port;

            config.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");
        }
        public void UpdateAaConfig(string ip, string dbName, string port)
        {
            

            config.AppSettings.Settings["ulaa.ip"].Value = ip;
            config.AppSettings.Settings["ulaa.base.name"].Value = dbName;
            config.AppSettings.Settings["ulaa.host"].Value = port;

            config.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");
        }

        public void UpdateLoginData(string userName, string password)
        {
            config.AppSettings.Settings["user.name"].Value = userName;
            config.AppSettings.Settings["password"].Value = password;
           
            config.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");
        }
    }
    }
    

