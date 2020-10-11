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
    public partial class AcademicClubPage : ContentPage
    {
        public AcademicClubPage()
        {
            InitializeComponent();
        }
        async void MeetingDates_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MeetingDatesPage());
        }
    }
}