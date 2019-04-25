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

namespace Airline_Reservation_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       int passengID = 0;


        public MainWindow()
        {
            InitializeComponent();
        }
        private void loginClick(object sender, RoutedEventArgs e)
        {

            ATRSDataContext DC = new ATRSDataContext();
           
            var result = from P in DC.Passengers
                         select P;

            foreach (var item in result)
            {
                if ((userName.Text.Equals(item.first_name)) && (passWord.Password.Equals(item.password)))
                {

                    this.Hide();
                    UserActivity User_A = new UserActivity();
                    User_A.Show();
                }

                else if ((userName.Text.Equals(item.first_name))  && (!passWord.Password.Equals(item.password)))
                {
                    passengID = item.passenger_id;
                }
            }
        }

        private void CreateNewPassenger(object sender, RoutedEventArgs e)
        {
            this.Hide();
            NewPassenger New_P = new NewPassenger();
            New_P.Show();
        }


        private void ResetPass_Click(object sender, RoutedEventArgs e)
        {
            if (passengID != 0)
            {
                this.Hide();
                ResetPassword PL = new ResetPassword(passengID);
                PL.Show();
            }
            else
                MessageBox.Show("You have not entered your name!!!");
        }
    }
}
