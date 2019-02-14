using Xamarin.Forms;
using AdMobTemplate;
using AdMobTemplate.Droid;
using Xamarin.Forms.Platform.Android;
using Android.Gms.Ads;

[assembly: ExportRenderer(typeof(AdMobView), typeof(AdMobBanner))]

namespace AdMobTemplate.Droid
{
    public class AdMobBanner : ViewRenderer<AdMobView, Android.Gms.Ads.AdView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<AdMobView> e)
        {
            base.OnElementChanged(e);
            if (Control == null)
            {
                var ad = new AdView(Android.App.Application.Context);
                ad.AdSize = AdSize.Banner;
                ad.AdUnitId = "ca-app-pub-3940256099942544/6300978111";

                var requestBuilder = new AdRequest.Builder();
                ad.LoadAd(requestBuilder.Build());
                SetNativeControl(ad);
            }
        }

        public AdMobBanner()
        {

        }
    }
}