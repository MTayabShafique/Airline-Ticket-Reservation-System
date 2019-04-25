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
    /// Interaction logic for passengersList.xaml
    /// </summary>
    public partial class passengersList : Window
    {
        public passengersList()
        {
            InitializeComponent();
            ATRSDataContext DC = new ATRSDataContext();
            var result = from P in DC.Passengers
                         select P;
            this.dataList.ItemsSource = result.ToList();
        }
    }
}
