using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TradingCenter.Provider
{
    public class MainProvider
    {
        Linq.VersionDataContext DataContext { get; set; }
        /// <summary>
        /// Konstruktor
        /// </summary>
        public MainProvider()
        {
            DataContext = new Linq.VersionDataContext(Properties.Settings.Default.FutheadConnectionString);
        }

        /// <summary>
        /// Stellt eine Verbindung zum Server her und prüft ob es eine neue Software-Version vorhanden ist.
        /// </summary>
        public Boolean CheckForUpdates()
        {
            // Aktuelle Version(Lokal)
            String currentVersionString = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            List<String> temp = currentVersionString.Split('.').ToList();
            currentVersionString = "";
            foreach (String item in temp)
            {
                currentVersionString += Convert.ToInt32(item);
            }
            Int32 currentVersionInt = Convert.ToInt32(currentVersionString);
            // Verfügbare Versionen vom Server
            List<Linq.Version> versions = DataContext.Versions.Where(c => c.VersionID > 0 && c.Valid == true).ToList();
            Int32 highestVersion = 0;
            List<String> temp2 = new List<String>();
            foreach (Linq.Version item in versions)
            {
                temp2 = item.VersionNumber.Split('.').ToList();
                String z1 = "";
                foreach (String element in temp2)
                {
                    z1 += Convert.ToInt32(element);
                }
                item.VersionNumberInt = (Convert.ToInt32(z1));
                if (item.VersionNumberInt > highestVersion)
                {
                    highestVersion = item.VersionNumberInt;
                }
            }


            if (highestVersion >= currentVersionInt)
            {
                //Download newest File
                String downloadDirectory = versions.SingleOrDefault(c => c.VersionNumberInt == highestVersion).DownloadDirectory;
                this.Update(downloadDirectory);


            }

            var t4 = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();


            return true;
        }

        /// <summary>
        /// Hilfsmethode zum Downloaden der neuen Software
        /// </summary>
        /// <param name="dir"></param>
        private void Update(String dir)
        {
            Process process = new Process();
            process.StartInfo.FileName = @"D:\Development\TradingCenter\TradingCenter\Updater\bin\Debug\Updater.exe";
            process.StartInfo.Arguments = dir;
            process.Start();
        }

    }
}
