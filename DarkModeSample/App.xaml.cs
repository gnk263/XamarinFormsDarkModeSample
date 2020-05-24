using DarkModeSample.Resources;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DarkModeSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            ApplyTheme();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        public static void ApplyTheme()
        {
            if (AppInfo.RequestedTheme == AppTheme.Dark)
            {
                App.Current.Resources = new DarkTheme();
            }
            else
            {
                App.Current.Resources = new LightTheme();
            }
        }
    }
}
