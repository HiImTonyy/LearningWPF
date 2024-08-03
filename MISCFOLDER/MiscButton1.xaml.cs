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

namespace LearningWPF.MISCFOLDER
{
    /// <summary>
    /// Interaction logic for MiscButton1.xaml
    /// </summary>
    public partial class MiscButton1 : Window
    {
        public MiscButton1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Human bozo = new Human("Tony", "Ciproni", "White", "Male", 33, 220, 205);

            firstNameLbl.Content = bozo.Name;
            lastNameLbl.Content = bozo.LastName;
            skinColorLbl.Content = bozo.SkinColor;
            GenderLbl.Content = bozo.Gender;
            ageLbl.Content = bozo.Age.ToString();
            weightLbl.Content = bozo.Weight.ToString() + " Pounds";
            heightLbl.Content = bozo.Height.ToString() + " CM";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Human bozo1 = new Human("Cynthia", "Rosemerry", "White", "Female", 27, 155, 193);

            firstNameLbl.Content = bozo1.Name;
            lastNameLbl.Content = bozo1.LastName;
            skinColorLbl.Content = bozo1.SkinColor;
            GenderLbl.Content = bozo1.Gender;
            ageLbl.Content = bozo1.Age.ToString();
            weightLbl.Content = bozo1.Weight.ToString() + " Pounds";
            heightLbl.Content = bozo1.Height.ToString() + " CM";
        }
    }
}
