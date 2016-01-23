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
    class Program
    {
        static void Main(string[] args)
        {
            Paper book = new Paper("Hyviä Enteitä", "Terry Pratchett, Neil Gaiman", "Book", 398);
            Paper magazine = new Paper("Pelit 9/2012", "Sanoma Magazines", "Magazine", 75);
            Memory dvdRom = new Memory("Battlefield 3", "DICE", "DVD ROM", "10 GB");
            External usb = new External("Tanscend 8 GB", "Tanscend", "Flash drive", "8 GB", "USB 2.0");
            Other pen = new Other("Pen", "Ballograph", "Ballpoint", "<N/A>");
            Console.WriteLine(book.ToString() + "\n");
            Console.WriteLine(magazine.ToString() + "\n");
            Console.WriteLine(dvdRom.ToString() + "\n");
            Console.WriteLine(usb.ToString() + "\n");
            Console.WriteLine(pen.ToString() + "\n");
            Console.Read();
        }
    }
}
