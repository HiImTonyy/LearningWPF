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
    /// Interaction logic for Button13_Toolbar.xaml
    /// </summary>
    public partial class Button13_Toolbar : Window
    {
        public Button13_Toolbar()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mainText.Text = string.Empty;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cBox = (ComboBox)sender;
            ComboBoxItem cbItem = (ComboBoxItem)cBox.SelectedItem;
            string newFontSize = (string)cbItem.Content;

            int temp;
            if(Int32.TryParse(newFontSize, out temp))
            {
                if (mainText != null) { mainText.FontSize = temp; }
            }
        }
    }
}
