using lelab.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace lelab
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CountPage ();
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
