﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public List<int> lightedUpButtons = new List<int>();
        public List<int> userSelectedButtons = new List<int>();

        public async void RoundStart()
        {
            while (counter > 0)
            {
                await Task.Delay(1500);
                Random roll = new Random();
                int number = roll.Next(1, 5);

                switch (number)
                {
                    case 1:
                        topButton.Background = Brushes.LightYellow;
                        await Task.Delay(850);
                        topButton.Background = Brushes.Yellow;
                        lightedUpButtons.Add(1);
                        counter--;
                        break;
                    case 2:
                        rightButton.Background = Brushes.LightGreen;
                        await Task.Delay(850);
                        rightButton.Background = Brushes.Green;
                        lightedUpButtons.Add(2);
                        counter--;
                        break;
                    case 3:
                        bottomButton.Background = Brushes.Pink;
                        await Task.Delay(850);
                        bottomButton.Background = Brushes.HotPink;
                        lightedUpButtons.Add(3);
                        counter--;
                        break;
                    case 4:
                        leftButton.Background = Brushes.LightBlue;
                        await Task.Delay(850);
                        leftButton.Background = Brushes.Blue;
                        lightedUpButtons.Add(4);
                        counter--;
                        break;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;

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

            if (userSelectedButtons.SequenceEqual(lightedUpButtons)) { textt.Text = "win"; } else { textt.Text = "lose"; } 
        }
    }
}
