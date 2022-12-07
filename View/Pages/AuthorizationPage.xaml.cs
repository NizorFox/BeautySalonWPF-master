using BeautySalonWPF.Controllers;
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

namespace BeautySalonWPF.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }
        private void AuthButtonClick(object sender, RoutedEventArgs e)
        {
            if (UsersController.Auth(LoginTextBox.Text, PasswordPasswordBox.Password))
            {
                this.NavigationService.Navigate(new MainPages());
            }
           
            if (!UsersController.Auth(LoginTextBox.Text, PasswordPasswordBox.Password))
            {
                MessageBox.Show("Такого пользователя не существует");
                this.NavigationService.Navigate(new RegistrationPage());
            }
        }

        private void RegButtonClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new RegistrationPage());
        }
    }
}
