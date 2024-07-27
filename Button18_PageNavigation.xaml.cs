using LearningWPF.PageNavigationPages;
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
using System.Windows.Shapes;

namespace LearningWPF
{
    /// <summary>
    /// Interaction logic for Button18_PageNavigation.xaml
    /// </summary>
    public partial class Button18_PageNavigation : Window
    {
        public Page1 FirstPage;
        public Page2 SecondPage;
        public Button18_PageNavigation()
        {
            InitializeComponent();
            FirstPage = new Page1();
            SecondPage = new Page2();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = FirstPage;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = SecondPage;
        }

        private void Forward_Button_Click(object sender, RoutedEventArgs e)
        {
            if (MainWindowFrame.NavigationService.CanGoBack)
            {
                MainWindowFrame.NavigationService.GoBack();
            }
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            if (MainWindowFrame.NavigationService.CanGoForward)
            {
                MainWindowFrame.NavigationService.GoForward();
            }
        }
    }
}
