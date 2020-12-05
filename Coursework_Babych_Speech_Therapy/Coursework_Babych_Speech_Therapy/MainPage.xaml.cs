using Coursework_Babych_Speech_Therapy.View;
using Plugin.DownloadManager;
using Plugin.DownloadManager.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Coursework_Babych_Speech_Therapy
{

    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {   
        public MainPage()
        {
            InitializeComponent();

            Detail = new NavigationPage(new NewsView())
            {
                BarBackgroundColor = Color.FromHex("#30D5C8")
            };
            IsPresented = false;
            
        }

        private void ButtonNews(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new NewsView())
            {
                BarBackgroundColor = Color.FromHex("#30D5C8")
            };
            IsPresented = false;
        }

        private void ButtonConsultations(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Consultations())
            {
                BarBackgroundColor = Color.FromHex("#30D5C8")
            };
            IsPresented = false;
        }

        private void ButtonCourse(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Course())
            {
                BarBackgroundColor = Color.FromHex("#30D5C8")
            };
            IsPresented = false;
        }

        private void ButtonUsefulMaterials(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new UsefulMaterials())
            {
                BarBackgroundColor = Color.FromHex("#30D5C8")
            };
            IsPresented = false;
        }

        private void ButtonForum(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Forum())
            {
                BarBackgroundColor = Color.FromHex("#30D5C8")
            };
            IsPresented = false;
        }

        private void ButtonFeedback(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Feedback())
            {
                BarBackgroundColor = Color.FromHex("#30D5C8")
            };
            IsPresented = false;
        }
    }
}