   M S B A M L   `   `   `  ����Y  UStudentRegistrationApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:StudentRegistrationApplicationStudentRegistrationApplication  5   	   e7clr-namespace:StudentRegistrationApplication.ViewModels)StudentRegistrationApplication.ViewModels  6D   /    )StudentRegistrationApplication.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:StudentRegistrationApplication     5   	   Jlocal17clr-namespace:StudentRegistrationApplication.ViewModels     6D     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � AllowsTransparency$
 True��5	   	    � WindowStartupLocation$ CenterScreen=�6#    � WindowStyle$
 None=�6H   .��5   
   � .+�5      �� $	��800��6   $	��100��6%   $��Bottom=�5      
����İ� �� Orientation$ 
Horizontal=�5   1   .+�5      �� $��Add Student��6      	navbutten#��[  5      ��5      �� *AddStudentCommand+5      �� 5      $��Edit Student Student��6   #��[  69   ��5      �� *" ExecuteEditStudentCommandCommand+�� 5      $��Delete Student��6   #��[  6/   ��5      �� *DeleteCommand+5      �� 5   
   $	��335��6   ���#272537$	��Top=�67   $ Vertical=�6O   .+�5      �� $��	 40 0 0 0q�6   $
��Left=�61   $	��600��6L   
������ $ 
Horizontal=�5   6   .+�5      �� $��	FirstName��6   
�������  Usertext#��[ 5       �� 5!      $��LastName��6   
�������#��[ 5"      �� 5#      $	��Age��6   
�������#��[ 5$      �� 5%      $��DataOfBirth��6   
�������#��[ 5&      �� 5'      $	��Gpa��6   
����  �#��[ 6:   5)      �� 5*      -   5         ��Name$ Listview��5*      
������ $	��280��6B   ��5+      �� *
Students+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 5,      �� *SelectedStudent+$ PropertyChanged=���5-      �� 5.      .R�5/      �� 
������ 
���   �$��1q�6N    �� Padding$	 0.1q�50   !   	 �� CornerRadius$	 5��6/   $	��600��6@   $��35��6L   ._�51      �� $	��600��6)   
������ $ 
Horizontal=�6O   .+�53   "   �� $��30��6(   $��30��63   $��1q�6?   ��6J   �� *Image+�� 54   "   #��[ 55   0   ��54   ,   �� *	FirstName+$ PropertyChanged=�55   0   �� 56   "   #��[ 57   0   ��56   ,   �� *
LastName+$ PropertyChanged=�57   0   �� 58   "   #��[ 59   0   ��58   ,   �� *Age+$ PropertyChanged=�59   0   �� 5:   "   #��[ 5;   0   ��5:   ,   �� *DateOfBirth+$ PropertyChanged=�5;   0   �� 5<   "   #��[ 5=   0   ��5<   ,   �� *GPA+$ PropertyChanged=�5=   0   5?      5A      5B      5E      5F      5H      5I      