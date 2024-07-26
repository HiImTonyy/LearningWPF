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

        private void AddWord(object sender, RoutedEventArgs e)
        {
            avalibleNumbers.Add(1);
        }

        private void DeleteWord(object sender, RoutedEventArgs e)
        {
            avalibleNumbers.RemoveAt(0);
        }
    }
}
