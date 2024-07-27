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
    /// Interaction logic for Button19_DelegatesAndEvents.xaml
    /// </summary>
    public partial class Button19_DelegatesAndEvents : Window
    {
        public Button19_DelegatesAndEvents()
        {
            InitializeComponent();
            mainValue.MinNumberReached += mainValueMinNumberReached;
        }

        private void mainValueMinNumberReached(object sender, EventArgs e)
        {
            MessageBox.Show("There are no numbers less thean 0. they do not exist.");
        }
    }
}
