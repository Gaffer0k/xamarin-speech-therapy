using Acr.UserDialogs;
using Plugin.DownloadManager;
using Plugin.DownloadManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Coursework_Babych_Speech_Therapy
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UsefulMaterials : ContentPage
    {
        public UsefulMaterials()
        {
            InitializeComponent(); 
        }

        private async void Download1(object sender, EventArgs e)
        {
            await DisplayAlert("Завантаження файлу", "На даний момент додаток не має доступу до Інтернету!", "OK");
        }
        private async void Download2(object sender, EventArgs e)
        {
            await DisplayAlert("Завантаження файлу", "На даний момент додаток не має доступу до Інтернету!", "OK");
        }
        private async void Download3(object sender, EventArgs e)
        {
            await DisplayAlert("Завантаження файлу", "На даний момент додаток не має доступу до Інтернету!", "OK");
        }
        private async void Download4(object sender, EventArgs e)
        {
            await DisplayAlert("Завантаження файлу", "На даний момент додаток не має доступу до Інтернету!", "OK");
        }
        private async void Download5(object sender, EventArgs e)
        {
            await DisplayAlert("Завантаження файлу", "На даний момент додаток не має доступу до Інтернету!", "OK");
        }
        private async void Download6(object sender, EventArgs e)
        {
            await DisplayAlert("Завантаження файлу", "На даний момент додаток не має доступу до Інтернету!", "OK");
        }
        private async void Download7(object sender, EventArgs e)
        {
            await DisplayAlert("Завантаження файлу", "На даний момент додаток не має доступу до Інтернету!", "OK");
        }
    }
}