using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Browser;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Navigation;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Windows.Media.Imaging;
using System.Text.RegularExpressions;
using System.Xaml;
using System.Windows.Resources;

namespace SilverlightApplication1.Views
{
    public partial class Home : Page
    {
        public static string ValueFromHome = "";
        public static string session = "logout";
        public Home()
        {
            InitializeComponent();
            icon3.Begin();
        }

        private void altmusik_Click(object sender, RoutedEventArgs e)
        {
            
            ValueFromHome = "altmusik";
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageDataDetail", UriKind.Absolute));
        }

        private void Aceh_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100,79,38,212);
            Aceh.Background = new SolidColorBrush(a); //ok
            Aceh.Foreground = new SolidColorBrush(a);
            Aceh.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/img_icon/IMG_MAP.png", 
                UriKind.Relative));
           
        }

        private void Aceh_MouseMove_1(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 252,2,2);
            Aceh.Background = new SolidColorBrush(a); //ok
            Aceh.Foreground = new SolidColorBrush(a);
            Aceh.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/peta/aceh1.png", 
                UriKind.Relative));
            
           
        }

        private void Sumut_MouseMove(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 252, 2, 2);
            Sumut.Background = new SolidColorBrush(a); //ok
            Sumut.Foreground = new SolidColorBrush(a);
            Sumut.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/peta/Sumut1.png", 
                UriKind.Relative));
        }

        private void Sumut_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 79, 38, 212);
            Sumut.Background = new SolidColorBrush(a); //ok
            Sumut.Foreground = new SolidColorBrush(a);
            Sumut.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/img_icon/IMG_MAP.png", 
                UriKind.Relative));
        }

        private void Riau_MouseMove(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 252, 2, 2);
            Riau.Background = new SolidColorBrush(a); //ok
            Riau.Foreground = new SolidColorBrush(a);
            Riau.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/peta/Riau1.png", 
                UriKind.Relative));
        }

        private void Riau_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 79, 38, 212);
            Riau.Background = new SolidColorBrush(a); //ok
            Riau.Foreground = new SolidColorBrush(a);
            Riau.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/img_icon/IMG_MAP.png", 
                UriKind.Relative));
        }

        private void Jambi_MouseMove(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 252, 2, 2);
            Jambi.Background = new SolidColorBrush(a); //ok
            Jambi.Foreground = new SolidColorBrush(a);
            Jambi.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/peta/Jambi1.png", 
                UriKind.Relative));
        }

        private void Jambi_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 79, 38, 212);
            Jambi.Background = new SolidColorBrush(a); //ok
            Jambi.Foreground = new SolidColorBrush(a);
            Jambi.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/img_icon/IMG_MAP.png", 
                UriKind.Relative));
        }

        private void Sumsel_MouseMove(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 252, 2, 2);
            Sumsel.Background = new SolidColorBrush(a); //ok
            Sumsel.Foreground = new SolidColorBrush(a);
            Sumsel.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/peta/Sumsel1.png", 
                UriKind.Relative));
        }

        private void Sumsel_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 79, 38, 212);
            Sumsel.Background = new SolidColorBrush(a); //ok
            Sumsel.Foreground = new SolidColorBrush(a);
            Sumsel.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/img_icon/IMG_MAP.png", 
                UriKind.Relative));
        }

        private void Bengkulu_MouseMove(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 252, 2, 2);
            Bengkulu.Background = new SolidColorBrush(a); //ok
            Bengkulu.Foreground = new SolidColorBrush(a);
            Bengkulu.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/peta/Bengkulu1.png", 
                UriKind.Relative));
        }

        private void Bengkulu_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 79, 38, 212);
            Bengkulu.Background = new SolidColorBrush(a); //ok
            Bengkulu.Foreground = new SolidColorBrush(a);
            Bengkulu.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/img_icon/IMG_MAP.png", 
                UriKind.Relative));
        }

        private void Lampung_MouseMove(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 252, 2, 2);
            Lampung.Background = new SolidColorBrush(a); //ok
            Lampung.Foreground = new SolidColorBrush(a);
            Lampung.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/peta/Lampung1.png", 
                UriKind.Relative));
        }

        private void Lampung_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 79, 38, 212);
            Lampung.Background = new SolidColorBrush(a); //ok
            Lampung.Foreground = new SolidColorBrush(a);
            Lampung.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/img_icon/IMG_MAP.png", 
                UriKind.Relative));
        }

        private void Banten_MouseMove(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 252, 2, 2);
            Banten.Background = new SolidColorBrush(a); //ok
            Banten.Foreground = new SolidColorBrush(a);
            Banten.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/peta/Banten1.png", 
                UriKind.Relative));
        }

        private void Banten_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 79, 38, 212);
            Banten.Background = new SolidColorBrush(a); //ok
            Banten.Foreground = new SolidColorBrush(a);
            Banten.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/img_icon/IMG_MAP.png", 
                UriKind.Relative));
        }

        private void DKI_MouseMove(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 252, 2, 2);
            DKI.Background = new SolidColorBrush(a); //ok
            DKI.Foreground = new SolidColorBrush(a);
            DKI.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/peta/DKI1.png", 
                UriKind.Relative));
        }

        private void DKI_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 79, 38, 212);
            DKI.Background = new SolidColorBrush(a); //ok
            DKI.Foreground = new SolidColorBrush(a);
            DKI.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/img_icon/IMG_MAP.png", 
                UriKind.Relative));
        }

        private void Jabar_MouseMove(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 252, 2, 2);
            Jabar.Background = new SolidColorBrush(a); //ok
            Jabar.Foreground = new SolidColorBrush(a);
            Jabar.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/peta/Jabar1.png", 
                UriKind.Relative));
        }

        private void Jabar_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 79, 38, 212);
            Jabar.Background = new SolidColorBrush(a); //ok
            Jabar.Foreground = new SolidColorBrush(a);
            Jabar.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/img_icon/IMG_MAP.png", 
                UriKind.Relative));
        }

        private void Jateng_MouseMove(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 252, 2, 2);
            Jateng.Background = new SolidColorBrush(a); //ok
            Jateng.Foreground = new SolidColorBrush(a);
            Jateng.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/peta/Jateng1.png", 
                UriKind.Relative));
        }

        private void Jateng_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 79, 38, 212);
            Jateng.Background = new SolidColorBrush(a); //ok
            Jateng.Foreground = new SolidColorBrush(a);
            Jateng.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/img_icon/IMG_MAP.png", 
                UriKind.Relative));
        }

        private void Yogyakarta_MouseMove(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 252, 2, 2);
            Yogyakarta.Background = new SolidColorBrush(a); //ok
            Yogyakarta.Foreground = new SolidColorBrush(a);
            Yogyakarta.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/peta/Yogyakarta1.png", 
                UriKind.Relative));
        }

        private void Yogyakarta_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 79, 38, 212);
            Yogyakarta.Background = new SolidColorBrush(a); //ok
            Yogyakarta.Foreground = new SolidColorBrush(a);
            Yogyakarta.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/img_icon/IMG_MAP.png", 
                UriKind.Relative));
        }

        private void Jatim_MouseMove(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 252, 2, 2);
            Jatim.Background = new SolidColorBrush(a); //ok
            Jatim.Foreground = new SolidColorBrush(a);
            Jatim.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/peta/Jatim1.png", 
                UriKind.Relative));
        }

        private void Jatim_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 79, 38, 212);
            Jatim.Background = new SolidColorBrush(a); //ok
            Jatim.Foreground = new SolidColorBrush(a);
            Jatim.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/img_icon/IMG_MAP.png", 
                UriKind.Relative));
        }

        private void Bali_MouseMove(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 252, 2, 2);
            Bali.Background = new SolidColorBrush(a); //ok
            Bali.Foreground = new SolidColorBrush(a);
            Bali.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/peta/Bali1.png",
                UriKind.Relative));
        }

        private void Bali_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 79, 38, 212);
            Bali.Background = new SolidColorBrush(a); //ok
            Bali.Foreground = new SolidColorBrush(a);
            Bali.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/img_icon/IMG_MAP.png",
                UriKind.Relative));
        }

        private void NTB_MouseMove(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 252, 2, 2);
            NTB.Background = new SolidColorBrush(a); //ok
            NTB.Foreground = new SolidColorBrush(a);
            NTB.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/peta/NTB1.png",
                UriKind.Relative));
        }

        private void NTB_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 79, 38, 212);
            NTB.Background = new SolidColorBrush(a); //ok
            NTB.Foreground = new SolidColorBrush(a);
            NTB.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/img_icon/IMG_MAP.png",
                UriKind.Relative));
        }

        private void NTT_MouseMove(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 252, 2, 2);
            NTT.Background = new SolidColorBrush(a); //ok
            NTT.Foreground = new SolidColorBrush(a);
            NTT.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/peta/NTT1.png",
                UriKind.Relative));
        }

        private void NTT_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 79, 38, 212);
            NTT.Background = new SolidColorBrush(a); //ok
            NTT.Foreground = new SolidColorBrush(a);
            NTT.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/img_icon/IMG_MAP.png",
                UriKind.Relative));
        }

        private void Kalbar_MouseMove(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 252, 2, 2);
            Kalbar.Background = new SolidColorBrush(a); //ok
            Kalbar.Foreground = new SolidColorBrush(a);
            Kalbar.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/peta/Kalbar1.png",
                UriKind.Relative));
        }

        private void Kalbar_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 79, 38, 212);
            Kalbar.Background = new SolidColorBrush(a); //ok
            Kalbar.Foreground = new SolidColorBrush(a);
            Kalbar.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/img_icon/IMG_MAP.png",
                UriKind.Relative));
        }

        private void Kalteng_MouseMove(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 252, 2, 2);
            Kalteng.Background = new SolidColorBrush(a); //ok
            Kalteng.Foreground = new SolidColorBrush(a);
            Kalteng.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/peta/Kalteng1.png",
                UriKind.Relative));
        }

        private void Kalteng_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 79, 38, 212);
            Kalteng.Background = new SolidColorBrush(a); //ok
            Kalteng.Foreground = new SolidColorBrush(a);
            Kalteng.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/img_icon/IMG_MAP.png",
                UriKind.Relative));
        }

        private void Kalsel_MouseMove(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 252, 2, 2);
            Kalsel.Background = new SolidColorBrush(a); //ok
            Kalsel.Foreground = new SolidColorBrush(a);
            Kalsel.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/peta/Kalsel1.png",
                UriKind.Relative));
        }

        private void Kalsel_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 79, 38, 212);
            Kalsel.Background = new SolidColorBrush(a); //ok
            Kalsel.Foreground = new SolidColorBrush(a);
            Kalsel.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/img_icon/IMG_MAP.png",
                UriKind.Relative));
        }

        private void Kaltim_MouseMove(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 252, 2, 2);
            Kaltim.Background = new SolidColorBrush(a); //ok
            Kaltim.Foreground = new SolidColorBrush(a);
            Kaltim.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/peta/Kaltim1.png",
                UriKind.Relative));
        }

        private void Kaltim_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 79, 38, 212);
            Kaltim.Background = new SolidColorBrush(a); //ok
            Kaltim.Foreground = new SolidColorBrush(a);
            Kaltim.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/img_icon/IMG_MAP.png",
                UriKind.Relative));
        }

        private void Kalut_MouseMove(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 252, 2, 2);
            Kalut.Background = new SolidColorBrush(a); //ok
            Kalut.Foreground = new SolidColorBrush(a);
            Kalut.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/peta/Kalut1.png",
                UriKind.Relative));
        }

        private void Kalut_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 79, 38, 212);
            Kalut.Background = new SolidColorBrush(a); //ok
            Kalut.Foreground = new SolidColorBrush(a);
            Kalut.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/img_icon/IMG_MAP.png",
                UriKind.Relative));
        }

        private void Sulbar_MouseMove(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 252, 2, 2);
            Sulbar.Background = new SolidColorBrush(a); //ok
            Sulbar.Foreground = new SolidColorBrush(a);
            Sulbar.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/peta/Sulbar1.png",
                UriKind.Relative));
        }

        private void Sulbar_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 79, 38, 212);
            Sulbar.Background = new SolidColorBrush(a); //ok
            Sulbar.Foreground = new SolidColorBrush(a);
            Sulbar.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/img_icon/IMG_MAP.png",
                UriKind.Relative));
        }

        private void Sulteng_MouseMove(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 252, 2, 2);
            Sulteng.Background = new SolidColorBrush(a); //ok
            Sulteng.Foreground = new SolidColorBrush(a);
            Sulteng.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/peta/Sulteng1.png",
                UriKind.Relative));
        }

        private void Sulteng_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 79, 38, 212);
            Sulteng.Background = new SolidColorBrush(a); //ok
            Sulteng.Foreground = new SolidColorBrush(a);
            Sulteng.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/img_icon/IMG_MAP.png",
                UriKind.Relative));
        }

        private void Gorontalo_MouseMove(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 252, 2, 2);
            Gorontalo.Background = new SolidColorBrush(a); //ok
            Gorontalo.Foreground = new SolidColorBrush(a);
            Gorontalo.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/peta/Gorontalo1.png",
                UriKind.Relative));
        }

        private void Gorontalo_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 79, 38, 212);
            Gorontalo.Background = new SolidColorBrush(a); //ok
            Gorontalo.Foreground = new SolidColorBrush(a);
            Gorontalo.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/img_icon/IMG_MAP.png",
                UriKind.Relative));
        }

        private void Sulut_MouseMove(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 252, 2, 2);
            Sulut.Background = new SolidColorBrush(a); //ok
            Sulut.Foreground = new SolidColorBrush(a);
            Sulut.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/peta/Sulut1.png",
                UriKind.Relative));
        }

        private void Sulut_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 79, 38, 212);
            Sulut.Background = new SolidColorBrush(a); //ok
            Sulut.Foreground = new SolidColorBrush(a);
            Sulut.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/img_icon/IMG_MAP.png",
                UriKind.Relative));
        }

        private void Sulsel_MouseMove(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 252, 2, 2);
            Sulsel.Background = new SolidColorBrush(a); //ok
            Sulsel.Foreground = new SolidColorBrush(a);
            Sulsel.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/peta/Sulsel1.png",
                UriKind.Relative));
        }

        private void Sulsel_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 79, 38, 212);
            Sulsel.Background = new SolidColorBrush(a); //ok
            Sulsel.Foreground = new SolidColorBrush(a);
            Sulsel.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/img_icon/IMG_MAP.png",
                UriKind.Relative));
        }

        private void Sultra_MouseMove(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 252, 2, 2);
            Sultra.Background = new SolidColorBrush(a); //ok
            Sultra.Foreground = new SolidColorBrush(a);
            Sultra.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/peta/Sultra1.png",
                UriKind.Relative));
        }

        private void Sultra_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 79, 38, 212);
            Sultra.Background = new SolidColorBrush(a); //ok
            Sultra.Foreground = new SolidColorBrush(a);
            Sultra.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/img_icon/IMG_MAP.png",
                UriKind.Relative));
        }

        private void Maluku_MouseMove(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 252, 2, 2);
            Maluku.Background = new SolidColorBrush(a); //ok
            Maluku.Foreground = new SolidColorBrush(a);
            Maluku.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/peta/Maluku1.png",
                UriKind.Relative));
        }

        private void Maluku_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 79, 38, 212);
            Maluku.Background = new SolidColorBrush(a); //ok
            Maluku.Foreground = new SolidColorBrush(a);
            Maluku.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/img_icon/IMG_MAP.png",
                UriKind.Relative));
        }

        private void MalukuUtara_MouseMove(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 252, 2, 2);
            MalukuUtara.Background = new SolidColorBrush(a); //ok
            MalukuUtara.Foreground = new SolidColorBrush(a);
            MalukuUtara.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/peta/Malut1.png",
                UriKind.Relative));
        }

        private void MalukuUtara_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 79, 38, 212);
            MalukuUtara.Background = new SolidColorBrush(a); //ok
            MalukuUtara.Foreground = new SolidColorBrush(a);
            MalukuUtara.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/img_icon/IMG_MAP.png",
                UriKind.Relative));
        }

        private void PapuaBarat_MouseMove(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 252, 2, 2);
            PapuaBarat.Background = new SolidColorBrush(a); //ok
            PapuaBarat.Foreground = new SolidColorBrush(a);
            PapuaBarat.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/peta/PapuaBarat1.png",
                UriKind.Relative));
        }

        private void PapuaBarat_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 79, 38, 212);
            PapuaBarat.Background = new SolidColorBrush(a); //ok
            PapuaBarat.Foreground = new SolidColorBrush(a);
            PapuaBarat.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/img_icon/IMG_MAP.png",
                UriKind.Relative));
        }

        private void Papua_MouseMove(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 252, 2, 2);
            Papua.Background = new SolidColorBrush(a); //ok
            Papua.Foreground = new SolidColorBrush(a);
            Papua.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/peta/Papua1.png",
                UriKind.Relative));
        }

        private void Papua_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 79, 38, 212);
            Papua.Background = new SolidColorBrush(a); //ok
            Papua.Foreground = new SolidColorBrush(a);
            Papua.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/img_icon/IMG_MAP.png",
                UriKind.Relative));
        }

        private void Sumbar_MouseMove(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 252, 2, 2);
            Sumbar.Background = new SolidColorBrush(a); //ok
            Sumbar.Foreground = new SolidColorBrush(a);
            Sumbar.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/peta/Sumbar1.png",
                UriKind.Relative));
        }

        private void Sumbar_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 79, 38, 212);
            Sumbar.Background = new SolidColorBrush(a); //ok
            Sumbar.Foreground = new SolidColorBrush(a);
            Sumbar.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/img_icon/IMG_MAP.png",
                UriKind.Relative));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "pakaian";
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageDataDetail", UriKind.Absolute));
        }

        //Data Budaya
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "permainan";
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageDataDetail", UriKind.Absolute));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "senjata";
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageDataDetail", UriKind.Absolute));
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "ritual";
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageDataDetail", UriKind.Absolute));
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "musik";
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageDataDetail", UriKind.Absolute));
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "cerita";
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageDataDetail", UriKind.Absolute));
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "rumah";
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageDataDetail", UriKind.Absolute));
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "makanan";
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageDataDetail", UriKind.Absolute));
        }


        //Data Provinsi
        private void Aceh_Click(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "Aceh";
            //ChildWindow p = new Provinsi();
            //p.Show();
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageProvinsi", UriKind.Absolute));
        }

        private void Sumut_Click(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "Sumut";
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/img_icon/pop-up1.png",
               UriKind.Relative));
            //ChildWindow p = new Provinsi();
            //p.Show();

        }

        private void Riau_Click(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "Riau";
            //ChildWindow p = new Provinsi();
            //p.Show();
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageProvinsi", UriKind.Absolute));
        }

        private void Sumbar_Click(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "Sumbar";
            //ChildWindow p = new Provinsi();
            //p.Show();
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageProvinsi", UriKind.Absolute));
        }

        private void Jambi_Click(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "Jambi";
            //ChildWindow p = new Provinsi();
            //p.Show();
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageProvinsi", UriKind.Absolute));
        }

        private void Sumsel_Click(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "Sumsel";
            //ChildWindow p = new Provinsi();
            //p.Show();
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageProvinsi", UriKind.Absolute));
        }

        private void Bengkulu_Click(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "Bengkulu";
            //ChildWindow p = new Provinsi();
            //p.Show();
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageProvinsi", UriKind.Absolute));
        }

        private void Lampung_Click(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "Lampung";
            //ChildWindow p = new Provinsi();
            //p.Show();
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageProvinsi", UriKind.Absolute));
        }

        private void Banten_Click(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "Banten";
            //ChildWindow p = new Provinsi();
            //p.Show();
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageProvinsi", UriKind.Absolute));
        }

        private void DKI_Click(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "DKI";
            //ChildWindow p = new Provinsi();
            //p.Show();
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageProvinsi", UriKind.Absolute));
        }

        private void Jabar_Click(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "Jabar";
            //ChildWindow p = new Provinsi();
            //p.Show();
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageProvinsi", UriKind.Absolute));
        }

        private void Jateng_Click(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "jateng";
            //ChildWindow p = new Provinsi();
            //p.Show();
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageProvinsi", UriKind.Absolute));
        }

        private void Yogyakarta_Click(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "Yogyakarta";
            //ChildWindow p = new Provinsi();
            //p.Show();
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageProvinsi", UriKind.Absolute));
        }

        private void Jatim_Click(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "jatim";
            //ChildWindow p = new Provinsi();
            //p.Show();
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageProvinsi", UriKind.Absolute));
        }

        private void Bali_Click(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "bali";
            //ChildWindow p = new Provinsi();
            //p.Show();
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageProvinsi", UriKind.Absolute));
        }

        private void NTB_Click(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "NTB";
            //ChildWindow p = new Provinsi();
            //p.Show();
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageProvinsi", UriKind.Absolute));
        }

        private void NTT_Click(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "NTT";
            //ChildWindow p = new Provinsi();
            //p.Show();
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageProvinsi", UriKind.Absolute));
        }

        private void Kalbar_Click(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "Kalbar";
            //ChildWindow p = new Provinsi();
            //p.Show();
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageProvinsi", UriKind.Absolute));
        }

        private void Kalteng_Click(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "kalteng";
            //ChildWindow p = new Provinsi();
            //p.Show();
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageProvinsi", UriKind.Absolute));
        }

        private void Kalsel_Click(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "Kalsel";
            //ChildWindow p = new Provinsi();
            //p.Show();
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageProvinsi", UriKind.Absolute));
        }

        private void Kaltim_Click(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "kaltim";
            //ChildWindow p = new Provinsi();
            //p.Show();
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageProvinsi", UriKind.Absolute));
        }

        private void Kalut_Click(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "kalut";
            //ChildWindow p = new Provinsi();
            //p.Show();
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageProvinsi", UriKind.Absolute));
        }

        private void Sulbar_Click(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "Sulbar";
            //ChildWindow p = new Provinsi();
            //p.Show();
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageProvinsi", UriKind.Absolute));
        }

        private void Sulteng_Click(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "Sulteng";
            //ChildWindow p = new Provinsi();
            //p.Show();
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageProvinsi", UriKind.Absolute));
        }

        private void Gorontalo_Click(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "Gorontalo";
            //ChildWindow p = new Provinsi();
            //p.Show();
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageProvinsi", UriKind.Absolute));
        }

        private void Sulut_Click(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "Sulut";
            //ChildWindow p = new Provinsi();
            //p.Show();
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageProvinsi", UriKind.Absolute));
        }

        private void Sulsel_Click(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "Sulsel";
            //ChildWindow p = new Provinsi();
            //p.Show();
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageProvinsi", UriKind.Absolute));
        }

        private void Sultra_Click(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "Sultra";
            //ChildWindow p = new Provinsi();
            //p.Show();
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageProvinsi", UriKind.Absolute));
        }

        private void Maluku_Click(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "Maluku";
            //ChildWindow p = new Provinsi();
            //p.Show();
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageProvinsi", UriKind.Absolute));
        }

        private void MalukuUtara_Click(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "MalukuUtara";
            //ChildWindow p = new Provinsi();
            //p.Show();
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageProvinsi", UriKind.Absolute));
        }

        private void PapuaBarat_Click(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "PapuaBarat";
            //ChildWindow p = new Provinsi();
            //p.Show();
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageProvinsi", UriKind.Absolute));
        }

        private void Papua_Click(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "Papua";
            //ChildWindow p = new Provinsi();
            //p.Show();
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageProvinsi", UriKind.Absolute));
        }

        private void Kepri_Click(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "Kepri";
            //ChildWindow p = new Provinsi();
            //p.Show();
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageProvinsi", UriKind.Absolute));

        }

        private void Babel_Click(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "Babel";
            //ChildWindow p = new Provinsi();
            //p.Show();
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageProvinsi", UriKind.Absolute));
        }

        private void Kepri_MouseMove(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 252, 2, 2);
            Kepri.Background = new SolidColorBrush(a); //ok
            Kepri.Foreground = new SolidColorBrush(a);
            Kepri.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/peta/Kepri1.png",
                UriKind.Relative));
        }

        private void Kepri_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 79, 38, 212);
            Kepri.Background = new SolidColorBrush(a); //ok
            Kepri.Foreground = new SolidColorBrush(a);
            Kepri.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/img_icon/IMG_MAP.png",
                UriKind.Relative));
        }

 
        private void Babel_MouseMove(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 252, 2, 2);
            Babel.Background = new SolidColorBrush(a); //ok
            Babel.Foreground = new SolidColorBrush(a);
            Babel.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/peta/Bebel1.png",
                UriKind.Relative));
        }

        private void Babel_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = Color.FromArgb(100, 79, 38, 212);
            Babel.Background = new SolidColorBrush(a); //ok
            Babel.Foreground = new SolidColorBrush(a);
            Babel.BorderBrush = new SolidColorBrush(a);
            peta.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/SilverlightApplication1;component/img_icon/IMG_MAP.png",
                UriKind.Relative));
        }

        private void animasi_aceh1(object sender, RoutedEventArgs e)
        {
            ValueFromHome = "Aceh";
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://localhost:3366/EBIPES17TestPage.aspx#/PageDataDetail", UriKind.Absolute));
        }
        
        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

    }
}
