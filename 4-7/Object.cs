using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_7
{
    class Text : Item
    {
        public int Pages { get; set; }

        public Text()
        {
            Type = "Text file";
        }

        public override string ToString()
        {
            return base.ToString() + "\nPages: " + Pages;
        }
    }

    class Picture : Item
    {
        public Picture()
        {
            Type = "Picture";
        }
    }

    class Other : Item
    {
        public Other()
        {
            Type = "Other";
        }
    }
}
