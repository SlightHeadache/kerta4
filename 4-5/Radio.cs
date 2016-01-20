/*
 * Created: 19/01/2016
 * Author: Juuso Minkkilä
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5
{
    class Radio
    {
        //min and max frequencies
        private readonly double minFreq = 2000.0, maxFreq = 26000.0;
        //min and max volume
        private readonly int minVol = 0, maxVol = 9;

        //member fields
        private double freq;
        private int vol;

        //properties
        public double Freq
        {
            get
            {
                return freq;
            }
            set
            {
                if (value < minFreq)
                {
                    Console.WriteLine("You can't set the frequency that low. Instead, you set it to {0}.", minFreq);
                    freq = minFreq;
                }
                if (value > maxFreq)
                {
                    Console.WriteLine("You can't set the frequency that high. Instead, you set it to {0}.", maxFreq);
                    freq = maxFreq;
                }
                else
                    freq = value;
            }
        }
        public int Vol
        {
            get
            {
                return vol;
            }
            set
            {
                if (value < minVol)
                {
                    Console.WriteLine("You can't set the volume that low. Instead, you set it to {0}.", minVol);
                    vol = minVol;
                }
                if (value > maxVol)
                {
                    Console.WriteLine("You can't set the volume that high. Instead, you set it to {0}.", maxVol);
                    vol = maxVol;
                }
                else
                    vol = value;
            }
        }
        public bool IsOn { get; set; }

        //construct
        //public Radio()
        //{
        //    IsOn = false;
        //    Vol = 3;
        //    Freq = 5000.0;
        //}
    }
}
