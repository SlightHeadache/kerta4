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
    class Memory : Item
    {
        public string Capacity { get; set; }
        public string Type { get; set; }

        public Memory()
        {

        }

        public Memory(string name, string maker, string type, string capacity)
            : base(name, maker)
        {
            Capacity = capacity;
            Type = type;
        }

        public override string ToString()
        {
            return base.ToString() + "\nType: " + Type + "\nCapacity: " + Capacity;
        }
    }
}
