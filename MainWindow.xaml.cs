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
                    mainText.Text = "Learned about the expander.";
                    break;
                case "Button8":
                    mainText.Text = "Learned more about using the grid.";
                    break;
                case "Button9":
                    mainText.Text = "Learned more about the stackpanal as well as what the wrap-panel does.";
                    break;
                case "Button10":
                    mainText.Text = "Learned a bit about the dockpanel.";
                    break;
                case "Button11":
                    mainText.Text = "A randomized version of a simon game. you must click the correct buttons that light up which lights up randomly. it gets harder with each round.";
                    break;
                case "Button12":
                    mainText.Text = "Learned a tiny amount of the Menu Control.";
                    break;
                case "Button13":
                    mainText.Text = "Learned a bit about the toolbar, context menu, and progress bar.";
                    break;
                case "Button14":
                    mainText.Text = "Learned about how to open and save a file.";
                    break;
                case "Button15":
                    mainText.Text = "Learned a bit more about databinding.";
                    break;
                case "Button16":
                    mainText.Text = "Learned a bit about the combobox.";
                    break;
                case "Button17":
                    mainText.Text = "Learned a bit about databinding classes. Binded a list from a class and also added colors depending on the rarity.";
                    break;
                case "Button18":
                    mainText.Text = "Learned a bit about page navigation.";
                    break;
                case "Button19":
                    mainText.Text = "Learned a bit about delegates and events while also learning nothing.";
                    break;
                case "Button20":
                    mainText.Text = "Finally to something actually fun!";
                    break;
                case "Button21":
                    mainText.Text = "Instead of using XAML, the animations will be played using CSharp.";
                    break;
                case "Button22":
                    mainText.Text = "Learned a bit of linq to sort through numbers based on even numbers, odd numbers, or descending and ascending numbers.";
                    break;
            }
        }

        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            mainText.Visibility = Visibility.Hidden;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
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
                case "Button8":
                    Button8_Grid Button8_Grid = new Button8_Grid();
                    await Task.Delay(195);
                    Button8_Grid.ShowDialog();
                    break;
                case "Button9":
                    Button9_Stackpanel Button9_Stackpanel = new Button9_Stackpanel();
                    Button9_Stackpanel.ShowDialog();
                    break;
                case "Button10":
                    Button10_Dockpanel Button10_Dockpanel = new Button10_Dockpanel();
                    Button10_Dockpanel.ShowDialog();
                    break;
                case "Button11":
                    Button11_Simon Button11_Simon = new Button11_Simon();
                    Button11_Simon.ShowDialog();
                    break;
                case "Button12":
                    Button12_MenuControl Button12_MenuControl = new Button12_MenuControl();
                    Button12_MenuControl.ShowDialog();
                    break;
                case "Button13":
                    Button13_Toolbar Button13_Toolbar = new Button13_Toolbar();
                    Button13_Toolbar.ShowDialog();
                    break;
                case "Button14":
                    Button14_OpenFile Button14_OpenFile = new Button14_OpenFile();
                    Button14_OpenFile.ShowDialog();
                    break;
                case "Button15":
                    Button15_Databinding2 Button15_Databinding2 = new Button15_Databinding2();
                    Button15_Databinding2.ShowDialog();
                    break;
                case "Button16":
                    Button16_DatabindingCombo Button16_DatabindingCombo = new Button16_DatabindingCombo();
                    Button16_DatabindingCombo.ShowDialog();
                    break;
                case "Button17":
                    Button17_DatabindListToClass Button17_DatabindListToClass = new Button17_DatabindListToClass();
                    Button17_DatabindListToClass.ShowDialog();
                    break;
                case "Button18":
                    Button18_PageNavigation Button18_PageNavigation = new Button18_PageNavigation();
                    Button18_PageNavigation.ShowDialog();
                    break;
                case "Button19":
                    Button19_DelegatesAndEvents Button19_DelegatesAndEvents = new Button19_DelegatesAndEvents();
                    Button19_DelegatesAndEvents.ShowDialog();
                    break;
                case "Button20":
                    Button20_Animations Button20_Animations = new Button20_Animations();
                    Button20_Animations.ShowDialog();
                    break;
                case "Button21":
                    Button21_CSharpAnimations Button21_CSharpAnimations = new Button21_CSharpAnimations();
                    Button21_CSharpAnimations.ShowDialog();
                    break;
                case "Button22":
                    Button22_Linq Button22_Linq = new Button22_Linq();
                    Button22_Linq.ShowDialog();
                    break;
            }
        }
    }
}
