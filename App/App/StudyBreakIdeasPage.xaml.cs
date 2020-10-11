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
    public partial class StudyBreakIdeasPage : ContentPage
    {
        public StudyBreakIdeasPage()
        {
            InitializeComponent();
            MediaRepository.MyMediaPlayer.Start();
        }
        protected override void OnDisappearing()
        {
            MediaRepository.MyMediaPlayer.Stop();
        }
        
    }
}