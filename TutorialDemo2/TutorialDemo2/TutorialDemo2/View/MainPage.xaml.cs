using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialDemo2.View;
using Xamarin.Forms;

namespace TutorialDemo2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           
        }
       
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EntryPage());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GetServicePage());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PostServicePage());
        }
    }
}
