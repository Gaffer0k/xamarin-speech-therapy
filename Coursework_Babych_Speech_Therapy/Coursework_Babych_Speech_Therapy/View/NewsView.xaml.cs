using Coursework_Babych_Speech_Therapy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Coursework_Babych_Speech_Therapy.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsView : ContentPage
    {
        public NewsViewModel vm;
        public NewsView()
        {
            InitializeComponent();

            vm = new NewsViewModel();
            //listNews.ItemsSource = vm.News;
            BindingContext = vm;
        }
    }
}