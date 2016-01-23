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
    class Other : Item
    {
        public string Type { get; set; }
        public string Description { get; set; }

        public Other()
        {

        }

        public Other(string name, string maker, string type, string description)
            :base(name, maker)
        {
            Type = type;
            Description = description;
        }

        public override string ToString()
        {
            return base.ToString() + "\nType: " + Type + "\nDescription: " + Description;
        }
    }
}
