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
    public partial class Forum : ContentPage
    {
        public Forum()
        {
            InitializeComponent();
        }

        private void SendMes(object sender, EventArgs  e)
        {
            BoxChat.IsReadOnly = true;
            BoxChat.Text += Chat1.Text;
            BoxChat.Text += "\n";
            Chat1.Text = "";
        }
    }
}