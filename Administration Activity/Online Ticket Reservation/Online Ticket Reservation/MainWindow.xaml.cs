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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Online_Ticket_Reservation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void FlightSchd_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            var Flight = new Flight();
            Flight.Show();
        }

        private void seatdtl_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            var Seat = new Seat();
            Seat.Show();
        }
    }
}
