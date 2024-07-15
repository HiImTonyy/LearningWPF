﻿using System;
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
    /// Interaction logic for Button7_Expander.xaml
    /// </summary>
    public partial class Button7_Expander : Window
    {
        public Button7_Expander()
        {
            InitializeComponent();
        }

        private void Expander_Expanded(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Transparent;
        }

        private void Expander_Collapsed(object sender, RoutedEventArgs e)
        {
            Background = Brushes.White;
        }
    }
}
