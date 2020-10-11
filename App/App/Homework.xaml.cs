using App.DataModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Homework : ContentPage
    {
        public Homework()
        {
            InitializeComponent();
            //Assignments = AssignmentManager.AssignmentCollection;
            AssignmentView.ItemsSource = Assignments;
            foreach (var item in AssignmentManager.AssignmentCollection)
            {
                Assignments.Add(item);
            }
            //Assignments.Add(new Assignment { Name = "MyAssignment One", DueDate = DateTime.Today });
        }
        //public System.Collections.ObjectModel.ObservableCollection<Assignment> Assignments { get; set; }
        ObservableCollection<Assignment> assignments = new ObservableCollection<Assignment>();
        public ObservableCollection<Assignment> Assignments { get { return assignments; } }
        private int numOfCompleted = 0;
        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                numOfCompleted++;
            }
            else
            {
                numOfCompleted--;
            }
            //if(numOfCompleted == 3)
            //{
            //    CongratulateLabel.IsVisible = true;
            //    AssignmentsLeft.IsVisible = false;
            //}
            //else
            //{
            //    AssignmentsLeft.Text = string.Format("You still have {0} assignment left.", 3-numOfCompleted);
            //    CongratulateLabel.IsVisible = false;
            //    AssignmentsLeft.IsVisible = true;
            //}
        }
        async void Add_Assignment_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddAssignmentPage());
        }
    }
}