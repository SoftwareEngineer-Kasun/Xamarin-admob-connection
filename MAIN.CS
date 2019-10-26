[Activity (Label = "AdMob", MainLauncher = true, Icon = "@ drawable / icon")]
    public class MainActivity: Activity
    {
        protected AdView mAdView;

        protected override void OnCreate (Bundle bundle)
        {
            base.OnCreate (bundle);
            SetContentView (Resource.Layout.Main);

            mAdView = FindViewById <AdView> (Resource.Id.adView);
            var adRequest = new AdRequest.Builder (). Build ();
            mAdView.LoadAd (adRequest);

        }
        protected override void OnResume ()
        {
            base.OnResume ();
            if (mAdView! = null)
            {
                mAdView.Resume ();
            }
        }
    }
