﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your age");

            //console.WriteLine("Enter your age");
            ////string boroughName = Console.ReadLine();
            //int myAge = Convert.ToInt32(Console.ReadLine());

            ////switch statement
            //switch (myAge)
            //{
            //    case 30:
            //        Console.WriteLine(" My age is {0}", myAge);
            //        break;
            //    case 45:
            //        Console.WriteLine("My age is {0}", myAge);
            //        break;
            //    default:
            //        Console.WriteLine("Sorry you are not in the age group, {0}, try another age group", myAge);
            //        break;

            Console.WriteLine("Did statement run");

            for (int counter = 0; counter <= 20; counter += 5)
            {
                Console.WriteLine("Display the counter" + counter);
            }
            Console.WriteLine();

            controll statement

            string[] londonBorough = { "newham", "sutton", "barnet", "earling" };
            foreach (var borough in londonBorough)
            {
                if (borough.ToLower().Equals("SUTTON".ToLower()))
                {
                    Console.WriteLine("I found my borough {0}", borough.ToLower());
                }
                else
                {
                    Console.WriteLine("borough {0} this not my borough", borough);
                }

                Console.ReadLine();
            }

        }
    }


