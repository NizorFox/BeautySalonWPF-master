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
using CheckRegPageClass;

namespace BeautySalonWPF.View.Pages
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

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            if (WriteCaothaTextBox.Text != String.Empty || !String.IsNullOrWhiteSpace(WriteCaothaTextBox.Text))
            {
                RegPageClass obj = new RegPageClass();
                bool resultName = obj.NameCheck(NameTextBox.Text);
                bool resultSurName = obj.NameCheck(LastNameTextBox.Text);
                bool resultOtherName = obj.NameCheck(OtherNameTextBox.Text);
                bool resultLogin = obj.LoginCheck(LoginTextBox.Text);
                bool resultPassword = obj.NameCheck(PasswordPasswordBox.Password);
                bool resultRePassword = obj.PasswordCheck(RepeatPasswordPasswordBox.Password);
                if (resultName && resultSurName && resultOtherName && resultLogin && resultPassword && resultRePassword && WriteCaothaTextBox.Text == CaptchaText.Text)
                {
                    Users newUser = new Users
                    {
                        IDRole = 2,
                        UserName = NameTextBox.Text,
                        UserLastName = LastNameTextBox.Text,
                        UserOtherName = OtherNameTextBox.Text,
                        UserLogin = LoginTextBox.Text,
                        UserPassword = PasswordPasswordBox.Password
                    };
                    if (RepeatPasswordPasswordBox.Password != PasswordPasswordBox.Password)
                    {
                        MessageBox.Show("Пароли разные");
                    }
                    else
                    if (UsersController.AddUser(newUser))
                    {
                        MessageBox.Show("Пользователь добавлен");
                        RegFrame.Navigate(new AuthorizationPage());
                    }
                }
                else
                {
                    MessageBox.Show("Пользователь не добавлен");
                }

            }
            else
            {
                MessageBox.Show("Вы не ввели каптчу");
            }
           
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            RegFrame.Navigate(new AuthorizationPage());
        }


        private void CaptchaButton_Click(object sender, RoutedEventArgs e)
        {
            CreateCaptcha();
        }

        private void CreateCaptcha()
        {
            string allowchar = string.Empty;
            allowchar = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
            allowchar += "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,y,z";
            allowchar += "1,2,3,4,5,6,7,8,9,0";
            char[] splitComma = { ',' };
            string[] allowSymbols = allowchar.Split(splitComma);
            string captcha = string.Empty;
            string randomCaptcha = string.Empty;
            System.Random r = new System.Random();

            for (int i = 0; i < 6; i++)
            {
                randomCaptcha = allowSymbols[(r.Next(0, allowSymbols.Length))];

                captcha += randomCaptcha;
            }

            CaptchaText.Text = captcha;
        }

    }
}
