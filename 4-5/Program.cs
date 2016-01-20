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
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();
            radio.IsOn = false;
            radio.Vol = 3;
            radio.Freq = 5000.3;
            int choise, volBuffer;
            double freqBuffer;
            bool checker;
            Console.WriteLine("You are looking at a radio. It appears to be off.");
            for (;;)
            {
                if (radio.IsOn == false)
                {
                    Console.WriteLine("0. Leave");
                    Console.WriteLine("1. Press the power switch");
                    Console.Write(">> ");
                    checker = int.TryParse(Console.ReadLine(), out choise);
                    if (checker == false)
                    {
                        Console.WriteLine("That's not a valid input.");
                    }
                    else if (choise == 0)
                        break;
                    else
                    {
                        switch (choise)
                        {
                            case 1:
                                Console.WriteLine("You turn the radio on. Its volume is {0} and frequency {1}.", radio.Vol, radio.Freq);
                                radio.IsOn = true;
                                break;
                            default:
                                Console.WriteLine("That's not a valid input.");
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("0. Leave");
                    Console.WriteLine("1. Press the power switch");
                    Console.WriteLine("2. Change volume");
                    Console.WriteLine("3. Change frequency");
                    Console.Write(">> ");
                    checker = int.TryParse(Console.ReadLine(), out choise);
                    if (checker == false)
                    {
                        Console.WriteLine("That's not a valid input.");
                    }
                    else if (choise == 0)
                        break;
                    else
                    {
                        switch (choise)
                        {
                            case 1:
                                Console.WriteLine("You turn the radio off.");
                                radio.IsOn = false;
                                break;
                            case 2:
                                Console.WriteLine("Give new volume");
                                Console.Write(">> ");
                                checker = int.TryParse(Console.ReadLine(), out volBuffer);
                                if (checker == false)
                                {
                                    Console.WriteLine("That's not a valid input.");
                                }
                                else
                                {
                                    radio.Vol = volBuffer;
                                    Console.WriteLine("The current volume is {0} and frequency is {1}.", radio.Vol, radio.Freq);
                                }
                                break;
                            case 3:
                                Console.WriteLine("Give new volume");
                                Console.Write(">> ");
                                checker = double.TryParse(Console.ReadLine(), out freqBuffer);
                                if (checker == false)
                                {
                                    Console.WriteLine("That's not a valid input.");
                                }
                                else
                                    radio.Freq = freqBuffer;
                                Console.WriteLine("The current volume is {0} and frequency is {1}.", radio.Vol, radio.Freq);
                                break;
                            default:
                                Console.WriteLine("That's not a valid input.");
                                break;
                        }
                    }
                }
            }
        }
    }
}
