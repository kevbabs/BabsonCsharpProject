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

            //do while loop
            Console.WriteLine("Enter the kid temperature");
            int kidTemp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The kids temp is {0}", kidTemp);

            //    do
            //    {
            //        Console.WriteLine("Give the patient 100g of paracetamore");
            //        kidTemp++;
            //    } while (kidTemp <35);
            //Console.WriteLine("Don't give medication if tem is greater than 35");

            //while (kidTemp <15)
            //{
            //    Console.WriteLine("Give the kids 100g of paracetemore");
            //    kidTemp++;
            //    Console.WriteLine(" the kids tem is now {0}", kidTemp);
            //}
            for (int drugDosage = kidTemp; drugDosage < 40; drugDosage++)
            {
                Console.WriteLine("Increase the doseage to {0}", drugDosage);
            }

                Console.ReadLine();
            }

        }
    }


