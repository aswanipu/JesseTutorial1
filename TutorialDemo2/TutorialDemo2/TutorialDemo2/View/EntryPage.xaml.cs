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
    public partial class EntryPage : ContentPage
    {
        EntryPageViewModel vm;
        public EntryPage()
        {
            InitializeComponent();
            vm = new EntryPageViewModel();
            BindingContext = vm;
        }

        private void AddEntry(object sender, EventArgs e)
        {
            vm.AddToPeople();
           
            Navigation.PushAsync(new EntrySuccessPage());
        }
    }
}