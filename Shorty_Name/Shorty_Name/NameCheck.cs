using System;
using System.Collections.Generic;
using System.Text;

namespace Shorty_Name
{
   public class NameCheck
    {
        public string Name { get; set; }
        public bool isChecked { get; set; }
        public NameCheck(string name, bool Ischecked)
        {
            this.Name = name;
            this.isChecked = Ischecked;
        }
    }
}
