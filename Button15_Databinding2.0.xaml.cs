using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Button15_Databinding2.xaml
    /// </summary>
    public partial class Button15_Databinding2 : Window
    {

        public int number = 10;
        public ObservableCollection<int> avalibleNumbers { get; set; }
        public Button15_Databinding2()
        {
            avalibleNumbers = new ObservableCollection<int>();
            int count = 0;

            for (int i = 0; i < 10; i++)
            {
                avalibleNumbers.Add(count++);
            }

            InitializeComponent();

            //this.DataContext = this;
        }

        private void AddNumber(object sender, RoutedEventArgs e)
        {
            avalibleNumbers.Add(number);
            number++;
        }

        private void DeleteNumber(object sender, RoutedEventArgs e)
        {
            avalibleNumbers.RemoveAt(0);
            number--;
        }
    }
}
