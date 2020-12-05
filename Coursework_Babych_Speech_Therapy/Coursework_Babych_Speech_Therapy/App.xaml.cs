using Coursework_Babych_Speech_Therapy.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Coursework_Babych_Speech_Therapy
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NewsView();
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
    }
}
