using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace MI_CARD
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnYoutube_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.youtube.com/channel/UCnps4nOdbsOhy4-cyBT_BFg", BrowserLaunchMode.SystemPreferred);
        }

        private void btnVerlinkedin_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.linkedin.com/in/misael-beriguete-b086a3222/", BrowserLaunchMode.SystemPreferred);
        }

        private void btnVerTwitter_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://twitter.com/BerigueteMisae1", BrowserLaunchMode.SystemPreferred);
        }

        private void btnVerInstagrams_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.instagram.com/misaeel_7/", BrowserLaunchMode.SystemPreferred);
        }

        private void btnVerFacebook_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.facebook.com/Misael2508/", BrowserLaunchMode.SystemPreferred);
        }
    }
}