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
            NameChecks = new ObservableCollection<NameCheck>();

            NameChecks.Add(new NameCheck("Mikael", false));
            NameChecks.Add(new NameCheck("Jerry", false));
            NameChecks.Add(new NameCheck("Hampus", false));
            
        }
        public ICommand AddNameCommand => new Command(addName);
        public string NewNameInput { get; set; }
        void addName()
        {
            NameChecks.Add(new NameCheck(NewNameInput, false));

        }



    }
}
 