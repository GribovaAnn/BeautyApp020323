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
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
            LoginTextBox.Focus();
            RegTextBlock.Focusable = true;
        }

        /// <summary>
        /// переход на регистрацию
        /// </summary>
        private void RegTextBlockMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("переход на регистрацию");
        }
        /// <summary>
        /// Авторизация
        /// </summary>
        private void SignInButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Нажали на авторизацию");
        }


        /// <summary>
        /// Обработка события нажатия на клавиатуру
        /// </summary>
        private void RegTextBlockKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                RegTextBlockMouseLeftButtonDown(RegTextBlock, null);
            }
        }
    }
}
