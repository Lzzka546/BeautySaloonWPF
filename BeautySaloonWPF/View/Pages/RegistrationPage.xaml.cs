using BeautySaloonWPF.Controllers;
using BeautySaloonWPF.Models;
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

namespace BeautySaloonWPF.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void RegistrationButtonClick(object sender, RoutedEventArgs e)
        {
            
                Users newUser = new Users
                {
                    IdRole = 2,
                    UserLogin = NameTextBox.Text,
                    UserLastName = LastNameTextBox.Text,
                    UserOtherName = OtherNamaTextBox.Text,
                    UserName = LoginTextBox.Text,
                    UserPassword = PasswordPasswordBox.Password,
                    
                };
            if(UsersController.AddUser(newUser))
            {
            MessageBox.Show("Вы успешно зарегестрировались");
            }
            UsersController.AddUser(newUser);
        }
    }
}
