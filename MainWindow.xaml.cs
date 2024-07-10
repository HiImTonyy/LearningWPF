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
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LearningWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        double successBorderStart = 4.4;
        double successBorderEnd = 4.4;
        double needleStart = 1.1;
        double needleEnd = 1.1;
        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            mainText.Visibility = Visibility.Visible;

            switch (button.Name)
            {
                case "Button1":
                    mainText.Text = "I learned about the many different types of XAML 'code' that you can use to spice up the textblocks. I guess me learning about HTML and CSS all those months ago didn't go to waste!";
                    break;
                case "Button2":
                    mainText.Text = "It's been practically a month since I last did anything according to my GitHub, but I've actually been working on a typing test here and there. not EVERYDAY mind you, but... yeah. I thought it " +
                        "would be easy, but it isn't really. I got the coloring down, so when you type a wrong character, then the word turns red. I also have it randomly generate words and also made it so that you HAVE to type the word correctly, " +
                        "but.. yeah. I wanted it in a specific way, but got a tad bit over-whelemed. this is more so for myself in the future because I doubt anyone will see this, but.. eh, if you are some recuriter then I hope you have a pretty good " +
                        "day. life is a big o'l bitch at times, but you gotta keep your head held high and move forward. light will always appear in the dark eventually and you just gotta move ahead to find it. believe, and you will succeed!";
                    break;
            }
        }

        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            mainText.Visibility = Visibility.Hidden;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Button1_LearningTextblocks button1_LearningTextblocks = new Button1_LearningTextblocks();
            button1_LearningTextblocks.ShowDialog();
        }

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
