using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartBikeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectDevicePage : ContentPage
    {
        public SelectDevicePage()
        {
            InitializeComponent();
            FillBondedDevices();
        }
        private void FillBondedDevices()
        {
            var adapter = DependencyService.Resolve<Plugin.BluetoothClassic.Abstractions.IBluetoothAdapter>();
            lvBondedDevices.ItemsSource = adapter.BondedDevices;
        }

        private async void lvBondedDevices_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var device = (Plugin.BluetoothClassic.Abstractions.BluetoothDeviceModel)e.SelectedItem;
            if(device != null)
            {
                var tabbedPage = new TabbedPage();
                tabbedPage.Children.Add(new MotionPage());
                tabbedPage.Children.Add(new LockPage());
                tabbedPage.BindingContext = device;
                await Navigation.PushAsync(tabbedPage);
            }
            lvBondedDevices.SelectedItem = null;
        }
    }
}