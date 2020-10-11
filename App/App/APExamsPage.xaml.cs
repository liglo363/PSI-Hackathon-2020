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
    public partial class APExamsPage : ContentPage
    {
        public APExamsPage()
        {
            InitializeComponent();
        }
        async void APClass1_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new APClass1Page());
        }
        async void APClass2_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new APClass2Page());
        }
    }
}