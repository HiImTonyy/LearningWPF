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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LearningWPF
{
    /// <summary>
    /// Interaction logic for ValueUC.xaml
    /// </summary>
    public partial class ValueUC : UserControl
    {
        public delegate void OnMinNumberReached(object sender, RoutedEventArgs e);
        public event OnMinNumberReached MinNumberReached;
        public ValueUC()
        {
            InitializeComponent();
        }

        private void Plus_Button_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text = (Int32.Parse(mainTextBox.Text) + 10).ToString();
        }

        private void Minus_Button_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text = (Int32.Parse(mainTextBox.Text) - 10).ToString();
        }

        private void mainTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(Int32.Parse((sender as TextBox).Text) < 0) 
            {
                (sender as TextBox).Text = "0";
                MinNumberReached(sender, e);
            }
        }
    }
}
