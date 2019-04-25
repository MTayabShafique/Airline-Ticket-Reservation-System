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

namespace Airline_Reservation_System
{
    /// <summary>
    /// Interaction logic for UserActivity.xaml
    /// </summary>
    public partial class UserActivity : Window
    {
        public UserActivity()
        {
            InitializeComponent();
        }

        private void Act_BACK(object sender, RoutedEventArgs e)
        {

            this.Hide();
            MainWindow New_P = new MainWindow();
            New_P.Show();

        }

        private void SearchFD_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            FlightDetail FD = new FlightDetail();
            FD.Show();
        }

       
    }
}
