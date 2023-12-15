using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Trigger.ViewModels
{
    public class ViewModelPeople : BaseViewModels
    {
        private string color;
        public string Color
        {
            get { return this.color; }
            set { SetValue(ref this.color, value); }
        }


        private string filter;
        public string Filter
        {
            get { return this.filter; }
            set { SetValue(ref this.filter, value); }
        }

        private List<Person> people;
        public List<Person> People
        {
            get { return this.people; }
            set { SetValue(ref this.people, value); }
        }


        public ICommand SearchCommand { get; set; }

        public ViewModelPeople()
        {

            SearchCommand = new Command(() =>
            {
                PersonService service = new PersonService();
                People = service.GetByText(Filter);
                if (People.Count > 3)
                    Color = "Red";
                else
                    Color = "Blue";

            });


        }


    }
}