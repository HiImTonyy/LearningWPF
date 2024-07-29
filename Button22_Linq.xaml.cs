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
    /// Interaction logic for Button22_Linq.xaml
    /// </summary>
    public partial class Button22_Linq : Window
    {
        List<int> mainList;
        public Button22_Linq()
        {
            InitializeComponent();

            mainList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 23, 24, 94, 95, 110, 112};
        }

        public string turnToString(List<int> inList)
        {
            string add = "";

            foreach(int item in inList)
            {
                add += item.ToString() + ",";

                if(item == inList.Last())
                    add = add.TrimEnd(',');
            }
            return add;
        }

        public string FilterListOddNumbers(List<int> inList)
        {
            return turnToString(inList.Where(i => (i % 2) != 0).ToList());
        }
        public string FilterListEvenNumbers(List<int> inList)
        {
            return turnToString(inList.Where(i => (i % 2) == 0).ToList());
        }

        private void Even_Click(object sender, RoutedEventArgs e)
        {
            mainTextBlock.Text = FilterListEvenNumbers(mainList);
        }

        private void Odd_Click(object sender, RoutedEventArgs e)
        {
            mainTextBlock.Text = FilterListOddNumbers(mainList);
        }

        private void RemoveFilter_Click(object sender, RoutedEventArgs e)
        {
            mainTextBlock.Text = turnToString(mainList);
        }
    }
}
