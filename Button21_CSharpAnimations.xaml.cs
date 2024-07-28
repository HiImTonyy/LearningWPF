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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LearningWPF
{
    /// <summary>
    /// Interaction logic for Button21_CSharpAnimations.xaml
    /// </summary>
    public partial class Button21_CSharpAnimations : Window
    {
        public bool mouseEntered = false;
        public Button21_CSharpAnimations()
        {
            InitializeComponent();
        }

        private void StackPanel_Loaded(object sender, RoutedEventArgs e)
        {
            DoubleAnimation firstAnimation = new DoubleAnimation();
            firstAnimation.Duration = TimeSpan.FromSeconds(2);
            firstAnimation.From = 0;
            firstAnimation.To = 1;
            mainLabel.BeginAnimation(StackPanel.OpacityProperty, firstAnimation);
        }

        private void StackPanel_MouseEnter(object sender, MouseEventArgs e)
        {
            if (mouseEntered == false)
            {
                ThicknessAnimation hoverAnimation = new ThicknessAnimation();
                hoverAnimation.Duration = TimeSpan.FromSeconds(2);
                hoverAnimation.From = new Thickness(1);
                hoverAnimation.To = new Thickness(5);
                mainLabel.BeginAnimation(Control.BorderThicknessProperty, hoverAnimation);
                mainLabel.Content = "wow!";

                ThicknessAnimation moveAnimation = new ThicknessAnimation();
                moveAnimation.Duration = TimeSpan.FromSeconds(0.5);
                moveAnimation.From = new Thickness(45, 380, 0, 0);
                moveAnimation.To = new Thickness(145, 10, 0, 0);
                mainButton.BeginAnimation(Control.MarginProperty, moveAnimation);
                mouseEntered = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ThicknessAnimation moveAnimation = new ThicknessAnimation();
            moveAnimation.Duration = TimeSpan.FromSeconds(0.5);
            moveAnimation.From = new Thickness(1, 380, 0, 0); ;
            moveAnimation.To = new Thickness(-180, 10, 0, 0);
            secondButton.BeginAnimation(Control.MarginProperty, moveAnimation);
            secondButton.Width = 130;
        }

        private void secondButton_Click(object sender, RoutedEventArgs e)
        {
            ThicknessAnimation moveAnimation = new ThicknessAnimation();
            moveAnimation.Duration = TimeSpan.FromSeconds(0.5);
            moveAnimation.From = new Thickness(-180, 10, 0, 0); 
            moveAnimation.To = new Thickness(1, -10, 40, 130);
            secondButton.BeginAnimation(Control.MarginProperty, moveAnimation);
            secondButton.Width = 130;

            ThicknessAnimation lastAnimation = new ThicknessAnimation();
            lastAnimation.Duration = TimeSpan.FromSeconds(7);
            mainLabel.Content = "O-O";
            mainButton.Content = "O-O";
            secondButton.Content = "O-O";
            lastAnimation.From = new Thickness(0, 0, 0, 0);
            lastAnimation.To = new Thickness(30, 100, -44, 69);
            mainLabel.BeginAnimation(Control.MarginProperty, lastAnimation);
        }
    }
}
