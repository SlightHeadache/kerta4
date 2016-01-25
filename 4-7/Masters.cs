using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_7
{
    class Container
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Contains { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return "\n\nName: " + Name + "\nType: " + Type + "\nContains: "+ Contains + "\nDescription: " + Description;
        }
    }

    class Item
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return "\n\nName: " + Name + "\nType: " + Type + "\nDescription: " + Description;
        }
    }
}
