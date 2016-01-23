/*
 * Created: 19/01/2016
 * Author: Juuso Minkkilä
 */
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_6
{
    class Paper : Item
    {
        public int Pages { get; set; }
        public string Type { get; set; }

        public Paper()
        {

        }

        public Paper(string name, string maker, string type, int pages)
            : base(name, maker)
        {
            Pages = pages;
            Type = type;
        }

        public override string ToString()
        {
            return base.ToString() + "\nType: " + Type + "\nPages: " + Pages;
        }
    }
}
