using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PRACTICA_1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio1 : ContentPage
    {
        public Inicio1()
        {
            InitializeComponent();
        }

        private async void Guardar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
    }
}