using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace spikeball
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        static string strDatabaseName = "Teams.db";
        static string strFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string strDatabasePath = System.IO.Path.Combine(strFolderPath, strDatabaseName);
    }
}
