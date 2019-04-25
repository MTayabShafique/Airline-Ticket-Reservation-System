using System.Windows;
using System.Linq;


namespace Airline_Reservation_System
{
    /// <summary>
    /// Interaction logic for FlightDetail.xaml
    /// </summary>
    public partial class FlightDetail : Window
    {
        public FlightDetail()
        {
            InitializeComponent();

            ATRSDataContext DC = new ATRSDataContext();
            var result = from P in DC.Flight_Details
                         select new { 
                        Flight_ID = P.flight_id,
                        From = P.from_airport,
                        To = P.to_airport,
                        Departure_Time = P.departure_time,
                        Departure_Date = P.departure_date.ToShortDateString(),
                        Arrival_Time =   P.arrival_time,
                        Arrival_Date =   P.arrival_date.ToShortDateString(),
                        Economy_Class_Fare = P.economy_fare,
                        First_CLass_Fare=  P.first_class_fare
                         };

            this.gridFlights.ItemsSource = result.ToList();

        }

        private void backActivity_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            UserActivity back_Activity = new UserActivity();
            back_Activity.Show();

        }

        private void signOutFD_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow SOut = new MainWindow();
            SOut.Show();
        }

        private void reserveTKT_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ReserveTicket tkt = new ReserveTicket();
            tkt.Show();
        }
    }
}
