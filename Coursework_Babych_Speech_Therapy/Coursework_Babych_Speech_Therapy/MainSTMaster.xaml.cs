using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Coursework_Babych_Speech_Therapy
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainSTMaster : ContentPage
    {
        public ListView ListView;

        public MainSTMaster()
        {
            InitializeComponent();

            BindingContext = new MainSTMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MainSTMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MainSTMasterMenuItem> MenuItems { get; set; }

            public MainSTMasterViewModel()
            {
                MenuItems = new ObservableCollection<MainSTMasterMenuItem>(new[]
                {
                    new MainSTMasterMenuItem { Id = 0, Title = "Page 1" },
                    new MainSTMasterMenuItem { Id = 1, Title = "Page 2" },
                    new MainSTMasterMenuItem { Id = 2, Title = "Page 3" },
                    new MainSTMasterMenuItem { Id = 3, Title = "Page 4" },
                    new MainSTMasterMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}