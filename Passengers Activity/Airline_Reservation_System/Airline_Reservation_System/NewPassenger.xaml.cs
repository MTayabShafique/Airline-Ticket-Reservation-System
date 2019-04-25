using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
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

    public partial class NewPassenger : Window
    {
        ATRSDataContext insertPsngr = new ATRSDataContext();
        public NewPassenger()
        {
            InitializeComponent();
            nationalityBox.Items.Add("Pakistani");
            nationalityBox.Items.Add("Indian");
        }

        private void Back_new_P(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow back = new MainWindow();
            back.Show();
        }

        private void Cancel_NP(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Submiit_Click(object sender, RoutedEventArgs e)
        {
            string sexTxt=null;
            if (maletxt.IsChecked == true)
            {
                sexTxt = maletxt.Content.ToString();
            }

            else
                sexTxt = femaleTxt.Content.ToString();

            Passenger P_Obj = new Passenger();
            {
                P_Obj.first_name = fname.Text.ToString();
                P_Obj.last_name = lname.Text.ToString();
                P_Obj.sex = sexTxt.ToString();
                P_Obj.age = int.Parse(agetxt.Text.ToString());
                P_Obj.cell = contact_txt.Text.ToString();
                P_Obj.telephone = tel_txt.Text.ToString();
                P_Obj.password = setPasstxt.Text.ToString();
                P_Obj.passport_no = passporttxt.Text.ToString();
                P_Obj.nationality = nationalityBox.Text.ToString();
                P_Obj.email = emailTxt.Text.ToString();
                P_Obj.address = addTXT.Text.ToString();
            };

           
            insertPsngr.Passengers.InsertOnSubmit(P_Obj);
            insertPsngr.SubmitChanges();
            MessageBox.Show("Account Created!!!");
            this.Hide();
            MainWindow logIn = new MainWindow();
            logIn.Show();
            
        }


    }
}
