using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SportPage : ContentPage
    {
        public SportPage()
        {
            InitializeComponent();
        }
        async void PracticeMeetSchedule_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PracticeMeetSchedulePage());
        }
    }
}