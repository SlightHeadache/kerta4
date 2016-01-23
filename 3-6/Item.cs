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
    class Item
    {
        public string Name { get; set; }
        public string Maker { get; set; }
        
        public Item()
        {

        }

        public Item(string name, string maker)
        {
            Name = name;
            Maker = maker;
        }

        public override string ToString()
        {
            return "Name: " + Name + "\nMaker: " + Maker;
        }
    }
}
