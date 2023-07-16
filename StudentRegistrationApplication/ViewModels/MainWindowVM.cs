using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using StudentRegistrationApplication.Models;
using System.Windows.Media.Imaging;
using System.Windows;

namespace StudentRegistrationApplication.ViewModels
{
    public partial class MainWindowVM : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Student> students;
        [ObservableProperty]
        public Student selectedStudent = null;



        public void CloseMainWindow()
        {
            Application.Current.MainWindow.Close();
        }




        [RelayCommand]
        public void gpa()
        {

            MessageBox.Show($"{selectedStudent.FirstName} GPA must be between 0 and 4.", "Error");
        }

        [RelayCommand]
        public void AddStudent()
        {
            var vm = new AddStudentVM();
            vm.title = "ADD Student";
            AddStudentWindow window = new AddStudentWindow(vm);
            window.ShowDialog();

            if (vm.Student.FirstName != null)
            {
                Students.Add(vm.Student);
            }
        }

        [RelayCommand]
        public void Delete()
        {
            if (selectedStudent != null)
            {
                string name = selectedStudent.FirstName;
                Students.Remove(selectedStudent);
                MessageBox.Show($"{name} is deleted successfully.", "DELETED \a ");

            }
            else
            {
                MessageBox.Show("Please select a student first", "Error");


            }
        }
        [RelayCommand]
        public void ExecuteEditStudentCommand()
        {
            if (selectedStudent != null)
            {
                var vm = new AddStudentVM(selectedStudent);
                vm.title = "Edit Student";
                var window = new AddStudentWindow(vm);

                window.ShowDialog();


                int index = Students.IndexOf(selectedStudent);
                Students.RemoveAt(index);
                Students.Insert(index, vm.Student);



            }
            else
            {
                MessageBox.Show("Please select the student", "Warning!");
            }
        }

        public MainWindowVM()
        {
            Students = new ObservableCollection<Student>();
            BitmapImage imagemale = new BitmapImage(new Uri("/Model/Images/male.png", UriKind.Relative));
            BitmapImage imagefemale = new BitmapImage(new Uri("/Model/Images/female.png", UriKind.Relative));
            Students.Add(new Student(12, "Jeewantha", "Senapathy", "24/04/2000", imagemale));
            
            Students.Add(new Student(12, "Dineth", "Perera", "24/05/2000", imagemale));
            
            Students.Add(new Student(12, "Nelaka", "Bandara", "24/06/2000", imagemale));
            
            Students.Add(new Student(12, "Shehani", "Munidasa", "24/06/2000", imagefemale));

        }
    }
}
