using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace KontakteApp
{
    public class CustomSection : ConfigurationSection
    {

        public CustomSection()
        {

        }

        public void GetSetting()
        {
            Configuration config =
                ConfigurationManager.OpenExeConfiguration(
                ConfigurationUserLevel.None);


            var connectionString = ConfigurationManager.ConnectionStrings;





            // Create the custom section entry  
            // in <configSections> group and the 
            // related target section in <configuration>.
            if (config.Sections["CustomSection"] == null)
            {
                // config.Sections.Add("CustomSection", customSection);
            }

            // Create and add an entry to appSettings section.

            string conStringname = "LocalSqlServer";
            string conString = @"data source=.\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|aspnetdb.mdf;User Instance=true";
            string providerName = "System.Data.SqlClient";

            ConnectionStringSettings connStrSettings = new ConnectionStringSettings();
            connStrSettings.Name = conStringname;
            connStrSettings.ConnectionString = conString;
            connStrSettings.ProviderName = providerName;
        }

    }
}
