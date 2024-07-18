using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for Button11_Simon.xaml
    /// </summary>
    public partial class Button11_Simon : Window
    {
        public Button11_Simon()
        {
            InitializeComponent();
            RoundStart();
        }

        public int counter = 1;
        public int round = 1;
        public int numberCheck = 0;

        public List<int> lightedUpButtons = new List<int>();
        public List<int> userSelectedButtons = new List<int>();

        public async void RoundStart()
        {
            while (counter > 0)
            {
                decision.Text = "Randomizing buttons...";
                await Task.Delay(1500);
                Random roll = new Random();
                int number = roll.Next(1, 5);

                switch (number)
                {
                    case 1:
                        topButton.Background = Brushes.LightYellow;
                        await Task.Delay(350);
                        topButton.Background = Brushes.Yellow;
                        lightedUpButtons.Add(1);
                        counter--;
                        numberCheck++;
                        break;
                    case 2:
                        rightButton.Background = Brushes.LightGreen;
                        await Task.Delay(830);
                        rightButton.Background = Brushes.Green;
                        lightedUpButtons.Add(2);
                        counter--;
                        numberCheck++;
                        break;
                    case 3:
                        bottomButton.Background = Brushes.Pink;
                        await Task.Delay(350);
                        bottomButton.Background = Brushes.HotPink;
                        lightedUpButtons.Add(3);
                        counter--;
                        numberCheck++;
                        break;
                    case 4:
                        leftButton.Background = Brushes.LightBlue;
                        await Task.Delay(350);
                        leftButton.Background = Brushes.Blue;
                        lightedUpButtons.Add(4);
                        numberCheck++;
                        counter--;
                        break;
                }
            }

            decision.Text = "";
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            numberCheck--;

            switch (button.Name)
            {
                case "topButton":
                    userSelectedButtons.Add(1);
                    break;
                case "rightButton":
                    userSelectedButtons.Add(2);
                    break;
                case "bottomButton":
                    userSelectedButtons.Add(3);
                    break;
                case "leftButton":
                    userSelectedButtons.Add(4);
                    break;
            }

            if (numberCheck == 0)
            {
                if (userSelectedButtons.SequenceEqual(lightedUpButtons))
                {
                    decision.Text = "Correct!";
                    await Task.Delay(950);
                    decision.Text = "";
                    userSelectedButtons.Clear();
                    lightedUpButtons.Clear();
                    round++;
                    counter = round;
                    roundText.Text = " Round: " + round.ToString();  
                    RoundStart();
                }
                else
                {
                    decision.Text = "Incorrect!";
                    await Task.Delay(1950);
                    counter = 1;
                    round = 1;
                    numberCheck = 0;
                    userSelectedButtons.Clear();
                    lightedUpButtons.Clear();
                    decision.Text = "";
                    roundText.Text = " Round: " + round.ToString();
                    RoundStart();
                }
            }
        }

        public void Failure()
        {
            counter = 1;
            round = 1;
            numberCheck = 0;
            userSelectedButtons.Clear();
            lightedUpButtons.Clear();
            decision.Text = "";
            roundText.Text = " Round: " + round.ToString();
            RoundStart();
        }
    }
}
