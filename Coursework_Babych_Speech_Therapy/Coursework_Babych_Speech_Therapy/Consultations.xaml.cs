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
    public partial class Consultations : ContentPage
    {
        public Consultations()
        {
            InitializeComponent();
        }

        private async void SendConsult(object sender, EventArgs e)
        {
            if (Cons_question.Text == null)
            {
                await DisplayAlert("Помилка!", "Ви не ввели текст у полі 'Опишіть Ваше питання'", "OK");
            }

            if (Cons_topic.Text == null)
            {
                await DisplayAlert("Помилка!", "Ви не ввели текст у полі 'Тема'", "OK");
            }

            if (Cons_email.Text == null)
            {
                await DisplayAlert("Помилка!", "Ви не ввели текст у полі 'Ваша електронна адреса'", "OK");
            }

            if (Cons_question.Text != null && Cons_topic.Text != null && Cons_email.Text != null)
            {
                await DisplayAlert("Запит консультації", "Ваша заявка успішно надіслана!", "OK");
                await Navigation.PushModalAsync(new MainPage());
            }

        }
    }
}