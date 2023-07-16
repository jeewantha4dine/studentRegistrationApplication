using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using StudentRegistrationApplication.Models;

namespace StudentRegistrationApplication.ViewModels
{
    public partial class AdminWindowVM : ObservableObject
    {
        [ObservableProperty]
        public int userid;

        [ObservableProperty]
        public string username = "Username";
        [ObservableProperty]
        public string password = "Password";
        [ObservableProperty]
        public ObservableCollection<User> usercollection;

        [ObservableProperty]
        public User selectedUser;

        private int CurrentId;
        private int id;

        public AdminWindowVM()
        {
            LoadGrid();


        }

        [RelayCommand]
        public void updateFiels()
        {
            userid = selectedUser.Id;
            username = selectedUser.Username;
            password = selectedUser.Password;
        }

        [RelayCommand]
        public void CreateUser()
        {
            if (Isfilled())
            {
                User user = new(CurrentId + 1, username, password);
                using (UserDataContext dataContext = new UserDataContext())
                {
                    dataContext.Users.Add(user);
                    usercollection.Add(user);
                }
            }
            else
            {
                MessageBox.Show("All the inputs are not filled!", "Error");
            }


        }

        [RelayCommand]
        public void DeleteUser()
        {
            id = SelectedUser.Id;

            try
            {
                if (id != null && id > 1)
                {


                    foreach (User user in usercollection)
                    {


                        if (user.Id == id)
                        {

                            usercollection.Remove(user);
                            using (UserDataContext dataContext = new UserDataContext())
                            {


                                dataContext.Users.Remove(user);
                                dataContext.SaveChanges();
                                return;




                            }

                        }
                    }


                }
            }
            catch
            {
                MessageBox.Show("Invalid Id!", "Error");
            }
        }


        [RelayCommand]
        public void ModifyUser()
        {
            id = SelectedUser.Id;
            try
            {

                if (id != null && id > 1 && Isfilled())
                {
                    foreach (User user in usercollection)
                    {

                        if (user.Id == id)
                        {

                            user.Username = username;
                            user.Password = password;

                            using (UserDataContext dataContext = new UserDataContext())
                            {

                                User tmpuser = dataContext.Users.Find(user.Id);
                                tmpuser.Username = username;
                                tmpuser.Password = password;
                                dataContext.Remove(user);
                                dataContext.SaveChanges();
                            }
                            return;

                        }

                    }
                }

            }
            catch
            {
                return;
            }

        }



        public void LoadGrid()
        {
            CurrentId = 0;
            usercollection = new ObservableCollection<User>();
            using (UserDataContext dataContext = new UserDataContext())
            {
                foreach (var user in dataContext.Users)
                {
                    usercollection.Add(user);
                    CurrentId++;
                }
            }
        }

        public bool Isfilled()
        {
            if ((username == null) || (password == null))
            {
                return false;
            }
            return true;
        }

    }
}
