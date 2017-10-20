using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialDemo2.Model;
using TutorialDemo2.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TutorialDemo2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PostServicePage : ContentPage
    {
        public PostServicePage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Device.BeginInvokeOnMainThread(async () =>
            {
                Login login = new Login();

                login.username = "aitrich@lamit";
                login.password = "aitrich";
                login.rememberMe = false;

               RestClient client = new RestClient();
                
                var account = await client.PostItems<Authorization>(login, true);
                PostLabel.Text = account.id_token;
            });
        }
    }
}