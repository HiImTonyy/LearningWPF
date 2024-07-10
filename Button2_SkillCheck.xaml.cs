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
        }

        double successBorderStart = 4.4;
        double successBorderEnd = 4.4;
        double needleStart = 1.1;
        double needleEnd = 1.1;

        private void Needle_Reset(object sender, RoutedEventArgs e)
        {
            Background = Brushes.White;
            successBorderStart = 4.4;
            successBorderEnd = 4.4;
            needleStart = 1.1;
            needleEnd = 1.1;
        }

        private void NeedleChecker_Click(object sender, RoutedEventArgs e)
        {
            if (needleStart >= successBorderStart && needleStart <= successBorderEnd)
            {
                Background = Brushes.AliceBlue;
            }
        }

        public void setNeedleSuccess_Click(object sender, RoutedEventArgs e)
        {
            successBorderStart = 4.4;
            successBorderEnd = 7.5;
            needleStart = 4.9;
            needleEnd = 7.2;
        }
    }


    /*      successBorderStart = Canvas.GetLeft(successZone);
            successBorderEnd = successBorderStart + successZone.ActualWidth;
            needleStart = Canvas.GetLeft(needle);
            needleEnd = needleStart + needle.ActualWidth;
    */
}
