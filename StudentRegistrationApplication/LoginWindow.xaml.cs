using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using StudentRegistrationApplication.ViewModels;

namespace StudentRegistrationApplication
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            DataContext = new LoginWindowVM();
            InitializeComponent();
        }


       


        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = Username.Text;
            string password = Password.Password;

            if (username == "admin" && password == "password")
            {
                lblResult.Text = "Login successful!";

                AdminWindow adminWindow = new AdminWindow();
                adminWindow.Show();

                this.Close();
            }
            else
            {
                lblResult.Text = "Invalid username or password!";
            }

            if (username == "user" && password == "password")
            {
                lblResult.Text = "Login successful!";

                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();

                this.Close();
            }
            else
            {
                lblResult.Text = "Invalid username or password!";
            }
        }
    }
}
