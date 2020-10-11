using Android;
using Android.Media;
using App.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.TizenSpecific;
using Xamarin.Forms.Xaml;

namespace App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MentalHealthResourcesPage : ContentPage
    {
        public MentalHealthResourcesPage()
        {
            InitializeComponent();
        }
        async void Meditation_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MeditationPage());
        }
        async void Yoga_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new YogaPage());
        }
        async void Study_Break_Ideas_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StudyBreakIdeasPage());
        }

    }
}