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
        double barStart { get; set; }
        bool spacebarPressed { get; set; }
     

        public double needleStartupStart = 0.0;
        public double needleStartupEnd = 0.0;

        void SetupBar()
        {
            barStart = Canvas.GetLeft(mainSkillBar);
        }

        public void Needle_Reset(object sender, RoutedEventArgs e)
        {
            Canvas.SetLeft(needle, barStart);
            successBorderStart = Canvas.GetLeft(successZone);
            successBorderEnd = successBorderStart + successZone.ActualWidth;
            needleStart = Canvas.GetLeft(needle);
            needleEnd = needleStart + needle.ActualWidth;
            spacebarPressed = false;
            Background = Brushes.White;
            endSkillPopup.Visibility = Visibility.Hidden;
        }

        public async void StartSkillCheck(object sender, RoutedEventArgs e)
        {
            while (spacebarPressed == false)
            {
                Dispatcher.Invoke(() => Canvas.SetLeft(needle, Canvas.GetLeft(needle) + 2.2));
                await Task.Delay(25);
            }
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
    }
}
