using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AdMobTemplate
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            DependencyService.Get<IAdInterstitial>().LoadAd();
        }

        private void Button_LoadAd(object sender, EventArgs e)
        {
            DependencyService.Get<IAdInterstitial>().LoadAd();
        }

        private void Button_ShowAd(object sender, EventArgs e)
        {
            DependencyService.Get<IAdInterstitial>().ShowAd();
        }
    }

    public class AdMobView : ContentView
    {
        public AdMobView()
        {

        }
    }
}
