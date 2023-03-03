using BeautyApplication.Controllers;
using BeautyApplication.Models;
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

namespace BeautyApplication.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        public RegPage()
        {
            InitializeComponent();
        }

 

        private void RegButtonClick(object sender, RoutedEventArgs e)
        {
            if (PasswordTextBox.Text != String.Empty && LoginTextBox.Text != String.Empty)
            {
                if (ReturnPasswordTextBox.Text == PasswordTextBox.Text)
                {
                    Users user = new Users()
                    {
                        UserLogin = LoginTextBox.Text,
                        UserPassword = PasswordTextBox.Text
                    };
                    Clients cl = new Clients()
                    {
                        FirstName = SurnameTextBox.Text,
                        LastName = NameTextBox.Text,
                        Patronymic = PatronymicTextBox.Text,
                        GenderCode = "1",
                        Birthday = BirthdatePicker.SelectedDate.Value,
                        Email = EmailTextBox.Text,
                        Phone = PhoneTextBox.Text,                        
                        Login = LoginTextBox.Text
                    };
                    if (UsersController.RegUser(user) && ClientsController.RegClient(cl))
                    {
                        MessageBox.Show("Вы успешно зарегистрировались!");
                        this.NavigationService.Navigate(new AuthPage());
                    }
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают!");
                }
            }
            else
            {
                MessageBox.Show("не заполнены поля!");
            }
        }

        private void NewCaptchaClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
