using System.Windows;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace StudentRegistrationApplication.ViewModels
{
    public partial class LoginWindowVM : ObservableObject
    {
        [ObservableProperty]
        public string username;
        [ObservableProperty]
        public string password;
        UserDataContext dbContext;

        public void Loging()
        {
            dbContext = new UserDataContext();
            foreach (var user in dbContext.Users)
            {
                bool condition1 = user.Username == username;
                bool condition2 = user.Password == password;
                bool condition3 = user.Username == "Admin";

                if (condition1 && condition2 && condition3)
                {
                    AdminWindow adminWindow = new AdminWindow();
                    adminWindow.Show();
                    Application.Current.MainWindow.Close();
                }
                else if (condition1 && condition2)
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    Application.Current.MainWindow.Close();
                }

            }
        }

        [RelayCommand]
        public void invalid()
        {

            MessageBox.Show("Invalid username or password", "Error");
        }

    }
}
