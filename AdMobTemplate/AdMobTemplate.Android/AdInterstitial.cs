using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdMobTemplate.Droid;
using Android.App;
using Android.Content;
using Android.Gms.Ads;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;

[assembly: Dependency(typeof(AdInterstitial))]

namespace AdMobTemplate.Droid
{
    public class AdInterstitial : IAdInterstitial
    {
        InterstitialAd interstitialAd;

        public AdInterstitial()
        {
            interstitialAd = new InterstitialAd(Android.App.Application.Context);
            interstitialAd.AdUnitId = "ca-app-pub-3940256099942544/1033173712";
            LoadAd();
        }

        public void LoadAd()
        {
            var requestbuilder = new AdRequest.Builder();
            interstitialAd.LoadAd(requestbuilder.Build());
        }

        public void ShowAd()
        {
            if (interstitialAd.IsLoaded) interstitialAd.Show();
        }
    }
}