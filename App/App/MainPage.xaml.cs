using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void Classes_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClassesPage());
        }
        async void APExams_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new APExamsPage());
        }
        async void SATACT_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SATACTPage());
        }
        async void EC_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ECPage());
        }
        async void Mental_Health_Resources_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MentalHealthResourcesPage());
        }
    }
}
