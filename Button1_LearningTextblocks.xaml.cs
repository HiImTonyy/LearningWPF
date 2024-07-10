using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// Interaction logic for Button1_LearningTextblocks.xaml
    /// </summary>
    public partial class Button1_LearningTextblocks : Window
    {
        public int pissCount = 0;
        public bool isDead = false;
        public Button1_LearningTextblocks()
        {
            InitializeComponent();
        }

        private async void Hyperlink_ClickButton(object sender, RoutedEventArgs e)
        {
            if (isDead == false) { piss.FontSize += 1; }

            pissCount++;

            if (pissCount == 15) { piss.Text = "There are no easter eggs here."; piss.FontSize -= 15; }
            else if (pissCount == 20) { piss.Text = "Nope, nothing at all."; piss.FontSize -= 5; }
            else if (pissCount == 35) { piss.Text = "What the hell are you doing?"; piss.FontSize -= 15; }
            else if (pissCount == 40) { piss.Text = "STOP YOU FOOL!"; piss.FontSize -= 5; piss.Foreground = Brushes.Red; }
            else if (pissCount == 55) { piss.Text = "YOU'RE KILLING ME!!!"; piss.FontSize -= 15; piss.Foreground = Brushes.Red; }
            else if (pissCount == 60) { piss.Text = "AHHH!!!!!"; piss.FontSize -= 5; piss.Foreground = Brushes.Red; }
            else if (pissCount == 63 && isDead == false) { piss.Text = "~corpse~"; piss.FontSize -= 3; piss.Foreground = Brushes.DarkGray; isDead = true; }
            else if (pissCount == 80)
            {
                Background = Brushes.DarkRed;
                MainStackPanal.Width = 666;
                piss.Text = "IT KNOWS. IT WILL COME FOR YOU. YOU WILL BE A CORPSE TOO.";
                Text1.Text = "IT KNOWS. IT WILL COME FOR YOU. YOU WILL BE A CORPSE TOO.";
                Text2.Text = "IT KNOWS. IT WILL COME FOR YOU. YOU WILL BE A CORPSE TOO.";
                Text3.Text = "IT KNOWS. IT WILL COME FOR YOU. YOU WILL BE A CORPSE TOO.";
                Text4.Text = "IT KNOWS. IT WILL COME FOR YOU. YOU WILL BE A CORPSE TOO.";
                Text5.Text = "IT KNOWS. IT WILL COME FOR YOU. YOU WILL BE A CORPSE TOO.";
                Text6.Text = "IT KNOWS. IT WILL COME FOR YOU. YOU WILL BE A CORPSE TOO.";
                piss.FontWeight = FontWeights.UltraBold;
                Text1.FontWeight = FontWeights.UltraBold;
                Text2.FontWeight = FontWeights.UltraBold;
                Text3.FontWeight = FontWeights.UltraBold;
                Text4.FontWeight = FontWeights.UltraBold;
                Text5.FontWeight = FontWeights.UltraBold;
                Text6.FontWeight = FontWeights.UltraBold;
                piss.FontSize = 17;
                Text1.FontSize = 17;
                Text2.FontSize = 17;
                Text3.FontSize = 17;
                Text4.FontSize = 17;
                Text5.FontSize = 17;
                Text6.FontSize = 17;
                SpookyThing();
            }
        }
        public async void SpookyThing()
        {
            while (piss.FontSize < 20)
            {
                await Task.Delay(50);

                piss.FontSize ++;
                Text1.FontSize ++;
                Text2.FontSize ++;
                Text3.FontSize ++;
                Text4.FontSize ++;
                Text5.FontSize ++;
                Text6.FontSize ++;
            }
            while (piss.FontSize > 17)
            {
                await Task.Delay(50);

                piss.FontSize--;
                Text1.FontSize--;
                Text2.FontSize--;
                Text3.FontSize--;
                Text4.FontSize--;
                Text5.FontSize--;
                Text6.FontSize--;
            }
            SpookyThing();
        }
    }
}
