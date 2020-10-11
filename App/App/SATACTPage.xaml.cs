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
    public partial class SATACTPage : ContentPage
    {
        public SATACTPage()
        {
            InitializeComponent();
        }
        async void Testing_Dates_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TestingDatesPage());
        }
        async void StudyWebsitesMaterials_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StudyWebsitesMaterialsPage());
        }
    }
}