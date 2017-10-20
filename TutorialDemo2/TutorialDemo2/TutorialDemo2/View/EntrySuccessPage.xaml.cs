using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialDemo2.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TutorialDemo2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntrySuccessPage : ContentPage
    {
        public EntrySuccessPage()
        {
            InitializeComponent();
            EntrySuccessPageViewModel v = new EntrySuccessPageViewModel();
            BindingContext = v;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EntryPage());

        }
    }
}