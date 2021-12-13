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

        private void btnTransmit_Clicked(object sender, EventArgs e)
        {

        }

        private void btnRecieve_Clicked(object sender, EventArgs e)
        {

        }
    }
}