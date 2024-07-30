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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LearningWPF
{
    /// <summary>
    /// Interaction logic for PostOperationsUC.xaml
    /// </summary>
    public partial class PostOperationsUC : UserControl
    {

        public bool PostLiked { get; set; }
        public PostOperationsUC()
        {
            InitializeComponent();
        }

        public void LikePost()
        {
            Heart.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + @"\..\..\Icons\fillheart.png", UriKind.RelativeOrAbsolute));
            PostLiked = true;
        }
        public void UnlikePost()
        {
            Heart.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + @"\..\..\Icons\emptyheart.png", UriKind.RelativeOrAbsolute));
            PostLiked = false;
        }

        private void Heart_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(!PostLiked) { LikePost(); }
            else { UnlikePost(); }
        }
    }
}
