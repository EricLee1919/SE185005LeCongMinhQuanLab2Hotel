using System.Windows;

namespace SE185005LeCongMinhQuanLab2
{
    public partial class MainWindow : Window
    {
        private string _role;

        public MainWindow(string role)
        {
            InitializeComponent();
            _role = role;
            SetupUI();
        }

        private void SetupUI()
        {
            if (_role == "Admin")
            {
                btnManageCustomers.Visibility = Visibility.Visible;
                btnManageRooms.Visibility = Visibility.Visible;
                btnManageBookings.Visibility = Visibility.Visible;
                btnStatistics.Visibility = Visibility.Visible;
            }
            else if (_role == "Customer")
            {
                btnProfile.Visibility = Visibility.Visible;
                btnBookingHistory.Visibility = Visibility.Visible;
            }
        }

        private void btnManageRooms_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnManageCustomers_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnManageBookings_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnStatistics_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnProfile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBookingHistory_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
