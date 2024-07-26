﻿using Microsoft.Win32;
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
using System.IO;


namespace LearningWPF
{
    /// <summary>
    /// Interaction logic for Button14_OpenFile.xaml
    /// </summary>
    public partial class Button14_OpenFile : Window
    {
        public Button14_OpenFile()
        {
            InitializeComponent();
        }

        private void openFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true) 
            {
                mainTextBox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }
    }
}
