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
    public partial class ClassesPage : ContentPage
    {
        public ClassesPage()
        {
            InitializeComponent();
        }
        async void Schedule_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SchedulePage());
        }
        async void Homework_Assignments_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Homework());
        }
        async void Zoom_Meetings_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ZoomMeetingsPage());
        }
    }
}