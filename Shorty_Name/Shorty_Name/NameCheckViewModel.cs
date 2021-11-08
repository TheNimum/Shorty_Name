using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Shorty_Name
{ 
    class NameCheckViewModel
    {
        public ObservableCollection<NameCheck> NameChecks { get; set; }

        public NameCheckViewModel()
        {
            NameChecks = new ObservableCollection<NameCheck>
            {
                new NameCheck("Mikael", false),
                new NameCheck("Jerry", false),
                new NameCheck("Hampus", false)
            };

        }
        public ICommand AddNameCommand => new Command(AddName);
        public string NewNameInput { get; set; }
        void AddName()
        {
            NameChecks.Add(new NameCheck(NewNameInput, false));

        }
        public ICommand RemoveNameCommand => new Command(RemoveNameFromList);
        void RemoveNameFromList(object o)
        {
            NameCheck NameRemoved = o as NameCheck;
            NameChecks.Remove(NameRemoved);

        }


    }
}
 