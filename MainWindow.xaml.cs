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
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LearningWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            mainText.Visibility = Visibility.Visible;

            switch (button.Name)
            {
                case "Button1":
                    mainText.Text = "I learned about the many different types of XAML 'code' that you can use to spice up the textblocks. I guess me learning about HTML and CSS all those months ago didn't go to waste!";
                    break;
                case "Button2":
                    mainText.Text = "I created a simple skill-check thing for the fun of it. The goal is to press spacebar when the needle gets inside the green success zone. you can also change the speed of the needle, as well as the width of the sucess zone.";
                    break;
                case "Button3":
                    mainText.Text = "Learned a little about Labels. more 'advanced' stuff will be in the next few buttons, whenever that is.";
                    break;
                case "Button4":
                    mainText.Text = "Learned a little about the Textbox. I should probably put these sorts of small things in its own button, but I mean... it is what it is. I made a skill-check thing just for the hell of it, so if I get bored then I'll probably just make something else on the side while learning. again, it is what it is.";
                    break;
                case "Button5":
                    mainText.Text = "Well. uh.. I didn't really learn a whole lot of new things with this one to be honest, but I still made something out of it.";
                    break;
                case "Button6":
                    mainText.Text = "Learned about the slider and a bit of data-binding. You can move the slider up and down to resize the image displayed. the image also changes randomly when sliding it to 0.";
                    break;
                case "Button7":
                    mainText.Text = "???";
                    break;
            }
        }

        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            mainText.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var buttonClick = sender as Button;
            mainText.Visibility = Visibility.Visible;

            switch (buttonClick.Name)
            {
                case "Button1":
                    Button1_LearningTextblocks button1_LearningTextblocks = new Button1_LearningTextblocks();
                    button1_LearningTextblocks.ShowDialog();
                    break;
                case "Button2":
                    Button2_SkillCheck button2_SkillCheck = new Button2_SkillCheck();
                    button2_SkillCheck.ShowDialog();
                    break;
                case "Button3":
                    Button3_Labels button3_Labels = new Button3_Labels();
                    button3_Labels.ShowDialog();
                    break;
                case "Button4":
                    Button4_TextBox Button4_TextBox = new Button4_TextBox();
                    Button4_TextBox.ShowDialog();
                    break;
                case "Button5":
                    Button5_Buttons Button5_Buttons = new Button5_Buttons();
                    Button5_Buttons.ShowDialog();
                    break;
                case "Button6":
                    Button6_Databinding Button6_Databinding = new Button6_Databinding();
                    Button6_Databinding.ShowDialog();
                    break;
                case "Button7":
                    Button7_Expander Button7_Expander = new Button7_Expander();
                    Button7_Expander.ShowDialog();
                    break;
            }
        }
    }
}
