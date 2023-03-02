using BeautyApplication.Views.Pages;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace BeautyApplication
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new MainPage());


            KeyDown += (s, e) => {
                if (e.Key == Key.F1)
                {
                    string filename = $"{AppDomain.CurrentDomain.BaseDirectory}help.pdf";
                    if (File.Exists(filename))
                    {
                        MainWebFrame.Visibility = Visibility.Visible;
                        MainWebFrame.Navigate(filename);
                        this.Title = "Руководство пользователя";
                        StatusTextBlock.Text = "Для выхода из справки нажмите ESC";
                    }
                    
                }
                if (e.Key == Key.Escape)
                {
                    MainWebFrame.Visibility = Visibility.Collapsed;
                    this.Title = "Салон красоты";
                    StatusTextBlock.Text = String.Empty;
                }
            };
        }
        /// <summary>
        /// Переход на авторизацию
        /// </summary>
        private void LogInTextBlockMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new AuthPage());
            LogInTextBlock.Visibility = Visibility.Collapsed;
        }

        private void MainFrameNavigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
