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
    /// Interaction logic for AddNewTeam.xaml
    /// </summary>
    public partial class AddNewTeam : Window
    {
        public AddNewTeam()
        {
            InitializeComponent();
        }

        private void CloseTeamButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void UpdateTeamButton_Click(object sender, RoutedEventArgs e)
        {
            // Link naar de class
            Teams teams = new Teams()
            {
                Name = txtName.Text,
                Email = txtEmail.Text,
                Telephone = txtTelephone.Text
            };

            using SQLiteConnection connection = new SQLiteConnection(App.strDatabasePath);
            {
                connection.CreateTable<Teams>();
                connection.Insert(teams);
            }
            //Afsluiten Teams window
            Close();
        }
    }
}
