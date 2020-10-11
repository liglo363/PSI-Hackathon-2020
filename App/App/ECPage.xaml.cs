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
    public partial class ECPage : ContentPage
    {
        public ECPage()
        {
            InitializeComponent();
        }
        async void Academic_Club_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AcademicClubPage());
        }
        async void Sport_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SportPage());
        }
    }
}