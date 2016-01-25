/*
 * Created: 25/01/2016
 * Author: Juuso Minkkilä
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Archive[] archives = new Archive[2];
            for (int i = 0; i <= 1; i++)
            {
                archives[i] = new Archive();
                archives[i].Name = "A" + i;
                archives[i].Description = "<N/A>";
                Console.Write(archives[i].ToString());
            }

            Crate[] cratesA1 = new Crate[2];
            for (int i = 0; i <= 1; i++)
            {
                cratesA1[i] = new Crate();
                cratesA1[i].Name = "A1C" + i;
                cratesA1[i].Description = "<N/A>";
                cratesA1[i].Volume = 21;
                Console.Write(cratesA1[i].ToString());
            }

            Folder[] foldersA1C1 = new Folder[2];
            for (int i = 0; i <= 1; i++)
            {
                foldersA1C1[i] = new Folder();
            }

            foldersA1C1[1].Name = "Taxes";
            foldersA1C1[1].Description = "Blue folder that seems to contain complicated forms";
            Console.Write(foldersA1C1[1].ToString());

            Text taxform = new Text();
            taxform.Name = "Taxform";
            taxform.Description = "Dull";
            taxform.Pages = 6;
            Console.Write(taxform.ToString());

            foldersA1C1[0].Name = "Personal";
            foldersA1C1[0].Description = "Contains a mix of different things";
            Console.Write(foldersA1C1[0].ToString());

            Picture photo = new Picture();
            photo.Name = "Summer";
            photo.Description = "What a lovely photo";
            Console.Write(photo.ToString());

            Other coin = new Other();
            coin.Name = "Coin";
            coin.Description = "Made of brass";
            Console.Write(coin.ToString());

            Console.Read();
        }
    }
}
