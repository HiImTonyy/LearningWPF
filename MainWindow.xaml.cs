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
        bool turnTextOn = false;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            mainText.Visibility = Visibility.Visible;

            switch(button.Name)
            {
                case "Button1":
                    mainText.Text = "This is just random text to show the description of whatever it is I'll be learning. I've noticed that in some things they ask you to do this and that, then erase the file and start a new one." +
                        " I hate that so I'm doing a proper menu where you can click on a specific thing I learned.. so once you click on the button, it'll open up a new window. CRAZY.";
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
    }
}
