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
   
    public partial class ResetPassword : Window
    {

        MainWindow obj = new MainWindow();
        int PassengerID = 0;
        public ResetPassword(int PID)
        {
            InitializeComponent();
            PassengerID = PID;
        }

        private void resetPass_Click(object sender, RoutedEventArgs e)
        {
            ATRSDataContext DC_Obj = new ATRSDataContext();
            var query =
                from psng in DC_Obj.Passengers
                where psng.passenger_id == PassengerID
                select psng;


            foreach (Passenger item in query)
            {
                if (newPass.Password.ToString() == re_entNewPass.Password.ToString())
                {
                    item.password = newPass.Password.ToString();
                }

            }

            // Submit the changes to the database.
            if (newPass.Password.ToString() == re_entNewPass.Password.ToString())
            {
                try
                {
                    DC_Obj.SubmitChanges();
                    MessageBox.Show("Password Changed");
                    this.Hide();
                    MainWindow reback = new MainWindow();
                    reback.Show();
                }


                catch (Exception exp)
                {
                    MessageBox.Show(exp.ToString());
                    // Provide for exceptions.
                }
            }
            else
            { MessageBox.Show("Password Didnot Match"); }




        
        }
        }
    }

