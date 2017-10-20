using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialDemo2.Model;

namespace TutorialDemo2.ViewModel
{
    class EntrySuccessPageViewModel
    {
        public ObservableCollection<Person> People { get; set; } =
          new ObservableCollection<Person>();
        public EntrySuccessPageViewModel()
        {
            Person person = new Person();
            person.FirstName = "Aswani";
            person.LastName = "Unni";
            person.PhoneNumber = "452-785";
           
            People.Add(person);
            PopulatePeople();
        }
        private async void PopulatePeople()
        {
            List<Person> people = await App.Database.GetPeopleAsync();
            foreach(Person person in people)
            {
                People.Add(person);
            }
        }
    }
}
