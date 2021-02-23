using spikeball.Classes;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace spikeball
{
    /// <summary>
    /// Interaction logic for ContactDetailsWindow.xaml
    /// </summary
        public partial class ContactDetailsWindow : Window
        {
        Teams teams;
            public ContactDetailsWindow(Teams teams)
            {
                InitializeComponent();
                this.teams = teams;
            }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            //ToDo Update existing Contact
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.strDatabasePath))
            {
                conn.CreateTable<Teams>();
                conn.Delete(teams);
                //ToDo Delete existing contact
            }
            Close();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            //ToDo Close existing contact
            Close();


        }
    }
    }
