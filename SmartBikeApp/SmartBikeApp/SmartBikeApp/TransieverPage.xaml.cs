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

        /*private async bool TryConnectAsync(Plugin.BluetoothClassic.Abstractions.IBluetoothConnection connection, int tries)
        {
            while (tries > 0)
            {
                await connection.ConnectAsync();
            }
        }*/

        private async void btnTransmit_Clicked(object sender, EventArgs e)
        {
            const int BufferSize = 1;
            const int OffsetDefault = 0;
            var device = (Plugin.BluetoothClassic.Abstractions.BluetoothDeviceModel)BindingContext;
            if (device != null)
            {
                var adapter = DependencyService.Resolve<Plugin.BluetoothClassic.Abstractions.IBluetoothAdapter>();
                using(var connection = adapter.CreateConnection(device))
                {
                    await connection.ConnectAsync();
                    byte[] buffer = new byte[BufferSize] {(byte)stepperDigit.Value};
                    await connection.TransmitAsync(buffer, OffsetDefault, buffer.Length);
                }
            }
        }

        private void btnRecieve_Clicked(object sender, EventArgs e)
        {

        }
    }
}