using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Interaction logic for Button5_Buttons.xaml
    /// </summary>
    public partial class Button5_Buttons : Window
    {
        public Button5_Buttons()
        {
            InitializeComponent();
        }

        bool buttonPressed = false;
        private async void ClickButton(object sender, RoutedEventArgs e)
        {
            if (buttonPressed)
            {
                Background = Brushes.LightGoldenrodYellow;
                mainButton.Visibility = Visibility.Hidden;
                mainText.Foreground = Brushes.Goldenrod;
                mainText.FontWeight = FontWeights.Light;
                mainText.FontSize = 37;
                mainText.Text = "I never knew you: depart from me, ye that work iniquity!";
                mainText.Visibility = Visibility.Visible;
                await Task.Delay(2000);
                mainText.Visibility = Visibility.Hidden;
                Background = Brushes.White;
                mainButton.Visibility = Visibility.Visible;
            }
            else
            {
                buttonPressed = true;
                mainText.Foreground = Brushes.Black;
                mainButton.Visibility = Visibility.Hidden;
                await Task.Delay(2000);
                mainText.Visibility = Visibility.Visible;
                mainText.Text = "You really did it now..";
                await Task.Delay(1500);
                mainText.Text = "Do you feel proud of yourself?";
                await Task.Delay(1500);
                mainText.Text = "I bet you do.";
                await Task.Delay(1500);
                mainText.Visibility = Visibility.Hidden;
                await Task.Delay(2500);
                mainText.Visibility = Visibility.Visible;
                mainText.Foreground = Brushes.Red;
                Background = Brushes.Black;
                mainText.Text = "You will never be forgiven.";
                await Task.Delay(1000);
                mainText.Visibility = Visibility.Hidden;
                Background = Brushes.White;
                mainButton.Visibility = Visibility.Visible;
            }
        }
    }
}
