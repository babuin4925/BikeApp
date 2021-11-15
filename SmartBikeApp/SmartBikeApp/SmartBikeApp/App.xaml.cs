using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartBikeApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            /*var tabbedPage = new TabbedPage();
            tabbedPage.Children.Add(new MotionPage());
            tabbedPage.Children.Add(new LockPage());
            */
            MainPage = new NavigationPage(new SelectDevicePage());
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
    }
}
