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
    class External : Memory
    {
        public string Connection { get; set; }

        public External()
        {

        }

        public External(string name, string maker, string type, string capacity, string connection)
            : base(name, maker, type, capacity)
        {
            Connection = connection;
        }
    }
}
