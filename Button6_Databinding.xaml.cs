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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Net.WebRequestMethods;

namespace LearningWPF
{
    /// <summary>
    /// Interaction logic for Button6_Databinding.xaml
    /// </summary>
    public partial class Button6_Databinding : Window
    {
        public Button6_Databinding()
        {
            InitializeComponent();
        }

        public bool movedSlider = false;

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            sliderValueText.Text = slider.Value.ToString();
            if (slider.Value >= 10) { movedSlider = true; }
            if (movedSlider == true && slider.Value == 0) { changeImage(); }
        }

        public void changeImage()
        {
            movedSlider = false;
            Random roll = new Random();
            int chooseImage = roll.Next(1, 11);

            if (chooseImage == 1) { mainImage.Source = new BitmapImage(new Uri("https://static.wikia.nocookie.net/nextbot/images/8/8f/Delgado.png/revision/latest?cb=20230807161930")); }
            else if (chooseImage == 2) { mainImage.Source = new BitmapImage(new Uri("https://static.wikia.nocookie.net/nicos-nextbots/images/1/18/ObungaDecal.png/revision/latest?cb=20221002013859")); }
            else if (chooseImage == 3) { mainImage.Source = new BitmapImage(new Uri("https://static.wikia.nocookie.net/nicos-nextbots/images/0/04/AngryMunci_In-Game_Image.png/revision/latest?cb=20231205004432")); }
            else if (chooseImage == 4) { mainImage.Source = new BitmapImage(new Uri("https://static.wikia.nocookie.net/nicos-nextbots/images/2/25/OG_Sanic.webp/revision/latest?cb=20230921204945")); }
            else if (chooseImage == 5) { mainImage.Source = new BitmapImage(new Uri("https://static.wikia.nocookie.net/nicos-nextbots/images/d/dc/AhenoHD.png/revision/latest?cb=20240328053903")); }
            else if (chooseImage == 6) { mainImage.Source = new BitmapImage(new Uri("https://i.imgflip.com/vw1ap.jpg")); }
            else if (chooseImage == 7) { mainImage.Source = new BitmapImage(new Uri("https://yt3.googleusercontent.com/U31WiQirHiujmEXmv-WHGOrVnPH1JYPoZ0SjJqcLiUL5NC7eb7LmTDKkc_CbeAY0v2PpGrh3NA=s900-c-k-c0x00ffffff-no-rj")); }
            else if (chooseImage == 8) { mainImage.Source = new BitmapImage(new Uri("https://img2.wtftime.ru/store/2020/10/22/3uLZ9553_amp_wide.jpg")); }
            else if (chooseImage == 9) { mainImage.Source = new BitmapImage(new Uri("https://img.pr0gramm.com/2019/09/07/db5d2a4ff8413dbd.jpg")); }
            else if (chooseImage == 10) { mainImage.Source = new BitmapImage(new Uri("https://ih1.redbubble.net/image.3187955220.2123/bg,f8f8f8-flat,750x,075,f-pad,750x1000,f8f8f8.u2.jpg")); }
        }
    }
}
