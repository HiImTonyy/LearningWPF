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

            mainList = new List<int> { 1, 5, 3, 6, 5, 6, 7, 8, 2, 10, 23, 24, 94, 195, 1110, 1112};
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

        public List<int> FilterListOddNumbers(List<int> inList)
        {
            return (inList.Where(i => (i % 2) != 0).ToList());
        }
        public List<int> FilterListEvenNumbers(List<int> inList)
        {
            return (inList.Where(i => (i % 2) == 0).ToList());
        }

        private void Even_Click(object sender, RoutedEventArgs e)
        {
            mainList = FilterListEvenNumbers(mainList);

            mainTextBlock.Text = turnToString(mainList);
        }

        private void Odd_Click(object sender, RoutedEventArgs e)
        {
            mainList = FilterListOddNumbers(mainList);

            mainTextBlock.Text = turnToString(mainList);
        }

        private void RemoveFilter_Click(object sender, RoutedEventArgs e)
        {
            mainList = new List<int> { 1, 5, 3, 6, 5, 6, 7, 8, 2, 10, 23, 24, 94, 195, 1110, 1112 };

            mainTextBlock.Text = turnToString(mainList);
        }

        public List<int> SortAscending(List<int> inList)
        {
            return mainList.OrderBy(i => i).ToList();
        }

        public List<int> SortDescending(List<int> inList)
        {
            return mainList.OrderByDescending(i => i).ToList();
        }

        private void Ascend_Click(object sender, RoutedEventArgs e)
        {
            mainList = SortAscending(mainList);

            mainTextBlock.Text = turnToString(mainList);
        }

        private void Descend_Click(object sender, RoutedEventArgs e)
        {
            mainList = SortDescending(mainList);

            mainTextBlock.Text = turnToString(mainList);
        }
    }
}
