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
    /// Interaction logic for Button2_SkillCheck.xaml
    /// </summary>
    public partial class Button2_SkillCheck : Window
    {
        public Button2_SkillCheck()
        {
            InitializeComponent();
            SetupBar();
        }

        double successBorderStart { get; set; }
        double successBorderEnd { get; set; }
        double needleStart { get; set; }
        double needleEnd { get; set; }
        double needleSpeed { get; set; }
        double barStart { get; set; }
        double barEnd { get; set; }
        bool spacebarPressed { get; set; }
        bool SkillCheckStart { get; set; }

        void SetupBar()
        {
            barStart = Canvas.GetLeft(mainSkillBar);
            barEnd = barStart + mainSkillBar.ActualWidth;
        }

        // Resets the entire skill-check system back to what it was before.
        public void Needle_Reset(object sender, RoutedEventArgs e)
        {
            RandomizeSuccessBarPosition();
            Canvas.SetLeft(needle, barStart);
            successBorderStart = Canvas.GetLeft(successZone);
            successBorderEnd = successBorderStart + successZone.ActualWidth;
            needleStart = Canvas.GetLeft(needle);
            needleEnd = needleStart + needle.ActualWidth;
            spacebarPressed = false;
            SkillCheckStart = false;
            Background = Brushes.White;
            endSkillPopup.Visibility = Visibility.Hidden;
            successZone.Visibility = Visibility.Hidden;
            if (randomRadioWidth.IsChecked == true) { RandomizeSuccessZoneWidth(); }
            if (randomRadioSpeed.IsChecked == true) { RandomizeNeedleSpeed(); }
        }

        // Begins the skill-check.
        public async void StartSkillCheck(object sender, RoutedEventArgs e)
        {
            successZone.Visibility = Visibility.Visible;
            NeedleReseter.Visibility = Visibility.Hidden;
            SkillCheckStart = true;

            while (spacebarPressed == false)
            {
                Dispatcher.Invoke(() => Canvas.SetLeft(needle, Canvas.GetLeft(needle) + needleSpeed));
                await Task.Delay(1);
            }

            NeedleReseter.Visibility = Visibility.Visible;
            successBorderStart = Canvas.GetLeft(successZone);
            successBorderEnd = successBorderStart + successZone.ActualWidth;
            needleStart = Canvas.GetLeft(needle);
            needleEnd = needleStart + needle.ActualWidth;

            if (needleStart >= successBorderStart && needleStart <= successBorderEnd)
            {
                Background = Brushes.Blue;
                endSkillPopup.Visibility = Visibility.Visible;
                endSkillPopup.Text = "You've got skills!";
            }
            else
            {
                Background = Brushes.Red;
                endSkillPopup.Visibility = Visibility.Visible;
                endSkillPopup.Text = "You've got no skills!";
            }
        }

        private void runSkillCheck_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space) { spacebarPressed = true; }
        }

        // Obvious method is obvious.
        public void RandomizeSuccessBarPosition()
        {
            Random roll = new Random();
            double randomPosition = roll.NextDouble();
            double barWidth = mainSkillBar.ActualWidth;
            double newPosition = barStart + randomPosition * barWidth;
            Canvas.SetLeft(successZone, newPosition);
            successBorderStart = newPosition;
            successBorderEnd = newPosition + successZone.ActualWidth;
            successZone.Visibility = Visibility.Visible;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (easyRadioWidth.IsChecked == true) { successZone.Width = 45; }
            else if (normalRadioWidth.IsChecked == true) { successZone.Width = 25; }
            else if (hardRadioWidth.IsChecked == true) { successZone.Width = 10; }
            else if (randomRadioWidth.IsChecked == true) { RandomizeSuccessZoneWidth(); }

            if (easyRadioSpeed.IsChecked == true) { needleSpeed = 1.5; }
            else if (normalRadioSpeed.IsChecked == true) { needleSpeed = 2.5; }
            else if (hardRadioSpeed.IsChecked == true) { needleSpeed = 4; }
            else if (randomRadioSpeed.IsChecked == true) { RandomizeNeedleSpeed(); }
        }

        public void RandomizeSuccessZoneWidth()
        {
            Random roll = new Random();
            successZone.Width = roll.Next(3, 55);
        }

        public void RandomizeNeedleSpeed()
        {
            Random roll = new Random();
            needleSpeed = roll.Next(1, 4);
        }
    }
}
