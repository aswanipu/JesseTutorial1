using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialDemo2.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TutorialDemo2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GetServicePage : ContentPage
    {
        public GetServicePage()
        {
            InitializeComponent();
            WingetResult res = new WingetResult();
        }
        protected override void OnAppearing()
        {
            string error = "";
            base.OnAppearing();
            Device.BeginInvokeOnMainThread(async () =>
            {
                RestClient client = new RestClient();
                var mainpage = await client.Get<WingetResult>("http://192.168.0.73/api/account");
                if (mainpage != null)
                {
                    error = mainpage.firstName;
                    LabelChange.Text = error;
                }
                else
                {
                    LabelChange.Text = "sorry67868";
                }

            });

        }

    }
}