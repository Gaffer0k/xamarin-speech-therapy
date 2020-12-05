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
    public partial class Reg : ContentPage
    {
        public Reg()
        {
            InitializeComponent();
        }

        private async void ButtonReg(object sender, EventArgs e)
        {
            await DisplayAlert("Реєстрація...", "Ваш профіль створено!", "ОК");
        }
    }
}