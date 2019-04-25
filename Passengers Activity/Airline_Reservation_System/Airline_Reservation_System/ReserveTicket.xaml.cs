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
    /// Interaction logic for ReserveTicket.xaml
    /// </summary>
    public partial class ReserveTicket : Window
    {
        int flightID = 0;
        public ReserveTicket()
        {
            InitializeComponent();

            ATRSDataContext DC = new ATRSDataContext();
            var result = from P in DC.Flight_Details join R in DC.Reserve_Tickets on P.flight_id equals R.filght_id 
                         select 
                         new
                         {
                         P.from_airport,
                         P.to_airport,
                         P.flight_id,
                         R.ticket_type,
                         P.first_class_fare,
                         P.economy_fare
                         };
           
            foreach (var item in result)
            {
                flightID = item.flight_id;
                T_Type.Items.Add(item.ticket_type);
                fromAirport.Items.Add(item.from_airport);
                toAirport.Items.Add(item.to_airport);

                if (T_Type.Items.Equals("First Class"))
                {
                    //MessageBox.Show("Here you Go");
                    //var result1 = (from FL in DC.Flight_Details
                    //               where FL.flight_id == flightID
                    //               select FL).FirstOrDefault();
                    T_Fare.Text = item.first_class_fare.ToString();
                }

                else 
                {
                    //var result1 = (from FL in DC.Flight_Details
                    //               where FL.flight_id == flightID
                    //               select FL).FirstOrDefault();
                    T_Fare.Text = item.economy_fare.ToString();
                }


            }




          

        }
        private void cancelTCK_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            FlightDetail canRT = new FlightDetail();
            canRT.Show();
        }

        private void backRT_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            UserActivity back_RT = new UserActivity();
            back_RT.Show();
        }

        private void print_tkt_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Print_Ticket PrintT = new Print_Ticket();
            PrintT.Show();
        }
    }
}
