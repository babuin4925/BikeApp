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
    public partial class TransieverPage : ContentPage
    {
        public TransieverPage()
        {
            InitializeComponent();
        }

        private async void btnTransmit_Clicked(object sender, EventArgs e)
        {
            var device = (Plugin.BluetoothClassic.Abstractions.BluetoothDeviceModel)BindingContext;
            if (device != null)
            {
                var adapter = DependencyService.Resolve<Plugin.BluetoothClassic.Abstractions.IBluetoothAdapter>();
                using(var connection = adapter.CreateConnection(device))
                {
                    
                }
            }
        }

        private void btnRecieve_Clicked(object sender, EventArgs e)
        {

        }
    }
}