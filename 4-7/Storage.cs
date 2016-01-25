using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_7
{
    class Archive : Container
    {
        public Archive()
        {
            Contains = "Crates";
            Type = "Archive";
        }
    }

    class Crate : Container
    {
        public int Volume { get; set; }

        public Crate()
        {
            Contains = "Folders";
            Type = "Crate";
        }

        public override string ToString()
        {
            return base.ToString() + "\nVolume: " + Volume;
        }
    }

    class Folder : Container
    {
        public Folder()
        {
            Contains = "Files";
            Type = "Folder";
        }
    }
}
