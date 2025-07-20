using BIL.Service;
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

namespace SE185005LeCongMinhQuanLab2
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private LoginService _loginService;

        public LoginWindow()
        {
            InitializeComponent();
            _loginService = new LoginService();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Password.Trim();

            string role = _loginService.Login(email, password);

            if (role == "Admin")
            {
                MessageBox.Show("Chào Admin!");
                // Load Admin UI
            }
            else if (role == "Customer")
            {
                MessageBox.Show("Chào Khách hàng!");
                // Load Customer UI
            }
            if (role != null)
            {
                MainWindow main = new MainWindow(role);
                main.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập!");
            }
        }
    }
}
