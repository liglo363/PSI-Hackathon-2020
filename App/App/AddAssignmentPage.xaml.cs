using App.DataModel;
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
    public partial class AddAssignmentPage : ContentPage
    {
        public AddAssignmentPage()
        {
            InitializeComponent();
            AssignmentDueDatePicker.Date = DateTime.Today;
        }

        async void SaveAssignment_Button_Clicked(object sender, EventArgs e)
        {
            Assignment assignment = new Assignment();
            assignment.Name = AssignmentName.Text;
            assignment.DueDate = AssignmentDueDatePicker.Date;
            AssignmentManager.AssignmentCollection.Add(assignment);
            await Navigation.PushAsync(new Homework());
        }
        

    }
}