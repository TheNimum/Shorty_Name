using System;
using System.Collections.Generic;
using System.Text;

namespace Shorty_Name
{
   public class NameCheck
    {
        public string Name { get; set; }
        public bool IsChecked { get; set; }
        public NameCheck(string name, bool Ischecked)
        {
            this.Name = name;
            this.IsChecked = Ischecked;
        }
    }
}
