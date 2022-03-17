using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace E1P6EstebanApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrarActivoPage : ContentPage
    {
        public RegistrarActivoPage()
        {
            InitializeComponent();
        }

        private async void CmdCancelar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}